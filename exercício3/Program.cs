
namespace exercicio3
{
    class Program
    {
        static void Main(String[] args)

        /*Fazer um programa onde o usuário irá digitar um valor até o número vinte. 
         Ou seja, a estrutura de repetição só poderá executar até 20 vezes. A estrutura 
         de repetição deve verificar os números que são ímpares, pares e múltiplos de 4. 
         Após o término da estrutura de repetição, o programa deverá exibir qual é o maior 
         valor computado entre as três questões a serem verificadas. Para isso é importante 
         que os valores ao serem identificados na estrutura de repetição, haja um somatório dos mesmos.
        */


        {
            int num, somaIm = 0, somaPar = 0, multQuat = 0;

            Console.WriteLine("Informe um número de 1 a 20");


            num = Int16.Parse(Console.ReadLine());

            while (num <= 0 || num >20 )
            {
                Console.WriteLine("Informe um numero de 1 até 20");
                num = Int16.Parse(Console.ReadLine());
            }


            for (int i = num; i < 21; i++)
            {
                if (i % 4 == 0)
                {
                    multQuat += i;
                }

                else
                {
                    if (i % 2 == 0)
                    {
                        somaPar += i;
                    }

                    else
                    {
                        somaIm += i;
                    }
                }
            }


            int totalSomaPar = somaPar + multQuat;

            Console.WriteLine();

            Console.WriteLine("Somatório dos números pares a partir do numero " + num + " é: " + totalSomaPar);

            Console.WriteLine();

            Console.WriteLine("Somatório dos números impares a partir do numero " + num + " é: " + somaIm);

            Console.WriteLine();

            Console.WriteLine("Somatório de números múltiplos de 4  a partir do numero " + num + " é: " + multQuat);

            Console.WriteLine();



            if (somaIm > totalSomaPar && somaIm > multQuat)

            {

                Console.WriteLine("O maior Somatório é dos números ímpares:  " + somaIm);

            }

            else if (totalSomaPar > somaIm && totalSomaPar > multQuat)

            {

                Console.WriteLine("O maior Somatório é dos números pares:  " + totalSomaPar);

            }

            else


            {

                Console.WriteLine("O maior Somatório é dos números múltiplos de 4:  " + multQuat);

            }

        }

    }
}




