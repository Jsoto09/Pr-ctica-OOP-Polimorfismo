//Johan German 2023-1391


namespace Salario_Johan_German
{
    public class DocenteContratoFijo : Empleado
    {
        public decimal SalarioFijo { get; set; }
        public bool MetaAlcanzada { get; set; }

        public DocenteContratoFijo(string nombre, decimal salarioFijo, bool metaAlcanzada)
            : base(nombre, "Docente Contrato Fijo")
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
