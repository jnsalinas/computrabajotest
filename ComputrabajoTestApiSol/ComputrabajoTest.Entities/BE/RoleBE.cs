using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ComputrabajoTest.Entities.BE.Base;

namespace ComputrabajoTest.Entities.BE
{
    [Table("Role")]
    public class RoleBE : BaseBE
    {
        [MaxLength(20)]
        public override string Name { get; set; } = string.Empty;
    }
}

