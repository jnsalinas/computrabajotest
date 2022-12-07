using System;
using ComputrabajoTest.Entities.Enum;

namespace ComputrabajoTest.Entities.Base
{
	public class BaseOut
	{
        public Result result { get; set; }
        public string message { get; set; }
        public string exception { get; set; }
    }
}

