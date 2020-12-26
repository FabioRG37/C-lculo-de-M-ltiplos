using System;
class Aula25
{
    static void Main()
    {
        Console.Clear();
        int opt;
        Console.WriteLine("--- Calculando Múltiplos ---\n");
        Console.WriteLine(" --- --- --- MENU --- --- --- \n");
        Console.WriteLine("1 - Calcular tabela de múltiplos");
        Console.WriteLine("2 - Calcular múltiplo de um número");
        Console.WriteLine("3 - Sair");
        Console.Write("\nDigite a opção desejada: ");
        opt = int.Parse(Console.ReadLine());
        if(opt == 1)
            Tabela();
        else if (opt == 2)
            Multiplos();
        else
        {
            Console.Clear();
            Console.WriteLine("Programa Encerrado!");
        }
    }

    static void Tabela()
    {
        inicio:
        Console.Clear();
        int opT;
        Console.WriteLine(" --- Criando tabela de Múltiplos --- \n");
        Console.Write("Digite até qual número deseja ir: ");
        opT = int.Parse(Console.ReadLine());
        Console.WriteLine("\nnúmero \t| múltiplos");
        for (int i = 1; i <= opT; i++)
        {
            Console.Write("{0} - \t| ", i);
            for (int j = 1; j <= i; j++)
                Console.Write(i * j + "\t");
            Console.WriteLine("\n");
        }
        Console.WriteLine("\nDeseja fazer nova tabela?\n");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        Console.Write("\nDigite a opção desejada: ");
        opT = int.Parse(Console.ReadLine());
        if (opT == 1)
            goto inicio;
        else
            Main();

    }

    static void Multiplos()
    {
        inicio:
        Console.Clear();
        int opM;
        Console.WriteLine(" --- --- --- Múltiplos --- --- --- \n");
        Console.Write("\nDigite o número para calcular: ");
        opM = int.Parse(Console.ReadLine());
        Console.WriteLine("\nnúmero \t| múltiplos\n");
        Console.Write(opM + "\t| ");
        for (int i = 1; i <= 10; i++)
            Console.Write(i * opM + "\t");
        Console.Write("\n");
        Console.WriteLine("\nDeseja calcular novamente?\n");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        Console.Write("\nDigite a opção desejada: ");
        opM = int.Parse(Console.ReadLine());
        if (opM == 1)
            goto inicio;
        else
            Main();
    }
}