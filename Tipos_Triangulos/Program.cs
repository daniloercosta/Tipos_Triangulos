using System;

namespace Triagulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] triangulo = Console.ReadLine().Split(' ');
            float n1, n2, n3, A, B, C;
            n1 = float.Parse(triangulo[0]);
            n2 = float.Parse(triangulo[1]);
            n3 = float.Parse(triangulo[2]);

            if (n1 > n2 && n1 > n3)
            {
                // "A" tem de ser o maior lador, neste caso o "if" e "else" entra para decidir qual sera o valor atribuido B ou C
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }

                else
                {
                    B = n3;
                    C = n2;
                }

            }

            else if (n2 > n3)
            {
                A = n2;
                if (n1 > n3)
                {
                    B = n1;
                    C = n3;
                }

                else
                {
                    B = n3;
                    C = n1;
                }
            }

            else
            {
                A = n3;
                if (n1 > n2)
                {
                    B = n1;
                    C = n2;
                }

                else
                {
                    B = n2;
                    C = n1;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }

            else
            {
                // Teste de 3 possibilidades referente ao angulo
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }

                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }

                else
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                // Teste equilatero ou isoceles
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }

                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}