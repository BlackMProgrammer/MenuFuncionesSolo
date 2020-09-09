using System;

namespace MenuFuncionesSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            string letras, valCelsius, valordolar, valortasa, valormetros;
            int fahr, gradCel;
            double tasa, dolar, enpeso, metros, enpies;
            do
            {
                Console.WriteLine("Seleccione la opcion que desee:");
                Console.WriteLine("A. Convertir de grados Celsius a fahrenheit");
                Console.WriteLine("B. Convertir de dolar a pesos");
                Console.WriteLine("C. Convertir de metros a pies");
                Console.WriteLine("D. Salir");
                letras = Console.ReadLine().ToLower();
                switch (letras)
                {
                    case "a":
                        Console.WriteLine("Digite la Cantidad a Convertir de grados Celsius a fahrenheit");
                        valCelsius = Console.ReadLine();
                        gradCel = Convert.ToInt32(valCelsius);
                        fahr = (gradCel * 9 / 5) + 32;
                        Console.WriteLine("Los {0} grados celsius equivalen a {1} grados fahrenheit.", gradCel, fahr);
                        break;

                    case "b":
                        Console.WriteLine("Digite la tasa del dolar");
                        valortasa = Console.ReadLine();
                        tasa = Convert.ToDouble(valortasa);
                        Console.WriteLine("Digite la cantidad de dolares a convertir");
                        valordolar = Console.ReadLine();
                        dolar = Convert.ToDouble(valordolar);
                        enpeso = dolar * tasa;
                        Console.WriteLine("{0} Dolares equivalen a {1} Pesos Dominicanos.", dolar, enpeso);
                        break;

                    case "c":
                        Console.WriteLine("Digite la cantidad de Metros que desea convertir");
                        valormetros = Console.ReadLine();
                        metros = Convert.ToDouble(valormetros);
                        enpies = metros * 3.281;
                        Console.WriteLine("{0} Metros equivalen a {1} pies.", metros, enpies);
                        break;
                    default:
                        Console.WriteLine("Por favor ingrese un valor valido");
                        break;
                }



            } while (letras != "d");



        }
    }
}
