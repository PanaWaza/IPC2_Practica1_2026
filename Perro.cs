
namespace Clase_Mascotas 
{
    public class Perro : Mascotas
    {
        public string Raza { get; set; }
        public double Tamano { get; set; } 

        public Perro(string nombre, double peso, char sexo, int edad, string propietario, bool estado, string raza, double tamano)
            : base(nombre, peso, sexo, edad, propietario, estado)
        {
            this.Raza = raza;
            this.Tamano = tamano;
        }

        public override double CalcularDosis(double dosis)
        {
            return base.CalcularDosis(dosis);
        }
    }
}