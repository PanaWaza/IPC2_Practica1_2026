using System;

namespace Clase_Mascotas
{
    public class Mascotas 
    {
        public string Nombre { get; set; }
        public double Peso { get; set; }
        public char Sexo { get; set; }
        public int Edad { get; set; }
        public string Propietario { get; set; }
        public string Codigo { get; private set; } 
        public bool Estado { get; set; } // true sano, false enfermo 

        public Mascotas(string nombre, double peso, char sexo, int edad, string propietario)
        {
            this.Nombre = nombre;
            this.Peso = peso;
            this.Sexo = sexo;
            this.Edad = edad;
            this.Propietario = propietario;
            this.Estado = false;
            this.Codigo = GenerarCodigoMascota(); 
        }

        private string GenerarCodigoMascota()
        {
            string codigoGenerado = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            Console.WriteLine($"El código generado es: {codigoGenerado}");
            return codigoGenerado;
        }

        public virtual double CalcularDosis(double dosis)
        {
            return this.Peso * dosis;
        }

        public void CambiarEstadoPaciente()
        {
            this.Estado = !this.Estado; 
            Console.WriteLine($" -> El estado del paciente fue cambiado exitosamente - Estado actual: {(this.Estado ? "Sano" : "Enfermo")}");
        }

        public void MostrarInfo()
        {
            Console.WriteLine("-----------------------------------\n" +
                              $"- Nombre: {this.Nombre}\n" +
                              $"- Peso: {this.Peso} kg\n" +
                              $"- Sexo: {this.Sexo}\n" +
                              $"- Edad: {this.Edad}\n" +
                              $"- Propietario: {this.Propietario}\n" +
                              $"- Código: {this.Codigo}\n" +
                              $"- Estado: {(this.Estado ? "Sano" : "Enfermo")}\n" +
                              "-----------------------------------");
        }

        
    } 
}