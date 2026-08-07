namespace Mascotas.Perro{

    public class Perro : Mascotas{
        
        public Perro(string nombre, double peso, char sexo, int edad, string propietario, bool estado)
        : base (nombre,peso,sexo,edad,propietario,estado)

        public overraide double CalcularDosis (dosis){
            return base.CalcularDosis(dosis);
        }
    }
}
