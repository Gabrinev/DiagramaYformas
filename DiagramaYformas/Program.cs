using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaYformas
{
    class Program
    {
        public static Diagrama d = new Diagrama();
        static void Main(string[] args)
        {
            
            int option = menu();

            while (option != 0)
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("");
                        generarFormasAleatorias(); 
                        
                        break;
                    case 2:
                        generarForma();
                        break;
                    case 3:
                        Console.WriteLine("");
                        Console.WriteLine("Area total: "+ d.calcTotalAreas());                        
                        Console.WriteLine("Cualquier tecla para salir...");
                        Console.ReadKey();

                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Perimetro total: " + d.calcTotalPerimetros());
                        Console.WriteLine("Cualquier tecla para salir...");
                        Console.ReadKey();

                        break;
                    

                }
                option = menu();
            }


            Console.WriteLine(d.calcTotalAreas());
            Console.WriteLine(d.calcTotalPerimetros());
        }


        public static void generarFormasAleatorias()
        {
            Random rd = new Random();
            Forma temp;
            int rand_num = rd.Next(1, 10);

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    if (rand_num > 5)                    
                        temp = new Rectangulo("rojo", "rectangulo", rd.Next(50, 100), rd.Next(1, 50));
                                           
                    else                    
                        temp = new Rombo("azul", "rombo", rd.Next(50, 75), rd.Next(25, 50), rd.Next(10, 25));
                      
                }
                else 
                {
                    if (rand_num > 5)
                    {
                        temp = new Rectangulo("azul", "rectangulo", rd.Next(50, 100), rd.Next(1, 50));
                        
                    }
                    else                    
                        temp = new Rombo("azul", "rombo", rd.Next(50, 75), rd.Next(25, 50), rd.Next(10, 25));
                                            
                }                   
            }
            Console.WriteLine("Añadidas formas correctamente");
            Console.WriteLine("Cualquier tecla para salir...");
            Console.ReadKey();

        }
        public static void generarForma()
        {
            Forma temp;
            Console.WriteLine("");
            Console.WriteLine("Pulse 1 para rectangulo o 2 para rombo");
            int forma = Convert.ToInt32(Console.ReadLine());            
            if (forma == 1)
            {
                Console.WriteLine("Color deseado");
                string color = Console.ReadLine();
                Console.WriteLine("cm lado mayor del rectangulo");
                int ladoM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("cm lado menor del rectangulo");
                int lado = Convert.ToInt32(Console.ReadLine());

                d.añadirForma(temp = new Rectangulo(color, "rectangulo", ladoM, lado));
                Console.WriteLine("Añadido rectangulo correctamente");
                Console.WriteLine("Cualquier tecla para salir...");
                Console.ReadKey();
            }
            else if (forma == 2)
            {
                Console.WriteLine("Color deseado");
                string color = Console.ReadLine();
                Console.WriteLine("cm diagonal mayor del rombo");
                int diagonM = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("cm diagonal menor del rombo");
                int diagon = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("cm lado del rombo");
                int lado = Convert.ToInt32(Console.ReadLine());

                d.añadirForma(temp = new Rombo(color, "rombo", diagonM, diagon,lado));
                Console.WriteLine("Añadido rombo correctamente");
                Console.WriteLine("Cualquier tecla para salir...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No ha seleccionado ni rectangulo ni rombo");
                Console.WriteLine("Cualquier tecla para salir...");
                Console.ReadKey();
            }
        }

            static int menu()
        {
            Console.Clear();
            Console.WriteLine("DAGRAMA DE FLUJO");
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            Console.WriteLine("Pulse 1 generar 5 rectangulos y 5 rombos");
            Console.WriteLine("Pulse 2 añadir forma manualmente");
            Console.WriteLine("Pulse 3 calcular el area total");
            Console.WriteLine("Pulse 4 calcular el perimetro total");
            Console.WriteLine("Cualquier otra tecla para salir...");

            int bowl; // Variable to hold number
            ConsoleKeyInfo UserInput = Console.ReadKey(); // Get user input
            if (char.IsDigit(UserInput.KeyChar))
            {
                bowl = int.Parse(UserInput.KeyChar.ToString()); // use Parse if it's a Digit
                return bowl;
            }
            else
            {
                bowl = 0;  // Else we assign a default value
                return bowl;
            }
        }
    }
}
