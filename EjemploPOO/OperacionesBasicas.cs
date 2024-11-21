namespace EjemploPOO
{
    internal class OperacionesBasicas
    {
        public int Sumar(int primerNumero, int segundoNumero)
        {
            return primerNumero + segundoNumero;

        }

        public int Restar(int primerNumero, int segundoNumero)
        {
            return (primerNumero - segundoNumero);
        }

        public int Multiplicar(int primerNumero, int segundoNumero)
        {
            return primerNumero * segundoNumero;
        }

        public decimal Division(int primer, int segundoNumero)
        {
            return primer / segundoNumero;
        }
    }
}
