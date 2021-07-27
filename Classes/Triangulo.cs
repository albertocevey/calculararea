namespace CalcAreaPOO
{
    public class Triangulo : Forma
    {
        public double Base {get; set;}
        public double Altura {get; set;}
        public override double CalcularArea => (this.Base * this.Altura) / 2;
    }
}