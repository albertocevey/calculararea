using System;
namespace CalcAreaPOO
{
    public class Circulo : Forma
    {
        public double Raio {get; set;}
        public override double CalcularArea => Math.Pow(this.Raio, 2) * Math.PI;
    }
}