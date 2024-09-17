//Johan German 2023-1391

namespace Salario_Johan_German
{
    public class EmpleadoAdministrativo : Empleado
    {
        public decimal SalarioFijo { get; set; }
        public bool MetaAlcanzada { get; set; }

        public EmpleadoAdministrativo(string nombre, decimal salarioFijo, bool metaAlcanzada)
            : base(nombre, "Empleado Administrativo")
        {
            SalarioFijo = salarioFijo;
            MetaAlcanzada = metaAlcanzada;
        }

        public override decimal CalcularSalario()
        {
            return MetaAlcanzada ? SalarioFijo : SalarioFijo / 2;
        }
    }
}
