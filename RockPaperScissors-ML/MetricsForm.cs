using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RockPaperScissors_ML
{
    public partial class MetricsForm : Form
    {
        private ScottPlot.FormsPlot formsPlot1;
        // Arrays o Listas para almacenar los datos históricos
        private List<double> _tdErrors = new List<double>();
        private List<double> _mseValues = new List<double>();
        private List<double> _rounds = new List<double>();
        private int _roundCount = 0;

        public MetricsForm()
        {
            InitializeComponent();
            formsPlot1 = new ScottPlot.FormsPlot();
            formsPlot1.Dock = DockStyle.Fill; // Esto hace que ocupe todo el espacio de la ventana
            this.Controls.Add(formsPlot1);    // Esto es el equivalente a arrastrarlo con el mouse

            formsPlot1.Plot.Title("Rendimiento del Modelo RL");
            formsPlot1.Plot.XLabel("Rondas");
            formsPlot1.Plot.YLabel("Error");
        }

        public void ActualizarGraficas(double tdError, double mse)
        {
            _roundCount++;
            _rounds.Add(_roundCount);
            _tdErrors.Add(tdError);
            _mseValues.Add(mse);

            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AddScatter(_rounds.ToArray(), _tdErrors.ToArray(), label: "TD Error");
            formsPlot1.Plot.AddScatter(_rounds.ToArray(), _mseValues.ToArray(), label: "MSE");
            formsPlot1.Plot.Legend();

            formsPlot1.Refresh();
        }
    }
}
