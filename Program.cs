using System;

namespace CalcAreaPOO
{
    class Program
    {
        public enum OpcoesMenu
        {
            Sair = 0,
            Quadrado = 1,
            Retangulo = 2,
            Triangulo = 3,
            Circulo = 4
        }
        static void Main(string[] args)
        {
            OpcoesMenu escolha = OpcoesMenu.Quadrado;
            while ((escolha = GetEscolha()) != OpcoesMenu.Sair)
            {
                Forma forma = null;
                switch (escolha)
                {
                    case OpcoesMenu.Quadrado:
                        forma = CriaQuadrado();
                        break;
                    case OpcoesMenu.Retangulo:
                        forma = CriaRetangulo();
                        break;
                    case OpcoesMenu.Triangulo:
                        forma = CriaTriangulo();
                        break;
                    case OpcoesMenu.Circulo:
                        forma = CriaCirculo();
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"A área do {escolha} é {forma.CalcularArea}");
                Console.WriteLine();
            }
            // Fecha o programa
            Environment.Exit(0);
        }
        public static OpcoesMenu GetEscolha()
        {
            Console.WriteLine("Escolha a figura para qual deseja calcular a Área :");
            Console.WriteLine("\t{0} - Quadrado", (int)OpcoesMenu.Quadrado);
            Console.WriteLine("\t{0} - Retângulo", (int)OpcoesMenu.Retangulo);
            Console.WriteLine("\t{0} - Triangulo", (int)OpcoesMenu.Triangulo);
            Console.WriteLine("\t{0} - Circulo", (int)OpcoesMenu.Circulo);
            Console.WriteLine("\t{0} - Sair", (int)OpcoesMenu.Sair);
            Console.WriteLine("Escolha:");
            string valor = Console.ReadLine();
            OpcoesMenu escolha;
            if (!Enum.TryParse(valor, out escolha) || !Enum.IsDefined(typeof(OpcoesMenu), escolha))
            {
                Console.WriteLine("Opção invalida, escolha uma opção valida.");
                return GetEscolha();
            }
            return escolha;
        }
        private static double GetDouble(string prompt)
        {
            bool isValido = false;
            double valor = 0;
            while (!isValido)
            {
                Console.Write(prompt);
                isValido = double.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }
        private static Quadrado CriaQuadrado()
        {
            double lado = GetDouble("Lado do Quadrado : ");
            return new Quadrado() { Lado = lado};
        }
        private static Retangulo CriaRetangulo()
        {
            double ladomaior = GetDouble("Lado Maior do Retangulo : ");
            double ladomenor = GetDouble("Lado Menor do Retangulo : ");
            return new Retangulo() 
            { 
                LadoMaior = ladomaior,
                LadoMenor = ladomenor                
            };
        }
        private static Triangulo CriaTriangulo()
        {
            double valorBase = GetDouble("Valor da base : ");
            double altura = GetDouble("Altura:");
            return new Triangulo()
            {
                Base = valorBase,
                Altura = altura
            };
        }
        private static Circulo CriaCirculo()
        {
            double raio = GetDouble("Valor do Raio do Círculo : ");
            return new Circulo() 
            {
                Raio = raio
            };
        }

    }
}
