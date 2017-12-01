namespace Projato.Dados
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contato")]
    public partial class Contato
    {
        [Key]
        public int IdContato { get; set; }

        public int DddContato { get; set; }

        public int TelefoneContato { get; set; }

        public int Tipo_ContatoIdTipoContato { get; set; }

        public int Pessoa_JuridicaIdPessoaJuridica { get; set; }

        public int Pessoa_FisicaIdPessoaFisica { get; set; }
    }
}
