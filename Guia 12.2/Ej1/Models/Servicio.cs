using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models
{

    internal class Servicio
    {
        #region declarar var
        public string[] nombres = new string[100];
        public int[] tiempoH = new int[100];
        public int[] tiempoM = new int[100];
        public int contadr = 0;
        #endregion

        public void RegistrarNombre(string nombre)
        {
            nombres[contadr] = nombre;
            contadr++;
        }
        public void RegistrarTiempor(int hora, int minuto,int i )
        {
                tiempoH[i] = hora;
                tiempoM[i] = minuto;
        }
       public void ordenar()
        {
            for (int piv1=0;piv1 < contadr-1;piv1++)
            {
                for ( int piv2 = piv1+1; piv2<contadr;piv2++)
                {
                    if (tiempoH[piv1] > tiempoH[piv2] || tiempoH[piv1] == tiempoH[piv2] && tiempoM[piv1] > tiempoM[piv2])
                    {
                        intercambio(piv1, piv2);
                    }
                 

                }
            }
        }

        void intercambio(int piv1, int piv2)
        {
            #region ordenar Hora
            int aux1 = tiempoH[piv2];
            tiempoH[piv2] = tiempoH[piv1];
            tiempoH[piv1] = aux1;
            #endregion

            #region ordenar minutos
            int aux2 = tiempoM[piv2];
            tiempoM[piv2] = tiempoM[piv1];
            tiempoM[piv1] = aux2;

            #endregion

            #region ordenar nombre
            string aux3 = nombres[piv2];
            nombres[piv2] = nombres[piv1];
            nombres[piv1] = aux3;
            #endregion
        }
        

    }
}
