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
        public int IdCargo { get; set; }
        public int IdSalario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual Salario Salario { get; set; }
    }
}
