using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos.ConsoleApp
{
    public class Triangulo
    {
        private int a;
        private int b;
        private int c;

        public Triangulo(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        private bool EhTriangulo()
        {
            if (A + B > C && A + C > B && B + C > A)
                return true;
            else
                return false;
        }

        private string TipoTriangulo()
        {
            string msg = "";
            if (A == B && B == C)
                msg = "Equilátero";
            else if (A == B || B == C || A == C)
                msg = "Isósceles";
            else
                msg = "Escaleno";
            return msg;
        }

        public string Validar()
        {
            string validacao = "";
            if (EhTriangulo())
            {
                validacao = "É um triângulo ";
                validacao += TipoTriangulo();
                return validacao;
            }
            else
            {
                validacao = "Triângulo Inválido";
                return validacao;
            }
        }
    }
}
