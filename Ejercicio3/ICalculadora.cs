namespace EjerciciosISP.Ejercicio3
{
    public interface ICalculadora
    {
        int Suma(int num1, int num2);
        int Resta(int num1, int num2);
        int Multiplicacion(int num1, int num2);
        int Division(int num1, int num2);
        //double Potencia(int num1, int num2);
        //double RaizCuadrada(int num);
        // NO SE REPITEN
    }
    public interface IcalculadoraAvanzada

    {
        double Potencia(int num1, int num2);
        double RaizCuadrada(int num);
}
}

