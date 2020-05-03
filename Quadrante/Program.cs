using System;
using System.Globalization;

namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x, y;
                do
                {
                    Console.Write("Digite os valores para os eixos X e Y separados por espaço: ");
                    string[] entrada = Console.ReadLine().Split(' ');

                    x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                    y = double.Parse(entrada[1], CultureInfo.InvariantCulture);

                    if (x == 0 && y == 0)
                        Console.WriteLine("Origem");
                    else if (x == 0)
                        Console.WriteLine("Eixo X");
                    else if (y == 0)
                        Console.WriteLine("Eixo Y");
                    else if (x > 0 && y > 0)
                        Console.WriteLine("Coordenada pertencente ao primeiro quadrante");
                    else if (x < 0 && y > 0)
                        Console.WriteLine("Coordenada pertencente ao segundo quadrante");
                    else if (x < 0 && y < 0)
                        Console.WriteLine("Coordenada pertencente ao terceiro quadrante");
                    else if (x > 0 && y < 0)
                        Console.WriteLine("Coordenada pertencente ao quarto quadrante");
                    else
                        Console.WriteLine("A coordenada encontra-se em um ou nos dois eixos X e Y");
                } while (x != 0 & y != 0);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Erro de formatação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
