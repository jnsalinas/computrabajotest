using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ComputrabajoTest.Entities.BE.Base;

namespace ComputrabajoTest.Entities.BE
{
    [Table("User")]
    public class UserBE : BaseBE
    {
        #region properties
        [MaxLength(50)]
        public override string Name { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }

        public DateTime? DeletedOn { get; set; }

        [MaxLength(65)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(30)]
        public string Fax { get; set; } = string.Empty;

        public DateTime? LastLogin { get; set; }

        [MaxLength(150)]
        public string Password { get; set; } = string.Empty;

        public string Telephone { get; set; } = string.Empty;

        public DateTime UpdatedOn { get; set; }

        [MaxLength(30)]
        public string Username { get; set; } = string.Empty;
        #endregion

        #region foreigns keys
        [Required]
        public int PortalaId { get; set; }
        [ForeignKey("PortalaId")]
        public PortalBE Portal { get; set; }

        [Required]
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public RoleBE Role { get; set; }

        [Required]
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public StatusBE Status { get; set; }

        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public CompanyBE Company { get; set; }
        #endregion
    }
}

