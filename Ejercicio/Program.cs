using System;
using System.Linq;
namespace Ejercicio {
    class Program {
   
        static void Main(string[] args) {
            RandomNumber a = new RandomNumber();
            string generado = a.GenerateRandomNumber();

  //            Console.WriteLine(generado);

            int aciertos = 0;
            int reguar = 0;

//mientras no gane seguir preguntando
            while (aciertos != 4) {
                Console.WriteLine("adivinar numero");
                string numeroIntentodeAdivinar;

 //Limitar a solo 4 digitos
                while (true) {
                    numeroIntentodeAdivinar = Console.ReadLine();
                    if (numeroIntentodeAdivinar.Length != 4) {
                        Console.WriteLine("ingrese numero de 4 digitos");
                    }
                    else break;
                }

//Calcular aciertos
                for (int i = 0; i < generado.Length; i++) {
                    if (generado[i] == numeroIntentodeAdivinar[i]) {
                        aciertos++;
                    }
                }

//Calcular regulares
                for (int j = 0; j < generado.Length; j++) {

                    if (generado.Contains(numeroIntentodeAdivinar[j])) {
                        reguar++;
                    }
                }
                reguar = reguar - aciertos;

//Mostrar en pantalla
                Console.WriteLine($"aciertos '{aciertos}' regular {reguar} ");
                if (aciertos == 4) {
                    Console.WriteLine("WIN");
                    Console.Read();
                }
 //Reset           
                else { aciertos = 0; reguar = 0; }

            }

        }

    }
}