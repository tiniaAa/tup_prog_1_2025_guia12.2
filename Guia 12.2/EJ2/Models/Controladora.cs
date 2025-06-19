using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EJ2.Models
{
    internal class Controladora
    {
        #region vars
        string[] Patentes = new string[1000];
        int[] tipoVehívculos = new int[1000];
        bool[] sonElectricos = new bool[1000];
        int[] modelos = new int[1000];
        public int contador { get; private set; }

        public Controladora()
        {
            contador = 0;
        }
        #endregion
        #region varsElectricos
        string[] patentesElectricos = new string[1000];
        int[] tipoVehiculosElectricos = new int[1000];
        int[] modeloElectricos = new int[100];
        public int contadorElectricos { get; private set; }
        #endregion
        #region guardar vehiculos
        public void RegistrarVehiculo(string patente, int tipo, int modelo, bool electrico)
        {

            Patentes[contador] = patente;
            tipoVehívculos[contador] = tipo;
            sonElectricos[contador] = electrico;
            modelos[contador] = modelo;
            contador++;
        }
        #endregion
        #region filtrar electricos
        public void ListarElectricos()
        {
            contadorElectricos = 0;
            for (int i = 0; i < contador; i++)
            {
                if (sonElectricos[i] == true)
                {
                    patentesElectricos[i] = Patentes[i];
                    tipoVehiculosElectricos[i] = tipoVehívculos[i];
                    modeloElectricos[i] = modelos[i];
                    contadorElectricos++;

                }
            }
            OrdenarElectricos();
        }
        #endregion
        #region ordenar
        public void OrdenarElectricos()
        {
            for (int piv1=0;piv1<contadorElectricos-1;piv1++)
            {
                for (int piv2=piv1+1;piv2<contadorElectricos;piv2++)
                {
                    if (modeloElectricos[piv1] > modeloElectricos[piv2])
                    {
                        Intercambio(piv1, piv2);

                    }
                }
            }
        }
        void Intercambio(int piv1,int piv2)
        {
            #region ordenar modelo
            int aux = modeloElectricos[piv2];
            modeloElectricos[piv2] = modeloElectricos[piv1];
            modeloElectricos[piv1] = aux;
            #endregion
            #region ordenar tipo
            int aux1 = tipoVehiculosElectricos[piv2];
            tipoVehiculosElectricos[piv2] = tipoVehiculosElectricos[piv1];
            tipoVehiculosElectricos[piv1] = aux1;
            #endregion
            #region ordenar patente
            string aux2 = patentesElectricos[piv2];
            patentesElectricos[piv2] = patentesElectricos[piv1];
            patentesElectricos[piv1] = aux2;
            #endregion
        }
        #endregion
        #region mostrar electricos
        public void VerElectricos(int n, out int tipo, out int modelo, out string patente)
        {
            tipo= tipoVehiculosElectricos[n];
            modelo = modeloElectricos[n];
            patente = patentesElectricos[n];
        }
        #endregion
    }
}
