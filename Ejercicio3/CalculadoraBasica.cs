namespace EjerciciosISP.Ejercicio3
{
    public class CalculadoraBasica : ICalculadora,IcalculadoraAvanzada
    {
        public int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public double Potencia(int num1, int num2)
        {
            throw new System.NotImplementedException();
        }

        public double RaizCuadrada(int num)
        {
            throw new System.NotImplementedException();
        }
    }
}