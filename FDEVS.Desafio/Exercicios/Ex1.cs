namespace FDEVS.Desafio.Exercicios;

public class Ex1
{
    public int Soma { get; set; }
    public double Exercicio()
    {
        for (int i = 1; i <= 10; i++)
        {
            Soma += i;
        }
        return Soma;
    }
}
