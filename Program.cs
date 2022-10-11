using System;

namespace ejerc_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float pesos=0f, monedaExtranjera=0f;
            string moneda="";
            string salir="";

            Console.WriteLine("CONVERTIDOR DE MONEDAS:");
             Console.ReadKey();

            while ((salir !="q") && (salir !="Q")){

                Console.Clear();    
                Console.WriteLine("Ingrese Moneda");
                Console.WriteLine("E: Euro");
                Console.WriteLine("D: Dolar");
                Console.WriteLine("Q: Salir");
                salir=Console.ReadLine();
                moneda=salir;
            
            
                if(moneda == "e" || moneda == "E"){
                Console.WriteLine("Ingrese cantidad de Euros: ");
                monedaExtranjera=Convert.ToInt32(Console.ReadLine());
                pesos=monedaExtranjera/270; // 1 euro 270$
                Console.WriteLine("Ingreso: " + monedaExtranjera + " Euros, son $ " + pesos );
                Console.ReadKey();

                }
          
                
                if(moneda=="d" || moneda=="D"){
                Console.WriteLine("Ingrese cantidad de Dolar:");
                monedaExtranjera=Convert.ToInt32(Console.ReadLine());
                pesos=monedaExtranjera/300; // 1 dolar 300$
                Console.WriteLine("Ingreso: " + monedaExtranjera + " Dolares, son $ " + pesos );
                Console.ReadKey();
                }

                                
                if(moneda!="d" && moneda!="D" && moneda!="e" && moneda!="E" && moneda!="q" && moneda!="Q"){

                     Console.WriteLine("Debe ingresar una opcion valida valida...");
                     Console.ReadKey();
                     Console.Clear();
                    
                   
                }
                
                               

            }
            
            Console.Clear();
            Console.WriteLine("Finalizo convertidor . . . ");
        }
    }
}
