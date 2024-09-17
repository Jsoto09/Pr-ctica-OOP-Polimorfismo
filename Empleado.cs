//Johan German 2023-1391

namespace Salario_Johan_German
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public Empleado(string nombre, string tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
        }

        public abstract decimal CalcularSalario();
    }
}
