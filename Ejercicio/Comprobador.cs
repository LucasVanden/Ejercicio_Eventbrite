using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio {
    class Comprobador {
        public int comprobarResulatado(string generado, string numeroIntentodeAdivinar) {
            int aciertos = 0;
            int regular = 0;

            //Calcular aciertos
            for (int i = 0; i < generado.Length; i++) {
                if (generado[i] == numeroIntentodeAdivinar[i]) {
                    aciertos++;
                }
            }

            //Calcular regulares
            for (int j = 0; j < generado.Length; j++) {

                if (generado.Contains(numeroIntentodeAdivinar[j])) {
                    regular++;
                }
            }
            regular = regular - aciertos;

            //Mostrar en pantalla
            Console.WriteLine($"aciertos '{aciertos}' regular {regular} ");
            if (aciertos == 4) {
                Console.WriteLine("WIN");
                Console.Read();
            }
            //Reset           
            return aciertos;
        }

            
        }
    }

