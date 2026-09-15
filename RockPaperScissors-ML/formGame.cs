using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors_ML
{
    public partial class formGame : Form
    {
        private MetricsForm _ventanaMetricas;
        private RockPaperScissors.Core.stateVector _historial = new RockPaperScissors.Core.stateVector(10);
        public formGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MinimumSize = new Size(640, 480);
        }
        private void JugarRonda(int jugadaUsuario)
        {
            _historial.RecordMove(jugadaUsuario);

            if (!_historial.IsReadyForInference())
            {
                return;
            }

            string cadenaParaR = _historial.GetSerializedHistory();

            var reporteProgreso = new Progress<RockPaperScissors.Core.MetricasTelemetry>(telemetria =>
            {
                if (_ventanaMetricas != null && !_ventanaMetricas.IsDisposed)
                {
                    _ventanaMetricas.ActualizarGraficas(telemetria.TdError, telemetria.Mse);
                }
            });

            string salidaDeR = "2,0.85";

            string[] partesR = salidaDeR.Split(',');
            int prediccionR = int.Parse(partesR[0]);

            bool botGano = false;
            if ((prediccionR == 1 && jugadaUsuario == 3) ||
                (prediccionR == 2 && jugadaUsuario == 1) ||
                (prediccionR == 3 && jugadaUsuario == 2))
            {
                botGano = true;
            }

            RockPaperScissors.Core.CalculadoraMetricas calculadora = new RockPaperScissors.Core.CalculadoraMetricas();
            calculadora.ProcesarPrediccionR(salidaDeR, botGano, reporteProgreso);
        }

        private void formGame_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.SuspendLayout();
                int targetWidth = (this.Height * 4) / 3;

                if (this.Width != targetWidth)
                {
                    this.Width = targetWidth;
                }

                this.ResumeLayout();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formMenu formMenu = new formMenu();
            formMenu.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (_ventanaMetricas == null || _ventanaMetricas.IsDisposed)
            {
                _ventanaMetricas = new MetricsForm();
                _ventanaMetricas.Show();
            }
            else
            {
                _ventanaMetricas.BringToFront();
            }
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            JugarRonda(1);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            JugarRonda(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            JugarRonda(3);
        }
    }
}
