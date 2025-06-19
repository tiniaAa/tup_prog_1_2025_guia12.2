using EJ2.Models;

namespace EJ2
{
    public partial class Form1 : Form
    {
        Controladora controladora;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controladora = new Controladora();
        }

        private void BTNregistrar_Click(object sender, EventArgs e)
        {
            string patente = TBpatente.Text;
            int tipo = CBXtipo.SelectedIndex;
            int modelo = Convert.ToInt32(TBmodelo.Text);
            bool electrico = CBelectrico.Checked;

            controladora.RegistrarVehiculo(patente, tipo, modelo, electrico);

            CBelectrico.Checked=false;
            TBmodelo.Clear();
            TBpatente.Clear();
            CBXtipo.SelectedIndex = -1;


        }

        private void BTNestadistica_Click(object sender, EventArgs e)
        {
            Form2 resultados = new Form2();


            controladora.ListarElectricos();
            if (controladora.contadorElectricos > 0)
            {
                resultados.LBresultados.Items.Add("Vehiculos electricos ");
                resultados.LBresultados.Items.Add("PATENTE|MODELO(AÑO)|TIPO");
                for (int n = 0; n < controladora.contadorElectricos; n++)
                {
                    int tipo;
                    int modelo;
                    string patente;
                    controladora.VerElectricos(n, out tipo, out modelo, out patente);

                    string tipoV = "";
                    switch (tipo)
                    {
                        case 0: tipoV = "Auto";break;
                        case 1: tipoV = "Moto"; break;
                        case 2: tipoV = "Camión"; break;
                        case 3: tipoV = "Camioneta"; break;
                        default: tipoV = "no existe"; break;
                    }

                    resultados.LBresultados.Items.Add($"{patente}|{modelo}|{tipoV}");

                }
            }
            else 
            {
                resultados.LBresultados.Items.Add("No se ingresaron vehiculos electricos ");
            }




                resultados.ShowDialog();
        }
    }
}
