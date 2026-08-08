
namespace Clase_Mascotas {

    public class Gato : Mascotas{

        private string Raza {get; set;}

        public Gato (string nombre, double peso, char sexo, int edad, string propietario, bool estado,string raza)
        : base (nombre,peso,sexo,edad,propietario,estado){
            this.Raza = raza;
        }
        
        public override double CalcularDosis(double dosis){
            return base.CalcularDosis(dosis)*09;
        }
        
    }
}