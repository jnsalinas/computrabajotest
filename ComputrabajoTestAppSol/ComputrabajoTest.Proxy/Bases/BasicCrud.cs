using System;
using ComputrabajoTest.Proxy.Constants;
using System.Net;
using RestSharp.Portable.HttpClient;
using RestSharp.Portable;
using ComputrabajoTest.Helper;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using ComputrabajoTest.Entities.Base;
using ComputrabajoTest.Entities.Enum;
using System.Data;
using ComputrabajoTest.Entities;

namespace ComputrabajoTest.Proxy.Bases
{
    public class BasicCrud<T> : IBasicApi<T> where T : class
    {
        protected RestClient Client;
        public BasicCrud()
        {
            Client = new RestClient($"{Settings.DOMAIN}");
        }

        /// <summary>
        /// Generic get with http request
        /// </summary>
        /// <param name="partialPath"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual async Task<T> Get(string partialPath, Dictionary<string, string>? parameters = null)
        {
            try
            {
                var request = new RestRequest(partialPath, Method.GET);

                if (parameters != null && parameters.Any())
                {
                    foreach (var item in parameters)
                    {
                        request.AddQueryParameter(item.Key, item.Value);
                    }
                }

                var result = await Client.Execute<T>(request);
                if (result.IsSuccess)
                {
                    BaseOut? baseResult = result.Data as BaseOut;
                    if(baseResult != null && baseResult.result != Result.Success)
                        throw new Exception(baseResult.message);

                    return result.Data;
                }

                Console.WriteLine($"Exception - save log or define action");
                throw new Exception(result.StatusCode.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception - save log or define action {ex.Message}");
                throw;
            }
        }
    }
}

