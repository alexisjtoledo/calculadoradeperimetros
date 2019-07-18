using System;

namespace CalculadoraDePerimetros
{
    class Program
    {
        static void Main(string[] args)
        {
        
         /* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
          * Aplicación para calcular el perímetro de figuras geométricas. *
          * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

            // Designación de variables. //
            int menu;
            double lado1 = 0;
            double lado2 = 0;
            double lado3 = 0;
            double lado4 = 0;
            double resultado = 0;
            bool repeat = true;

            // Saludo y presentación. //
            Console.WriteLine("¡Bienvenido! Presiona una tecla para continuar.");
            Console.ReadKey();
            Console.WriteLine("");

            do
            {
                // Comienza la ejecución del programa. //
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("");
                Console.WriteLine("¿De qué figura quieres calcular el perímetro?");
                Console.WriteLine("TRIÁNGULO --> Presione 1");
                Console.WriteLine("CUADRADO/ROMBO --> Presione 2");
                Console.WriteLine("RECTÁNGULO/ROMBOIDE --> Presione 3");
                Console.WriteLine("CÍRCULO --> Presione 4");
                Console.WriteLine("TRAPECIO --> Presione 5");
                Console.WriteLine("PENTÁGONO --> Presione 6");
                Console.WriteLine("");
                Console.WriteLine("__________________________________________________");

                // Valido el dato ingresado. //
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out menu))
                {
                    menu = Convert.ToInt32(input);


                    // Solicito al usuario una opción. //
                    switch (menu)
                    {
                        // Calculandora de triangulos. //
                        case 1:
                            {
                                // Obtención de datos. //
                                Console.WriteLine("CALCULADORA DE PERIMETROS: TRIÁNGULO");
                                Console.WriteLine("Por favor ingrese la medida del primer lado.");
                                lado1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("A continuación ingrese la medida del segundo lado.");
                                lado2 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Por último, ingrese la medida del tercer lado.");
                                lado3 = Convert.ToDouble(Console.ReadLine());

                                // Cálculo. //
                                resultado = lado1 + lado2 + lado3;

                                // Muestra de resultados. //
                                Console.WriteLine("__________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("El perímetro de su triángulo es de " + resultado);
                            }
                            break;

                        // Calculandora de cuadrados y rombos. //
                        case 2:
                            {
                                // Obtención de datos. //
                                Console.WriteLine("CALCULADORA DE PERIMETROS: CUADRADO/ROMBO");
                                Console.WriteLine("Por favor ingrese la medida de uno de los lados.");
                                lado1 = Convert.ToDouble(Console.ReadLine());

                                // Cálculo. //
                                resultado = lado1 * 4;

                                // Muestra de resultados. //
                                Console.WriteLine("__________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("El perímetro de su cuadrado/rombo es de " + resultado);
                            }
                            break;

                        // Calculandora de rectángulos y romboides. //
                        case 3:
                            {
                                // Obtención de datos. //
                                Console.WriteLine("CALCULADORA DE PERIMETROS: RECTÁNGULO/ROMBOIDE");
                                Console.WriteLine("Por favor ingrese la medida de la base.");
                                lado1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("A continuación ingrese la medida de la altura.");
                                lado2 = Convert.ToDouble(Console.ReadLine());

                                // Cálculo. //
                                resultado = (2 * lado1) + (2 * lado2);

                                // Muestra de resultados. //
                                Console.WriteLine("__________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("El perímetro de su rectángulo/romboide es de " + resultado);
                            }
                            break;

                        // Calculandora de círculos. //
                        case 4:
                            {
                                // Obtención de datos. //
                                Console.WriteLine("CALCULADORA DE PERIMETROS: CÍRCULO");
                                Console.WriteLine("Por favor ingrese la medida del diámetro.");
                                lado1 = Convert.ToDouble(Console.ReadLine());

                                // Cálculo. //
                                resultado = Math.PI * (lado1);

                                // Muestra de resultados. //
                                Console.WriteLine("__________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("El perímetro de su círculo es de " + resultado);
                            }
                            break;

                        // Calculandora de Trapecios. //
                        case 5:
                            {
                                // Obtención de datos. //
                                Console.WriteLine("CALCULADORA DE PERIMETROS: TRAPECIO");
                                Console.WriteLine("Por favor ingrese la medida del primer lado.");
                                lado1 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Por favor ingrese la medida del segundo lado.");
                                lado2 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Por favor ingrese la medida del tercer lado.");
                                lado3 = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("Por favor ingrese la medida del cuarto lado.");
                                lado4 = Convert.ToDouble(Console.ReadLine());

                                // Cálculo. //
                                resultado = lado1 + lado2 + lado3 + lado4;

                                // Muestra de resultados. //
                                Console.WriteLine("__________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("El perímetro de su trapecio es de " + resultado);
                            }
                            break;

                        // Calculandora de Pentágonos. //
                        case 6:
                            {
                                // Obtención de datos. //
                                Console.WriteLine("CALCULADORA DE PERIMETROS: PENTÁGONO");
                                Console.WriteLine("Por favor ingrese la medida de uno de sus lados.");
                                lado1 = Convert.ToDouble(Console.ReadLine());

                                // Cálculo. //
                                resultado = lado1 * 5;

                                // Muestra de resultados. //
                                Console.WriteLine("__________________________________________________");
                                Console.WriteLine("");
                                Console.WriteLine("El perímetro de su Pentágono es de " + resultado);
                            }
                            break;

                        // Caso de error. //
                        default:
                            {
                                Console.WriteLine("El número debe ser del 1 al 6.");
                            }
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Debe ingresar un número.");

                }

            }

            while (repeat);

        }
    }
}
