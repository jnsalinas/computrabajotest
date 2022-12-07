using System;
namespace ComputrabajoTest.Entities.MP.Base
{
    public class BaseGetDetailOut<T> : BaseOut
    {
        public T? ResultEntity { get; set; }
    }
}

