//Johan German 2023-1391

namespace Salario_Johan_German
{
    public class DocentePorHora : Empleado
    {
        public int HorasTrabajadas { get; set; }
        public decimal TarifaPorHora { get; set; } = 800;

        public DocentePorHora(string nombre, int horasTrabajadas)
            : base(nombre, "Docente por Hora")
        {
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularSalario()
        {
            return HorasTrabajadas * TarifaPorHora;
        }
    }
}
