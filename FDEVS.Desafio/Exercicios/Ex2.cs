namespace FDEVS.Desafio.Exercicios;

public class Ex2
{
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double IMC { get; set; }
    public double Exercicio()
    {
        Console.WriteLine("Qual é o seu peso? (em kg)");
        Peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Qual é a sua altura? (em metros)");
        Altura = Convert.ToDouble(Console.ReadLine());
        IMC = Peso / (Altura * Altura);
        return IMC;
    }
}
