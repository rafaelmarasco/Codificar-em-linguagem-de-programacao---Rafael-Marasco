using System;

namespace Lista_de_vetores

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //um();
            //dois();
            //tres();
            //quatro();
            //cinco();
            //seis();
            //sete();
            //oito();
            //nove();
            //dez();
            //onze();
            //doze();
            //treze();
            //quatorze();
            //quinze();
            //dezesseis();
            //dezessete();
            //dezoito();
            //dezenove();
            //vinte();
            //vinteEum();
            //vinteEdois();
            //vinteEtres();
            //vinteEquatro();
            //vinteEcinco();
            //vinteEseis();
            //vinteEsete();
            //vinteEoito();
            //vinteEnove();
            //trinta();
            //trinteEum();
            //trintaEdois(); // PQP ESSA FOI DE FUDER EM
            //trintaEtres();
            //trintaEquatro();
            //trintaEcinco();
            //trintaEseis();
            //trintaEsete();
            //trintaEoito();
            //trintaEnove();
            //quarenta();
            //quarentaEum();
            //quarentaEdois();
            //quarentaEtres(); //Num sei se ta certo, mas foi oque eu entendi
            //quarentaEquatro();
            //quarentaEcinco();
            //quarentaEseis(); // Nem sei como que isso ta funcionando...
            //quarentaEsete();
            //quarentaEoito();
            //quarentaEnove();
            vamoLa();



        }

        static void um()
        {
            int[] num = { 1, 2, 3, 4, 5 };

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }

        static void dois()
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"O #{i + 1} numero é: " + num[i]);
            }
        }

        static void tres()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n" + num[0]);
        }

        static void quatro()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n" + num[9]);
        }

        static void cinco()
        {
            int[] num = new int[8];

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Ordem invertida do que você digitou: ");

            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i] + " ");
            }
        }

        static void seis()
        {
            int[] num = new int[6];
            int soma = 0;

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
                soma += num[i];
            }

            Console.Write("Resultado: " + soma);

        }

        static void sete()
        {
            int[] num = new int[10];
            int soma = 0;

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());

                soma += num[i];
            }

            Console.WriteLine($"A média do valores digitados é: {soma / num.Length}");

        }

        static void oito()
        {
            int[] num = new int[7];

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"Você digitou: {num.Length} números");
        }

        static void nove()
        {
            int[] num = new int[5];

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Posição {i}: {num[i]}");
            }
        }

        static void dez()
        {
            int[] num = new int[10];

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i != num.Length; i++)
            {
                if ((num[i] % 2) == 0)
                {
                    Console.WriteLine($"O numero {num[i]}, na posição: {i + 1} é par");
                }
            }
        }

        static void onze()
        {
            int[] num = new int[10];

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i != num.Length; i++)
            {
                if ((num[i] % 2) == 1)
                {
                    Console.WriteLine($"O numero {num[i]}, na posição: {i + 1} é impar");
                }
            }
        }

        static void doze()
        {
            int[] num = new int[10];
            int soma = 0;

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
                if ((num[i] % 2) == 0)
                {
                    soma++;
                }
            }

            Console.WriteLine($"\nVoce digitou {soma} números pares");

        }

        static void treze()
        {
            int[] num = new int[10];
            int soma = 0;

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
                if ((num[i] % 2) == 1)
                {
                    soma++;
                }
            }

            Console.WriteLine($"\nVoce digitou {soma} números impares");
        }

        static void quatorze()
        {
            int[] num = new int[10];
            int soma = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] > 50)
                {
                    soma++;
                }
            }
            Console.WriteLine($"Você digitou: {soma} números maiores que 50!");
        }

        static void quinze()
        {
            int[] num = new int[10];
            int soma = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] < 0)
                {
                    soma++;
                }
            }
            Console.WriteLine($"\nVocê digitou: {soma} números negativos");
        }

        static void dezesseis()
        {
            int[] n = new int[10];
            int maior = 0;

            for (int i = 0; i <= n.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número: ");
                n[i] = int.Parse(Console.ReadLine());
                if (n[i] > maior)
                {
                    maior = n[i];
                }
            }

            Console.WriteLine("O maior valor digitado foi: " + maior);

        }

        static void dezessete()
        {
            int[] n = new int[10];
            int menor = 0;

            for (int i = 0; i <= n.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número: ");
                n[i] = int.Parse(Console.ReadLine());
                if (n[i] < menor)
                {
                    menor = n[i];
                }
            }

            Console.WriteLine("O menor valor digitado foi: " + menor);
        }

        static void dezoito()
        {
            int[] n = new int[10];
            int maior = 0, maiorPos = 0;

            for (int i = 0; i <= n.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número: ");
                n[i] = int.Parse(Console.ReadLine());
                if (n[i] > maior)
                {
                    maior = n[i];
                    maiorPos = i;
                }
            }

            Console.WriteLine($"O maior valor digitado foi: {maior} na posição {maiorPos + 1}");
        }

        static void dezenove()
        {
            int[] n = new int[10];
            int menor = 0, menorPos = 0;

            for (int i = 0; i <= n.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número: ");
                n[i] = int.Parse(Console.ReadLine());
                if (n[i] < menor)
                {
                    menor = n[i];
                    menorPos = i;
                }
            }

            Console.WriteLine($"O maior valor digitado foi: {menor} na posição {menorPos + 1}");
        }

        static void vinte()
        {
            int[] num = new int[10];
            bool temCem = false;

            for (int i = 0; i != num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número.");
                num[i] = int.Parse(Console.ReadLine());
                if (num[i] == 100 && !temCem)
                {
                    temCem = true;
                }

            }

            if (temCem)
            {
                Console.WriteLine("Tem pelo menos um número 100 no seu vetor!");
            }
            else
            {
                Console.WriteLine("Não tem nenhum número 100 no seu vetor...");
            }

        }

        static void vinteEum()
        {
            int[] num = new int[10];
            int pesquisa = 0;
            bool existe = false;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número: ");
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("Agora digite mais um número: ");
            pesquisa = int.Parse(Console.ReadLine());

            foreach (int i in num)
            {
                if (num[i] == pesquisa)
                {
                    existe = true;
                }
            }

            if (existe)
            {
                Console.WriteLine("Esse numero está no vetor");
            }
            else
            {
                Console.WriteLine("Esse numero não está no vetor");
            }

        }

        static void vinteEdois()
        {
            int[] num = new int[10];
            int pesquisa = 0;
            bool existe = false;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número: ");
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nAgora digite mais um número: ");
            pesquisa = int.Parse(Console.ReadLine());
            Console.WriteLine("\nVamos ver em que posiçoes esse número aparece no vetor: ");

            for (int i = 0; i <= num.Length - 1; i++)
            {
                if (num[i] == pesquisa && !existe)
                {
                    Console.Write("Esse numero aparece no vetor nas posições: ");
                    Console.Write($"{i + 1} , ");
                    existe = true;
                }
                else if (num[i] == pesquisa && existe)
                {
                    Console.Write($"{i + 1} ");
                }
            }

            if (!existe)
            {
                Console.WriteLine("Esse numero não está no vetor... ");
            }

            Console.WriteLine();

        }

        static void vinteEtres()
        {
            int[] num = new int[15];
            int pesquisa = 0, soma = 0;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} número: ");
                num[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nAgora digite mais um número: ");
            pesquisa = int.Parse(Console.ReadLine());
            Console.WriteLine("\nVamos ver quantas vezes esse número aparece no vetor: ");

            for (int i = 0; i <= num.Length - 1; i++)
            {
                if (num[i] == pesquisa)
                {
                    soma++;
                }
            }

            if (soma == 1)
            {
                Console.WriteLine($"O numero {pesquisa} aparece {soma} vez no vetor");
            }
            else
            {
                Console.WriteLine($"O numero {pesquisa} aparece {soma} vezes no vetor");
            }
            Console.WriteLine();

        }

        static void vinteEquatro()
        {
            int[] num = new int[10];
            bool diferente = false;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());

            }

            int ante = num[0];

            for (int i = 0; i <= num.Length - 1; i++)
            {
                if (ante != num[i])
                {
                    diferente = true;
                    break;
                }
                else
                {
                    ante = num[i];
                }
            }

            Console.WriteLine();

            if (diferente)
            {
                Console.WriteLine("Existem diferentes numeros no vetor!");
            }
            else
            {
                Console.WriteLine("Todos os valores do vetor são iguais");
            }

            Console.WriteLine();

        }

        static void vinteEcinco()
        {
            int[] num = new int[10];
            bool repetido = false;

            for (int i = 0; i <= num.Length - 1; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());

            }



            for (int i = 0; i <= num.Length - 1; i++)
            {
                for (int j = i + 1; j <= num.Length - 1; j++)
                {
                    if (num[i] == num[j])
                    {
                        repetido = true;
                        break;
                    }
                }

            }

            Console.WriteLine();

            if (repetido)
            {
                Console.WriteLine("Existem numeros iguais no vetor!");
            }
            else
            {
                Console.WriteLine("Não existem valores iguais no vetor");
            }

            Console.WriteLine();
        }

        static void vinteEseis()
        {
            int[] num = new int[10];
            float soma = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} nuemro: ");
                num[i] = int.Parse(Console.ReadLine());
                soma += num[i];

            }

            float media = soma / num.Length;

            Console.WriteLine("\n" + media + "\n");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > media)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }

        static void vinteEsete()
        {
            int[] num = new int[10];
            float soma = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} nuemro: ");
                num[i] = int.Parse(Console.ReadLine());
                soma += num[i];

            }

            float media = soma / num.Length;

            Console.WriteLine("\n" + media + "\n");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < media)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }

        static void vinteEoito()
        {
            int[] num = new int[10];
            int maior = 0, menor = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());

                if (num[i] > maior)
                {
                    maior = num[i];
                }
                if (num[i] < menor)
                {
                    menor = num[i];
                }
            }

            Console.WriteLine($"\nA diferença entre o maior numero ({maior}) e o menor ({menor}) é: {maior - menor}");
            Console.WriteLine();

        }

        static void vinteEnove()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 5 == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
            Console.WriteLine();
        }

        static void trinta()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
            Console.WriteLine();
        }

        static void trintaEum()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            int[] numCop = new int[10];

            Console.WriteLine($"\nO array criado foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                numCop[i] = num[i];
                Console.Write($"{num[i]} ");
            }

            Console.WriteLine($"\nO array criado a partir dele foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{numCop[i]} ");

            }
        }

        static void trintaEdois()
        {
            int[] num = new int[10];
            int tam = 0, posAnterior = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (num[i] % 2 == 0)
                {
                    tam++;
                }
            }

            int[] numCop = new int[tam];

            Console.WriteLine($"\nO array criado foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

            for (int i = 0; i < numCop.Length; i++)
            {
                for (int j = posAnterior; j < num.Length; j++)
                {
                    if (num[j] % 2 == 0)
                    {
                        numCop[i] = num[j];
                        posAnterior = j + 1;
                        break;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine($"\nO array criado a partir dele foi: \n");

            for (int i = 0; i < numCop.Length; i++)
            {
                Console.Write($"{numCop[i]} ");
            }

            Console.WriteLine();


        }

        static void trintaEtres()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine($"\nO array criado foi: \n");


            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

            Console.WriteLine($"\nO array criado a partir dele foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i] * 2} ");

            }
            Console.WriteLine();
        }

        static void trintaEquatro()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine($"\nO array criado foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

            Console.WriteLine($"\nO array criado a partir dele foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= 0)
                {
                    Console.Write($"{num[i]} ");
                }
                else
                {
                    Console.Write($"{0} ");
                }
            }
        }

        static void trintaEcinco()
        {
            int[] num = new int[4];
            int container;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine($"\nO array criado foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

            Console.WriteLine($"\nO array criado a partir dele foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(num[num.Length - 1] + " ");
                }
                else if (i == num.Length - 1)
                {
                    Console.Write(num[0] + " ");
                }
                else
                {
                    Console.Write($"{num[i]} ");
                }
            }

            Console.WriteLine();
        }

        static void trintaEseis()
        {
            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine($"\nO array criado foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

            Console.WriteLine($"\nO array criado a partir dele foi: \n");

            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write($"{num[i]} ");
            }

        }

        static void trintaEsete()
        {
            int[] num = new int[10];
            int[] numQuad = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                numQuad[i] = num[i] * num[i];
            }

            Console.WriteLine($"\nO array criado foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

            Console.WriteLine($"\nO array criado a partir dele foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{numQuad[i]} ");
            }

            Console.WriteLine();
        }

        static void trintaEoito()
        {
            int[] num = new int[10];
            int[] numDob = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                numDob[i] = num[i] * 2;
            }

            Console.WriteLine($"\nO array criado foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }

            Console.WriteLine($"\nO array criado a partir dele foi: \n");

            for (int i = 0; i < numDob.Length; i++)
            {
                Console.Write($"{numDob[i]} ");
            }

            Console.WriteLine();
        }

        static void trintaEnove()
        {
            int[] num = new int[10];
            int[] num2 = new int[10];
            int[] numSoma = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Agora vamos criar mais um array\n");

            for (int i = 0; i < num2.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num2[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                numSoma[i] = num[i] + num2[i];
            }

            Console.WriteLine("\nOs arrays criados foram: ");
            Console.WriteLine("O primeiro: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nO segundo: \n");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num2[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nO array criado a partir deles foi: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{numSoma[i]} ");
            }

            Console.WriteLine();

        }

        static void quarenta()
        {
            int[] num = new int[10];
            int[] num2 = new int[10];
            int[] numMult = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Agora vamos criar mais um array\n");

            for (int i = 0; i < num2.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num2[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                numMult[i] = num[i] * num2[i];
            }

            Console.WriteLine("\nOs arrays criados foram: ");
            Console.WriteLine("O primeiro: \n");

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("\nO segundo: \n");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num2[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nO array criado a partir deles foi: \n");

            for (int i = 0; i < numMult.Length; i++)
            {
                Console.Write($"{numMult[i]} ");
            }

            Console.WriteLine();

        }

        static void quarentaEum()
        {
            int[] num = new int[20];
            int temp = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Escreva o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            } //

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }


        }
        static void quarentaEdois()
        {
            int[] num = new int[20];
            int temp = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Escreva o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            } //

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }


        }

        static void quarentaEtres()
        {
            int[] num = new int[10];
            int temp = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Escreva o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]} ");
            } //

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        num[j] = 0;
                    }
                }
            }

            Console.WriteLine("\n");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }


        }

        static void quarentaEquatro()
        {
            int[] num = new int[15];
            int reptCont = 0, contAnterior = 0, maisRept = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Array criado: ");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < num.Length; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] == num[j])
                    {
                        reptCont++;
                    }
                    if (contAnterior < reptCont)
                    {
                        contAnterior = reptCont;
                        maisRept = num[i];
                    }
                }
                reptCont = 0;
            }

            Console.WriteLine($"O numero mais repetido foi {maisRept} e ele se repetiu {contAnterior + 1} vezes");
        }

        static void quarentaEcinco()
        {
            int[] num = new int[10];
            int temp = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Array criado: ");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            int maior = num[0];
            int segMaior = num[1];

            Console.WriteLine();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > maior)
                {
                    segMaior = maior;
                    maior = num[i];

                }
                if (num[i] > segMaior && num[i] < maior)
                {
                    segMaior = num[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine($"O segundo maior numero detectado foi: {segMaior} ");
        }
        static void quarentaEseis()
        {
            int[] num = new int[5];
            int temp = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("Array criado: ");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            int menor = num[0];
            int segMenor = num[num.Length - 1];

            Console.WriteLine();

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < menor)
                {
                    segMenor = menor;
                    menor = num[i];

                }
                if (num[i] < segMenor && num[i] > menor)
                {
                    segMenor = num[i];
                }
            }

            Console.WriteLine();

            Console.WriteLine($"O segundo menor numero detectado foi: {segMenor} ");
        }

        static void quarentaEsete()
        {
            int[] num = new int[20];
            int impCont = 0, parCont = 0, pos = 0;

            for (int i = 0; i < num.Length; i++) // Loop que recebe os numeros do usuario
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (num[i] % 2 == 0) // Todo numero recebido aumenta o contador de numeros pares e impares
                {
                    parCont++;
                }
                else
                {
                    impCont++;
                }
            }

            int[] par = new int[parCont], impar = new int[impCont]; // cria os vetores baseado na quantidade de numeros que ele precisara ter

            Console.WriteLine("O array criado foi: ");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

            for (int i = 0; i < par.Length; i++) // loop para preencher os numeros pares
            {
                for (int j = pos; j < num.Length; j++) // percorre o vetor principal, sempre mantendo a posicao anterior para nao repetir o mesmo valor, mas ainda permitir valores iguais no vetor
                {

                    if (num[j] % 2 == 0)
                    {
                        pos = j + 1;
                        par[i] = num[j];
                        break;
                    }
                }
            }

            pos = 0; // reseta a posicao para nao ocorrer erros

            for (int i = 0; i < impar.Length; i++) // mesma coisa do vetor par 
            {
                for (int j = pos; j < num.Length; j++)
                {

                    if (num[j] % 2 != 0)
                    {
                        //Console.WriteLine("test");
                        pos = j + 1;
                        impar[i] = num[j];
                        break;
                    }
                }
            }

            Console.WriteLine("O array de numeros pares criado foi: ");

            foreach (int i in par)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
            Console.WriteLine("O array de numeros pares criado foi: ");

            foreach (int i in impar)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

        static void quarentaEoito()
        {
            int[] num = new int[10];
            bool crescente = true;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("O array criado foi: ");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < num.Length; i++)
            {
                if (crescente)
                {
                    for (int j = i + 1; j < num.Length; j++)
                    {
                        if (num[i] > num[j])
                        {
                            crescente = false;
                            break;
                        }
                    }
                }
                else
                {
                    break;
                }
            }

            if (crescente)
            {
                Console.WriteLine("O sistema detectou que o array esta em ordem crescente!");
            }
            else
            {
                Console.WriteLine("O sistema detectou que o array nao esta em ordem crescente!");
            }
        }

        static void quarentaEnove()
        {
            int[] num = new int[10];
            int temp = 0;

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            int ultimoNum = num.Length - 1;

            Console.WriteLine("O array criado foi: ");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n");

            for (int i = ultimoNum; i >= 0 ; i--) // loop que percorre o array de tras para frente
            {
                if (i == ultimoNum) // passo 1 - no primeiro loop ele guarda a informaçao de quem é o ultimo numero do array
                {
                    temp = num[ultimoNum];
                }

                if (i == 0) // passo 2 - checa se ja esta ou nao no primeiro (ou ultimo) indice do array, se estive ele substitui o primeiro numero
                            // com o ultimo (que havia sido salvo no primeiro passo)
                {
                    num[i] = temp;
                    break;
                }

                num[i] = num[i - 1]; // passo 3 - substitui o valor atual pelo valor do correspondente ao indice anterior
            }

            Console.WriteLine("O array criado apartir dele foi: ");

            foreach (int i in num)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

        }

        static void vamoLa()
        {
            int[] num = new int[10], somaPos = new int[10];
            int pos = 0, neg = 0, somaI = 0, maiorSoma = 0;
            bool facil = false;

            for(int i = 0; i < num.Length; i++)
            {
                Console.Write($"Digite o #{i + 1} numero: ");
                num[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                somaI += num[i];
                
            }

            int soma = num[0];

            for(int i = 0; i < num.Length - 1; i++)
            {
                if (soma + num[i + 1] > maiorSoma)
                {
                    soma += num[i];
                    somaPos = i;
                }
                else
                {

                }
            }
        }
    }
}