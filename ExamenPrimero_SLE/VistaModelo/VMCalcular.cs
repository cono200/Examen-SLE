using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenPrimero_SLE.VistaModelo
{
    public class VMCalcular : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        private double _peso;
        private double _altura;
        private double _latidos;
        private bool _IMC;
        private bool _FNC;
        private string _IsVisible;
        private double _resultado;

        #endregion
        #region CONSTRUCTOR
        public VMCalcular(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public double Peso
        {
            get { return _peso; }
            set { SetValue(ref _peso, value); }
        }
        public double Altura
        {
            get { return _altura; }
            set { SetValue(ref _altura, value); }
        }
        public double Latidos
        {
            get { return _latidos; }
            set { SetValue(ref _latidos, value); }
        }
        public bool IMC
        {
            get { return _IMC; }
            set { SetValue(ref _IMC, value); }
        }
        public bool FNC
        {
            get { return _FNC; }
            set { SetValue(ref _FNC, value); }
        }
        public string IsVisible
        {
            get { return _IsVisible; }
            set { SetValue(ref _IsVisible, value); }
        }
        public double Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void procesoSimple()
        {

        } 
        public bool imcOpcion()
        {
            Desactivar();
            return IMC = true;
            
        } 
        public void Desactivar()
        {
            IsVisible = "False";
             
        }
        public bool FCNOpcion()
        {
            Desactivar();
            return FNC = true;
        }
        public void CalcularIMC()
        {
            if (imcOpcion() == true)
            {
                Resultado = Peso / (Altura * Altura);
                if (Resultado <= 18)
                {
                    DisplayAlert("Mensaje", " bajo peso", "ok");
                }
                else if(Resultado >= 19 && Resultado <= 24.9)
                {
                    DisplayAlert("Mensaje", "normal", "ok");
                }
                else if(Resultado >= 25 && Resultado <= 29.9)
                {
                    DisplayAlert("Mensaje", "Sobre Peso", "ok");
                }
                else
                {
                    DisplayAlert("Mensaje", "Obesidad", "ok");
                }
                
            }
            else if(FCNOpcion() == true)
            {
                Resultado = Latidos * 4;

                if (Resultado <= 60)
                {
                    DisplayAlert("Mensaje", "FC Baja", "ok");
                }
                else if(Resultado <=60 && Resultado <= 100)
                {
                    DisplayAlert("Mensaje", "FC Normal", "ok");

                }
                else
                {
                    DisplayAlert("Mensaje", "FC Alta", "ok");

                }
            }
        }
       

        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncomand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CalcularComand => new Command(CalcularIMC);
        #endregion




    }
}
