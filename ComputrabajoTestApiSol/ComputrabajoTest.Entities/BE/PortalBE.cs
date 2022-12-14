using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ComputrabajoTest.Entities.BE.Base;

namespace ComputrabajoTest.Entities.BE
{
    [Table("Portal")]
    public class PortalBE : BaseBE
	{
        [MaxLength(50)]
        public override string Name { get; set; } = string.Empty;
    }
}

