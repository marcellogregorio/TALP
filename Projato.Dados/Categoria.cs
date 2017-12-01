namespace Projato.Dados
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Categoria")]
    public partial class Categoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categoria()
        {
           // Produto = new HashSet<Produto>();
        }

        [Key]
        public int IdCategoria { get; set; }

        [Required]
        [StringLength(60)]
        public string DescricaoCategoria { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] ImagemCategoria { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Produto> Produto { get; set; }
    }
}
