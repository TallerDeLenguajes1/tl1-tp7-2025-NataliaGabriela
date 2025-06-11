using System;

public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private string estadoCivil;
    private DateTime fechaIng;
    private double sueldoBasico;
    private Cargos cargos;

    public Empleado(string nombre, string apellido, DateTime fechaNac, string estadoCivil, DateTime fechaIng, double sueldoBasico, Cargos cargos)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNac = fechaNac;
        this.estadoCivil = estadoCivil;
        this.fechaIng = fechaIng;
        this.sueldoBasico = sueldoBasico;
        this.cargos = cargos;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
    public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIng { get => fechaIng; set => fechaIng = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public Cargos Cargos { get => cargos; set => cargos = value; }

    // a.i. Antigüedad
    public int Antiguedad
    {
        get
        {
            int antiguedad = DateTime.Now.Year - fechaIng.Year;
            if (DateTime.Now < fechaIng.AddYears(antiguedad)) antiguedad--;
            return antiguedad;
        }
    }

    // a.ii. Edad
    public int Edad
    {
        get
        {
            int edad = DateTime.Now.Year - fechaNac.Year;
            if (DateTime.Now < fechaNac.AddYears(edad)) edad--;
            return edad;
        }
    }

    // a.iii. Años para jubilarse
    public int AniosParaJubilarse
    {
        get
        {
            int faltan = 65 - Edad;
            return faltan > 0 ? faltan : 0;
        }
    }

    // b. Cálculo del salario
    public double CalcularSalario()
    {
        double adicional = 0;
        int antiguedad = this.Antiguedad;

        // i) Cálculo base según antigüedad
        if (antiguedad <= 20)
        {
            adicional = sueldoBasico * (0.01 * antiguedad);
        }
        else
        {
            adicional = sueldoBasico * 0.25;
        }

        // ii) Cargo especial
        if (cargos == Cargos.Ingeniero || cargos == Cargos.Especialista)
        {
            adicional *= 1.5;
        }

        // iii) Casado
        if (estadoCivil.ToLower() == "casado")
        {
            adicional += 150000;
        }

        return sueldoBasico + adicional;
    }
}
