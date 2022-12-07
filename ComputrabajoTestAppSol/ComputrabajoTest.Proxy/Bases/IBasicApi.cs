using System;
using System.Runtime.InteropServices;

namespace ComputrabajoTest.Proxy.Bases
{
    public interface IBasicApi<T> where T : class
    {
        Task<T> Get(string partialPath, Dictionary<string, string>? parameters);
    }
}

