using System;
using System.Globalization;

namespace RockPaperScissors.Core
{
    public class MetricasTelemetry
    {
        public double TdError { get; set; }
        public double Mse { get; set; }
    }

    public class CalculadoraMetricas
    {
        public void ProcesarPrediccionR(string rOutput, bool botGano, IProgress<MetricasTelemetry> progreso)
        {
            string[] partes = rOutput.Split(',');

            if (partes.Length < 2) return;

            double probabilidadR = double.Parse(partes[1], CultureInfo.InvariantCulture);
            double valorReal = botGano ? 1.0 : 0.0;

            double tdError = valorReal - probabilidadR;
            double mseRound = Math.Pow(tdError, 2);

            progreso.Report(new MetricasTelemetry { TdError = tdError, Mse = mseRound });
        }
    }
}