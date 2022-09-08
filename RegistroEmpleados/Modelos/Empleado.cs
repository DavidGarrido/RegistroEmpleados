using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEmpleados.Modelos
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        [ForeignKey("CargoId")]
        public int CargoId { get; set; }
        [ForeignKey("SalarioId")]
        public int SalarioId { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
