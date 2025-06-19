using Ej1.Models;

namespace Ej1
{
    public partial class Form1 : Form
    {
        Servicio servicio;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            servicio = new Servicio();

        }

        private void BTNagregarComp_Click(object sender, EventArgs e)
        {
            inscripcion fDialog = new inscripcion();
            fDialog.ShowDialog();
            string nombre = fDialog.TBnombre.Text;
            servicio.RegistrarNombre(nombre);

        }

        private void BTNcargarTiempo_Click(object sender, EventArgs e)
        {
            Form3 tiempo = new Form3();

            if (servicio.contadr > 0)
            {
                for (int i = 0; i < servicio.contadr; i++)
                {
                    tiempo.ShowDialog();
                    tiempo.LBnumeroComp.Text = $"{i+1}";
                    tiempo.LBnombreComp.Text = $"{servicio.nombres[i]}";

                    int hora = Convert.ToInt32(tiempo.TBhoras.Text);
                    int minuto = Convert.ToInt32(tiempo.TBminutos.Text);
                    servicio.RegistrarTiempor(hora, minuto, i);
                   
                }
            }
        }

        private void BTNresultados_Click(object sender, EventArgs e)
        {
            Form4 resultado = new Form4();
            servicio.ordenar();
            for (int i = 000; i < servicio.contadr; i++)
            {
                resultado.LBXresultados.Items.Add($"00{i+1}, {servicio.nombres[i]} | {servicio.tiempoH[i]} | {servicio.tiempoH[i]}");
            }
            resultado.ShowDialog();
    


        }
    }
}
