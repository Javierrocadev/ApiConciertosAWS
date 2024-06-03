using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiConciertosAWS.Models
{
        [Table("categoriaevento")]
        public class Categoriaevento
        {
            [Key]
            [Column("idcategoria")]
            public int IdCategoria { get; set; }

            [Column("nombre")]
            public string Nombre { get; set; }
        }
}
