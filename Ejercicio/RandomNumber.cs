using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio {
    class RandomNumber {
        Random r = new Random();
        int x = 0;
        int q = 0;
        int count = 0;
        string generado;
        public string GenerateRandomNumber() {

            while (true) {
                x = r.Next(1000, 9999);
                generado = x.ToString();
                q = 0;
                count = 0;

                for (q = 0; q < generado.Length; q++) {
                    for (int w = 0; w < generado.Length; w++) {
                        if (generado[w] == generado[q]) {
                            count++;
                        }
                    }
                }
                if (count == 4) {
                    return generado;
                }

            }
        }
    }
}
