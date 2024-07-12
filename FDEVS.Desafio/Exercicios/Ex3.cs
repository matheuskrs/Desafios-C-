namespace FDEVS.Desafio.Exercicios;

public class Ex3
{
    public double Resultado { get; set; }
    public double N1 { get; set; }
    public double N2 { get; set; }
    public int Opcao { get; set; }

    public void Exercicio()
    {
        Opcao = -1;
        Console.Clear();
        while (Opcao != 0)
        {
            Console.WriteLine("Calculadora\n1 = Soma\n2 = Subtração\n3 = Multiplicação\n4 = Divisão\n0 = Voltar à lista de exercícios");
            Opcao = Convert.ToInt32(Console.ReadLine());
            if (Opcao != 0)
            {
                Console.WriteLine("Qual é o primeiro número?");
                N1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Qual é o segundo número?");
                N2 = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.Clear();
            }
            switch (Opcao)
            {
                case 1:
                    Console.WriteLine("O resultado da soma é: " + Soma());
                    break;
                case 2:
                    Console.WriteLine("O resultado da subtração é: " + Subtracao());
                    break;
                case 3:
                    Console.WriteLine("O resultado da multiplicação é: " + Multiplicacao());
                    break;
                case 4:
                    Console.WriteLine("O resultado da divisão é: " + Divisao());
                    break;
                case 0:
                    break;
            }
            if (Opcao != 0)
            {
                Console.WriteLine("Pressione [ENTER] para continuar");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.Clear();
            }
        }
    }

    public double Soma()
    {
        Resultado = N1 + N2;
        return Resultado;
    }
    public double Subtracao()
    {
        Resultado = N1 - N2;
        return Resultado;
    }
    public double Multiplicacao()
    {
        Resultado = N1 * N2;
        return Resultado;
    }
    public double Divisao()
    {

        Resultado = N1 / N2;
        return Resultado;
    }
}
