namespace CalcAreaPOO
{
    public class Retangulo : Forma
    {
        public double LadoMaior {get; set;}
        public double LadoMenor {get; set;}
        public override double CalcularArea => this.LadoMaior * this.LadoMenor;
    }
}