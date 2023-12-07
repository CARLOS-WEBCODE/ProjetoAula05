using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoAula05
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {


            }
            catch (ValidationException e)
            {
                Console.WriteLine("\nERRO DE VALIDAÇÃO:");
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("\nFALHA!");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
