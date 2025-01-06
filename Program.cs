using System.Globalization;
using exercicio_classes_03;

/* Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). 
Você deve criar uma classe Aluno para resolver este problema. */



namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno x = new Aluno();

            Console.Write("Nome do aluno: ");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            x.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nNOTA FINAL = " + x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (x.Aprovado())
            {
                Console.WriteLine("** APROVADO **");
            }
            else
            {
                Console.WriteLine("** REPROVADO **");
                Console.WriteLine($"FALTARAM " + x.Pontos().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }
    }
}
