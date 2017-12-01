namespace Projato.Dados
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Produto")]
    public partial class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        public int CategoriaIdCategoria { get; set; }

        [Required]
        [StringLength(60)]
        public string NomeProduto { get; set; }

        [Required]
        [StringLength(150)]
        public string DescricaoProduto { get; set; }

        public double ValorProduto { get; set; }

        [Column(TypeName = "image")]
        public byte[] ImagemProduto { get; set; }

        [Required]
        [StringLength(1)]
        public string IndicadorVitrine { get; set; }

        //public virtual Categoria Categoria { get; set; }
    }
}
