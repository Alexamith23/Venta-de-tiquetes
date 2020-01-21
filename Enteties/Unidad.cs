using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteties
{
    public class Unidad
    {
        private string codigo;
        private string numPlaca;
        private string numMotor;
        private string modelo;
        private int capacidad;
        private string rutaAsignada;
        private string numPerTransito;
        private string fechaVigencia;
        private string color;
        public Unidad()
        {

        }

        public Unidad(string codigo, string numPlaca, string numMotor, string modelo, int capacidad, string rutaAsignada, string numPerTransito, string fechaVigencia,string color)
        {
            this.codigo = codigo;
            this.numPlaca = numPlaca;
            this.numMotor = numMotor;
            this.modelo = modelo;
            this.capacidad = capacidad;
            this.rutaAsignada = rutaAsignada;
            this.numPerTransito = numPerTransito;
            this.fechaVigencia = fechaVigencia;
            this.color = color;
        }

        
         public string Codigo { get => codigo; set => codigo = value; }
         public string GSNumPlaca { get => numPlaca; set => numPlaca = value; }
         public string GSNumMotor { get => numMotor; set => numMotor = value; }
        public string GSModelo { get => modelo; set => modelo = value; }
        public string GSColor { get => color; set => color = value; }
        public int GSCapacidad { get => capacidad; set => capacidad = value; }
        public string GSRutaAsignada { get => rutaAsignada; set => rutaAsignada = value; }
        public string GSPermisoTransito { get => numPerTransito; set => numPerTransito = value; }
        public string GSFechaVigencia { get => fechaVigencia; set => fechaVigencia = value; }
        public override string ToString()
         {
             return codigo + "," + numPlaca + "," + numMotor + "," + modelo + ","+capacidad+"," + color + "," + rutaAsignada + "," + numPerTransito+","+fechaVigencia;
         }
         
    }
}
