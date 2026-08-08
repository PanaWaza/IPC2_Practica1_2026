
namespace Clase_Mascotas{

    public class Ave : Mascotas{

        public int envergaduraAlas {get; set;}
        public bool puedeVolar {get; set;}

        public Ave (string nombre, double peso, char sexo, int edad, string propietario, int envergadura, bool volar)
        : base (nombre, peso, sexo, edad, propietario)
        {
            this.envergaduraAlas = envergadura;
            this.puedeVolar = volar;
        }

        public override double CalcularDosis(double dosis){
            return base.CalcularDosis(dosis) *0.5;
        }
    }
}