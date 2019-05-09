using System;
using System.Linq;
namespace Ejercicio {
    class Program {
   
        static void Main(string[] args) {

//Parte 1
            RandomNumber a = new RandomNumber();
            string generado = a.GenerateRandomNumber();
            Comprobador comprobador = new Comprobador();

// en caso de querer ver el numero a adivinar
   //         Console.WriteLine(generado);



//mientras no gane seguir preguntando
            int aciertos = 0;
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
             aciertos = comprobador.comprobarResulatado(generado,numeroIntentodeAdivinar);
            }
 //Parte 2

//Leer numero
            String respuestaCorrecta;
            String test="";
            aciertos=0;
            int posicion = 0;
            String[] vec = new string[4];
            String[] vec2 = new string[4];

            while (true) {
                respuestaCorrecta = Console.ReadLine();
                if (respuestaCorrecta.Length != 4) {
                    Console.WriteLine("inserta un numero de 4 cifras distintas");
                }
                else break;
            }
//calcular cifras acertadas
            for (int c = 0; c < 10; c++) {
                test = c + "" + c + "" + c + "" + c;
                Console.WriteLine(test)
               aciertos = comprobador.comprobarResulatado(respuestaCorrecta, test);
                
                if (aciertos == 1) {
                    vec[posicion] = c.ToString();
                    posicion++;   
                }
                if (posicion==4) 
                    break;
            }
//probar combinaciones
            String testOriginal = vec[0] + "" + vec[1] + "" + vec[2] + "" + vec[3];
            Console.WriteLine(testOriginal);
            aciertos = comprobador.comprobarResulatado(respuestaCorrecta, testOriginal);

            if (aciertos==4) {
                Console.Read();
            }

//rotar mientras aciertos sean 0
            vec.CopyTo(vec2, 0);
            while (aciertos<2) {
                String temp = vec[0];
                String temp1 = vec[1];
                vec[0]= vec[3];
                vec[1]= temp;
                temp = vec[2];
                vec[2]= temp1;
                vec[3] = temp;

                test = vec[0] + "" + vec[1] + "" + vec[2] + "" + vec[3];
                Console.WriteLine(test);
                aciertos = comprobador.comprobarResulatado(respuestaCorrecta, test);
                vec.CopyTo(vec2,0) ;
            }
            if (aciertos == 2) {
//intercambio 0-1
                String temp = vec[0];
                vec[0] = vec[1];
                vec[1] = temp;
                test = vec[0] + "" + vec[1] + "" + vec[2] + "" + vec[3];
                Console.WriteLine(test);
                aciertos = comprobador.comprobarResulatado(respuestaCorrecta, test);
                if (aciertos == 0) {
                    vec2.CopyTo(vec, 0);
                    temp = vec[3];
                    vec[3] = vec[2];
                    vec[2] = temp;
                    test = vec[0] + "" + vec[1] + "" + vec[2] + "" + vec[3];
                    Console.WriteLine(test);
                    aciertos = comprobador.comprobarResulatado(respuestaCorrecta, test);
                }
//intercambio 1-2
                vec2.CopyTo(vec, 0);
                temp = vec[1];
                vec[1] = vec[2];
                vec[2] = temp;
                test = vec[0] + "" + vec[1] + "" + vec[2] + "" + vec[3];
                Console.WriteLine(test);
                aciertos = comprobador.comprobarResulatado(respuestaCorrecta, test);
                if (aciertos == 0) {
                    vec2.CopyTo(vec, 0);
                    temp = vec[0];
                    vec[0] = vec[3];
                    vec[3] = temp;
                    test = vec[0] + "" + vec[1] + "" + vec[2] + "" + vec[3];
                    Console.WriteLine(test);
                    aciertos = comprobador.comprobarResulatado(respuestaCorrecta, test);
                }
//intercambio 1-3 o 0-2
                vec2.CopyTo(vec, 0);
                temp = vec[1];
                vec[1] = vec[3];
                vec[3] = temp;
                test = vec[0] + "" + vec[1] + "" + vec[2] + "" + vec[3];
                Console.WriteLine(test);
                aciertos = comprobador.comprobarResulatado(respuestaCorrecta, test);
                if (aciertos == 0) {
                    vec2.CopyTo(vec, 0);
                    temp = vec[0];
                    vec[0] = vec[2];
                    vec[2] = temp;
                    test = vec[0] + "" + vec[1] + "" + vec[2] + "" + vec[3];
                    Console.WriteLine(test);
                    aciertos = comprobador.comprobarResulatado(respuestaCorrecta, test);
                }
            }
        }
    }
}