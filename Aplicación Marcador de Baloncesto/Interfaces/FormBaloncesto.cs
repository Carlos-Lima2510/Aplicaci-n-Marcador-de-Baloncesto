using System;
using System.Windows.Forms;

namespace Aplicación_Marcador_de_Baloncesto.Interfaces
{
    public partial class FormBaloncesto : Form
    {
        int tiempoTotal = 12 * 60;
        int contacuartos = 1;
        int puntuacionLocal = 0;
        int puntuacionVisitante = 0;
        private Timer timer = new Timer();
        public FormBaloncesto()
        {
            InitializeComponent();
            timer.Interval = 10; 
            timer.Tick += timer1_Tick;
        }

        private void btn_InicioTiempo_Click(object sender, EventArgs e)
        {
            timer.Start();
            btn_InicioTiempo.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempoTotal--;
            if (tiempoTotal < 0)
            {
                label_Tiempo.Text = "00:00";
                tiempoTotal = 12 * 60;
                int minutos = tiempoTotal / 60;
                int segundos = tiempoTotal % 60;
                label_Tiempo.Text = $"{minutos:D2}:{segundos:D2}";
                contacuartos++;
                label_Cuarto.Text = contacuartos.ToString();
            }
            else
            {
                int minutos = tiempoTotal / 60;
                int segundos = tiempoTotal % 60;
                label_Tiempo.Text = $"{minutos:D2}:{segundos:D2}";
            }

            if (label_Cuarto.Text == "4" && label_Tiempo.Text == "00:00")
            {
                timer.Stop();
                MessageBox.Show("EL JUEGO HA FINALIZADO");
                if (Convert.ToInt32(label_Local.Text) > Convert.ToInt32(label_Visitante.Text))
                {
                    MessageBox.Show("EQUIPO LOCAL HA GANADO");
                }
                if (Convert.ToInt32(label_Local.Text) < Convert.ToInt32(label_Visitante.Text))
                {
                    MessageBox.Show("EQUIPO VISITANTE HA GANADO");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn_InicioTiempo.Enabled = true;
            timer.Stop();
        }

        private void btn_Reinicio_Click(object sender, EventArgs e)
        {
            btn_InicioTiempo.Enabled = true;
            timer.Stop();
            tiempoTotal = 12 * 60;
            int minutos = tiempoTotal / 60;
            int segundos = tiempoTotal % 60;
            label_Tiempo.Text = $"{minutos:D2}:{segundos:D2}";
            label_Cuarto.Text = "1";
            contacuartos = 1;
            label_Local.Text = "0";
            label_Visitante.Text = "0";
            puntuacionLocal = 0;
            puntuacionVisitante = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            puntuacionLocal++;
            label_Local.Text = puntuacionLocal.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puntuacionVisitante++;
            label_Visitante.Text = puntuacionVisitante.ToString();   
        }
    }   
}
