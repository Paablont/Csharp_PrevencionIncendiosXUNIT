using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_PrevencionIncendiosXUNIT.ViewModel
{
    internal class CalculadoraModelView
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
    }
}
