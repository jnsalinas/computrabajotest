using System;
using ComputrabajoTest.Entities.MP.Enum;

namespace ComputrabajoTest.Entities.MP.Base
{
    //base out for api responses
    public class BaseOut
    {
        public Result Result { get; set; } = Result.Success;
        public string Message { get; set; } = string.Empty;
        public string Exception { get; set; } = string.Empty;
    }
}

