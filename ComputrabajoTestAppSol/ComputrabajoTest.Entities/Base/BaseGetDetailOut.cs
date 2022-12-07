using System;
namespace ComputrabajoTest.Entities.Base
{
	public class BaseGetDetailOut<T> : BaseOut
    {
        public T? resultEntity { get; set; }

    }
}

