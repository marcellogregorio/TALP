namespace Projato.Dados
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Login()
        {
            Perfil_Acesso = new HashSet<Perfil_Acesso>();
        }

        [Key]
        public int IdLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string EmailLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string SenhaLogin { get; set; }

        [Required]
        [StringLength(50)]
        public string IdSocial { get; set; }

        [Required]
        [StringLength(60)]
        public string NomeLogin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Perfil_Acesso> Perfil_Acesso { get; set; }
    }
}
