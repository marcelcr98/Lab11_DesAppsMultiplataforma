using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab11.ModelViews
{
    class OperacionesViewModel : BaseViewModel
    {
        #region Propiedades
        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }

        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }

        int suma;
        public int ResultSuma
        {
            get { return suma; }
            set
            {
                if (suma != value)
                {
                    suma = value;
                    OnPropertyChanged();
                }
            }
        }

        int resta;
        public int ResultResta
        {
            get { return resta; }
            set
            {
                if (resta != value)
                {
                    resta = value;
                    OnPropertyChanged();
                }
            }
        }
        int multiplicar;
        public int ResultMultiplicar
        {
            get { return multiplicar; }
            set
            {
                if(multiplicar != value)
                {
                    multiplicar = value;
                    OnPropertyChanged();
                }
            }
        }
        int dividir;
        public int ResultDividir
        {
            get { return dividir; }
            set
            {
                if(dividir != value)
                {
                    dividir = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion

        #region Comandos 
        public ICommand Sumar { protected set; get; }

        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }

        #endregion

        #region Constructor

        public OperacionesViewModel()
        {

            Sumar = new Command(() =>
            {
                ResultSuma = Valor1 + Valor2;
            });

            Restar = new Command(() =>
            {
                ResultResta = Valor1 - Valor2;
            });
            Multiplicar = new Command(() =>
            {
                ResultMultiplicar = Valor1 * Valor2;
            });
            Dividir = new Command(() =>
            {
                ResultDividir = Valor1 / Valor2;
            });

        }
        #endregion

    }
}
