using System.ComponentModel.DataAnnotations.Schema;

namespace PARCIAL.Models
{
    [Table("t_remesa")]
    public class Remesa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string? NombreRemitente { get; set; }
        public string? NombreDestinatario { get; set; }
        public string? PaisOrigen { get; set; }
        public string? PaisDestino { get; set; }
        public decimal MontoEnviado { get; set; }
        public decimal TasaCambio { get; set; }
        public decimal MontoFinal { get; set; }
        public string? EstadoTransaccion { get; set; } 
    }
}