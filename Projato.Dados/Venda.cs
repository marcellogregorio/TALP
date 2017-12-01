using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projato.Dados
{
    [Table("Venda")]
    public partial class Venda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venda()
        {

        }
        [Key]
        public int ID_VENDA { get; set; }
        [Required]
        public int ID_PRODUTO { get; set; }
        [Required]
        public int ID_CLIENTE { get; set; }
        [Required]
        public int QTDE { get; set; }
        [Required]
        public DateTime DT_HR_COMPRA { get; set; }


    }
}
