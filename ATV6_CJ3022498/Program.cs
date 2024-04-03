int opcãogeral;

Console.WriteLine("**Lista 6** \n 1-Atividade em sala \n 2-Exercicio 1 \n 3-Exercicio 2 \n 4-Exercicio 3 \n 5-Exercicio 4 \n 6-Exercicio 5 \n 7-Exercicio 6 \n 8-Exercicio 7");
opcãogeral = int.Parse(Console.ReadLine());

switch (opcãogeral)
{
    case 1:
        Console.WriteLine("Atividade em sala");

        //Atividade em sala

        int a, tempo;
        int soma = 0;
        a = 0;
        while (a < 3)
        {
            Console.WriteLine("digite um valor: ");
            tempo = int.Parse(Console.ReadLine());
            if (tempo < 0)
            {
                break;
            }
            soma = soma + tempo;
            a++;
        }
        Console.WriteLine("a medida é: {0}", soma / 3);
        break;

    case 2:
        Console.WriteLine("Exercicio 1");

        //Exercicio 1

        int n, m;

        Console.WriteLine("digite um número inteiro aleatório: ");
        m = int.Parse(Console.ReadLine());
        n = 1;
        while (n <= m)
        {
            Console.WriteLine("{0}", n);
            n++;
        }
        break;

    case 3:
        Console.WriteLine("Exercico 2");

        //Exercicio 2

        int a2, n1;

        Console.WriteLine("Escreva um número inteiro aleatório: ");
        n1 = int.Parse(Console.ReadLine());
        a2 = 0;
        while (a2 <= n1)
        {
            if (a2 % 2 == 0)
            {
                Console.WriteLine(a2);
            }
            a2++;
        }
        break;

    case 4:
        Console.WriteLine("Exercicio 3");

        //Exercico 3

        int div = 1000;

        Console.WriteLine("Escreva um úmero interiro menor que 1000");
        int mil = int.Parse(Console.ReadLine());

        if (mil < 1000)
        {
            while (div >= mil)
            {
                if ((div % 2) == 0)
                {
                    Console.WriteLine(div);
                }
                div--;
            }
        }
        else
        {
            Console.WriteLine("OPÇÃO INVÁLIDA");
        }
        break;

    case 5:
        Console.WriteLine("Exercicio 4");

        //Exercicio 4

        int somaPositivos = 0;

        while (somaPositivos < 200)
        {
            Console.Write("Digite um número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n2 > 0)
            {
                Console.WriteLine("Número positivo: " + n2);
                somaPositivos += n2;
            }
        }
        Console.WriteLine("Soma dos números positivos atingiu ou ultrapassou 200.");
        Console.WriteLine("Programa encerrado.");
        break;

    case 6:
        Console.WriteLine("Exercicio 5");

        //Exercicio 5

        int numero;
        Console.Write("Digite um número inteiro positivo: ");
        numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Divisores de {0}:", numero);

        int i = 1;
        while (i <= numero)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
        break;

    case 7:
        Console.WriteLine("Exercicio 6");

        //Exercicio 6

        int quantidadeNumeros = 10;
        int maiorNumero = int.MinValue;
        int menorNumero = int.MaxValue;

        int j = 1;
        while (j <= quantidadeNumeros)
        {
            Console.Write("Digite o número " + j + ": ");
            int n3 = int.Parse(Console.ReadLine());

            if (n3 > maiorNumero)
            {
                maiorNumero = n3;
            }

            if (n3 < menorNumero)
            {
                menorNumero = n3;
            }
            j++;
        }

        Console.WriteLine("O maior número digitado foi: " + maiorNumero);
        Console.WriteLine("O menor número digitado foi: " + menorNumero);
        break;

    case 8:
        Console.WriteLine("Exercicio 7");

        //Exercicio 7

        int somaPares = 0;
        int somaImpares = 0;

        while (true)
        {
            Console.Write("Digite um número (ou zero para sair): ");
            int n4 = int.Parse(Console.ReadLine());

            if (n4 == 0)
            {
                break;
            }

            if (n4 % 2 == 0)
            {
                somaPares += n4;
            }
            else
            {
                somaImpares += n4;
            }
        }

        Console.WriteLine("Soma dos números pares: " + somaPares);
        Console.WriteLine("Soma dos números ímpares: " + somaImpares);

        break;

    default:
        Console.WriteLine("opção inválida");
        break;
}
      