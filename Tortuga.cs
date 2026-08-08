
namespace Clase_Mascotas {

    public class Tortugas : Mascotas{
        public string tipoCaparazon {get; set;}
        public bool esAcuatico {get; set;}

        public Tortugas (string nombre, double peso, char sexo, int edad, string propietario , string caparazon, bool acuatico) 
        : base (nombre, peso, sexo, edad, propietario){
            this.tipoCaparazon = caparazon;
            this.esAcuatico = acuatico;
        }

        public override double CalcularDosis(double dosis){
            return base.CalcularDosis(dosis)*0.8 ;
        }
    }
}