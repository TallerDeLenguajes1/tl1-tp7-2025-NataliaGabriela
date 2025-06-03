namespace EspacioCalculadora;

public class Calculadora
{
    private double termino;
    public double Resultado
    {
        get => termino;
    }
    public void Sumar(double Termino)
    {
        termino += Termino;
    }
    public void Restar(double Termino)
    {
        termino -= Termino;
    }
    public void Multiplicar(double Termino)
    {
        termino = Resultado * Termino;
    }
    public void Dividir(double Termino)
    {
        if (Termino != 0)
        {
            termino /= Termino;
        }
        else
        {
            Console.WriteLine("No se puede dividir por cero.");
        }
    }
    public void Limpiar()
    {
        termino = 0;
    }
}