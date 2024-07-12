using FDEVS.Desafio.Exercicios;
namespace FDEVS.Desafio;

public class Program
{
    static void Main()
    {
        var escolhaExercicio = -1;
        while (escolhaExercicio != 0)
        {
        Console.WriteLine("Qual exercício deseja exibir?\n1 = Soma de 1 a 10\n2 = IMC\n3 = Calculadora\n0 = Sair");
        escolhaExercicio = Convert.ToInt32(Console.ReadLine());
            switch (escolhaExercicio)
            {
                case 1:
                    Ex1 ex1 = new();
                    ex1.Exercicio();
                    Console.WriteLine("A soma dos números de 1 a 10 é: " + ex1.Soma);
                    break;
                case 2:
                    Ex2 ex2 = new();
                    ex2.Exercicio();
                    Console.WriteLine("O seu IMC é: " + ex2.IMC);
                    break;
                case 3:
                    Ex3 ex3 = new();

                    ex3.Exercicio();
                    break;
            }
            if(escolhaExercicio != 3 && escolhaExercicio != 0)
            {
                Console.WriteLine("Pressione [ENTER] para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
