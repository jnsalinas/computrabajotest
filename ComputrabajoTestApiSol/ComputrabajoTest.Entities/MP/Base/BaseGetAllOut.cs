using System;
namespace ComputrabajoTest.Entities.MP.Base
{
    /// <summary>
    /// base class to return api data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseGetAllOut<T> : BaseOut
    {
        public List<T> ListResult { get; set; } = new List<T>();
        public int? TotalRows { get; set; }
    }
}

