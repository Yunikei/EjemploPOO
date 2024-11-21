namespace EjemploPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperacionesBasicas basicas = new OperacionesBasicas();

            int resultadoSuma = basicas.Sumar(5, 5);
            Console.WriteLine(resultadoSuma);

            int resultadoResta = basicas.Restar(18, 8);
            Console.WriteLine(resultadoResta);

        }
    }
}
