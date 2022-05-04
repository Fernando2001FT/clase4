namespace EjerciciosISP.Ejercicio2
{
    public interface ICafeteria
    {
        void HacerCafePasado();
        //void HacerDesayuno();
        //void HacerCapuchino();
    }
    public interface ICafeteriaTradicional
    {
        void HacerCapuchino();
    }

    public interface IRestaurante
    {
        void HacerDesayuno();
    }
}