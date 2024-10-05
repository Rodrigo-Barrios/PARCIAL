using System.ComponentModel.DataAnnotations.Schema;


namespace PARCIAL.Models
{
    [Table("t_listado_remesas")]
    public class ListadoRemesas
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public decimal TasaConversion { get; set; }
        public decimal TipoConversion { get; set; }  
    }
}