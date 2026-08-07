using System;

namespace Clase_Mascotas
{
    
class mascotas {
    private string nombre {get; set;};
    private double peso {get; set;};
    private char sexo {get; set;};
    private int edad {get; set;};
    private string propietario {get; set;};
    private string codigo {get; set;};
    private bool estado {get; set;};

    private mascotas(string nombre, double peso, char sexo, int edad, string propietario, string codigo, bool estodo){
        nombre = nombre;
        peso = peso;
        sexo = sexo;
        edad = edad;
        propietario = propietario;
        codigo = codigo;(
        estado = estado;
    }

    public string GenerarCogigoMascota(){
        string codigo = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        return codigo;
    }

    


    
} 
}