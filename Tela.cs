using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
    public class Tela
    {
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Validação de Triângulo");
                Console.WriteLine("Digite o primeiro lado do Triângulo");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o segundo lado do Triângulo");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o terceiro lado do Triângulo");
                int c = Convert.ToInt32(Console.ReadLine());
                Triangulo triangulo = new Triangulo(a, b, c);
                Console.WriteLine(triangulo.Validar());
            } while (Recomecar());
        }

        private bool Recomecar()
        {
            Console.WriteLine("Deseja testar outro triângulo?");
            Console.WriteLine("Digite 1 para sim, qualquer outra tecla para não.");
            string ops = Console.ReadLine();
            if (ops == "1")
                return true;
            else
                return false;
        }
    }
}
