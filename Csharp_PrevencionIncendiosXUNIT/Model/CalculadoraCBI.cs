using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_PrevencionIncendiosXUNIT.Model
{
    public class CalculadoraCBI
    {
        #region ATRIBUTOS
        public event PropertyChangedEventHandler? PropertyChanged;
        private double temperatura, humedadRelativa;

        #endregion
        #region CONST,GET,SET

        public double Temperatura
        {
            get { return temperatura; }
            set
            {
                temperatura = value;
                OnPropertyChange("Temperatura");
            }
        }
        public double HumedadRelativa
        {
            get { return humedadRelativa; }
            set
            {
                humedadRelativa = value;
                OnPropertyChange("HumedadRelativa");
            }
        }
        #endregion

        //Método que se encarga de actualizar las propiedades en cada cambio
        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public double CalcularCBI(double temperatura, double humedadRelativa)
        {
            // Convertir la temperatura a °F
            double temperaturaFahrenheit = (temperatura * 9 / 5) + 32;

            // Calcular el primer paréntesis
            double primerParentesis = (110 - 1.373 * humedadRelativa) - 0.54 * (10.20 - temperaturaFahrenheit);

            // Calcular el segundo paréntesis
            double segundoParentesis = 124 * Math.Pow(10, -0.0142 * humedadRelativa);

            // Calcular el CBI
            double cbi = (primerParentesis * segundoParentesis) / 60;

            return cbi;
        }
    }

}
