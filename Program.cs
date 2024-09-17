//Johan German 2023-1391


using Salario_Johan_German;

class Program
{
    static void Main(string[] args)
    {
        DocentePorHora docentePorHora = new DocentePorHora("Johan German", 100);
        DocenteContratoFijo docenteContratoFijo = new DocenteContratoFijo("Euris Guerrero", 4000, true);
        EmpleadoAdministrativo administrativo = new EmpleadoAdministrativo("Victor Manuel", 3500, false);

        Console.WriteLine($"Salario de {docentePorHora.Nombre} ({docentePorHora.Tipo}): {docentePorHora.CalcularSalario()}");
        Console.WriteLine($"Salario de {docenteContratoFijo.Nombre} ({docenteContratoFijo.Tipo}): {docenteContratoFijo.CalcularSalario()}");
        Console.WriteLine($"Salario de {administrativo.Nombre} ({administrativo.Tipo}): {administrativo.CalcularSalario()}");
    }
}
