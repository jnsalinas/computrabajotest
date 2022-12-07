using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ComputrabajoTest.Entities.BE.Base;

namespace ComputrabajoTest.Entities.BE
{
    [Table("Status")]
    public class StatusBE : BaseBE
	{
        [MaxLength(15)]
        public override string Name { get; set; } = string.Empty;
    }
}

