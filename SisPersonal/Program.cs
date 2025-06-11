using System;

class Program
{
    static void Main(string[] args)
    {
        // c. Crear 3 empleados
        Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado("Juan", "Pérez", new DateTime(1985, 6, 1), "Casado", new DateTime(2010, 3, 15), 650000, Cargos.Ingeniero);
        empleados[1] = new Empleado("Laura", "González", new DateTime(1964, 4, 22), "Soltero", new DateTime(2000, 7, 1), 720000, Cargos.Administrativo);
        empleados[2] = new Empleado("Carlos", "Ramírez", new DateTime(1972, 12, 10), "Casado", new DateTime(2005, 1, 5), 600000, Cargos.Especialista);

        // d. Calcular el total de salarios
        double totalSalarios = 0;
        foreach (var empleado in empleados)
        {
            totalSalarios += empleado.CalcularSalario();
        }

        Console.WriteLine("=== MONTO TOTAL EN SALARIOS ===");
        Console.WriteLine($"Total: ${totalSalarios:N2}\n");

        // e. Buscar el empleado más próximo a jubilarse
        Empleado proximoAJubilarse = empleados[0];

        foreach (var empleado in empleados)
        {
            if (empleado.AniosParaJubilarse < proximoAJubilarse.AniosParaJubilarse)
            {
                proximoAJubilarse = empleado;
            }
        }

        Console.WriteLine("=== EMPLEADO MÁS PRÓXIMO A JUBILARSE ===");
        Console.WriteLine($"Nombre: {proximoAJubilarse.Nombre} {proximoAJubilarse.Apellido}");
        Console.WriteLine($"Edad: {proximoAJubilarse.Edad}");
        Console.WriteLine($"Antigüedad: {proximoAJubilarse.Antiguedad} años");
        Console.WriteLine($"Años para jubilarse: {proximoAJubilarse.AniosParaJubilarse}");
        Console.WriteLine($"Salario: ${proximoAJubilarse.CalcularSalario():N2}");
    }
}
