namespace CalculadoraApp
{
    public class Calculadora
    {
        public int Adicionar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            if (b == 0)
                throw new System.DivideByZeroException("Divisão por zero não é permitida.");
            return a / b;
        }
    }
}
