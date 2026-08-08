using System;
using System.Collections.Generic; 

namespace Clase_Mascotas
{
    class Practica1
    {
        static void Main(string[] args)
        {
            List<Mascotas> listaMascotas = new List<Mascotas>();
            int opcion = 0;

            Console.WriteLine(" --------------------- Sistema de Veterinaria ---------------------\n");
            Console.WriteLine("--> Bienvenido al sistema de veterinaria \n");

            do
            {
                Console.WriteLine("\n   - Ingrese 1 : Para registrar Paciente");
                Console.WriteLine("   - Ingrese 2 : Para Consultar Paciente");
                Console.WriteLine("   - Ingrese 3 : Para Gestionar Paciente");
                Console.WriteLine("   - Ingrese 4 : Para Salir");

                Console.Write("-> ");
                
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n[Opción 1: Registrar Paciente]");
                        // Pasamos la lista como parámetro
                        registroMascota(listaMascotas);
                        break;

                    case 2:
                        Console.WriteLine("\n[Opción 2: Consultar Paciente]");
                        // TODO: Implementar lógica de consulta
                        break;

                    case 3:
                        Console.WriteLine("\n[Opción 3: Gestionar Paciente]");
                        // TODO: Implementar lógica de gestión (cambiar estado / calcular dosis)
                        break;

                    case 4:
                        Console.WriteLine("\nSaliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción fuera de rango. Intente de nuevo.");
                        break;
                }

            } while (opcion != 4);

            Console.WriteLine("-> Fue un placer atenderlo, Feliz día.");
        }

        public static void registroMascota(List<Mascotas> listaMascotas)
        {
            Console.WriteLine("\n-> Ingresa el tipo de mascota");
            Console.WriteLine("1: Perro");
            Console.WriteLine("2: Gato");
            Console.WriteLine("3: Ave");
            Console.WriteLine("4: Tortuga");

            Console.Write("Opción -> : ");
            if (!int.TryParse(Console.ReadLine(), out int opcionTipo))
            {
                Console.WriteLine("Opción de tipo inválida.");
                return;
            }

            Console.Write("\nNombre de la mascota: ");
            string nombre = Console.ReadLine();

            Console.Write("\nPeso (kg): ");
            double.TryParse(Console.ReadLine(), out double peso);

            Console.Write("\nSexo (F o M): ");
            char.TryParse(Console.ReadLine(), out char sexo);

            Console.Write("\nEdad (años): ");
            int.TryParse(Console.ReadLine(), out int edad);

            Console.Write("\nNombre del propietario: ");
            string propietario = Console.ReadLine();

            Mascotas m = null;

            switch (opcionTipo)
            {
                case 1:
                    Console.Write("\nRaza del perro: ");
                    string razaPerro = Console.ReadLine();

                    Console.Write("\nTamaño del perro (cm/m): ");
                    double.TryParse(Console.ReadLine(), out double tamanoPerro);

                    m = new Perro(nombre, peso, sexo, edad, propietario, razaPerro, tamanoPerro);
                    break;

                case 2:
                    Console.Write("\nRaza del Gato: ");
                    string razaGato = Console.ReadLine();

                    m = new Gato(nombre, peso, sexo, edad, propietario, razaGato);
                    break;

                case 3:
                    Console.Write("\nEnvergadura de las alas del ave (cm): ");
                    int.TryParse(Console.ReadLine(), out int envergadura);

                    Console.Write("\n¿Puede volar el ave? (true / false): ");
                    bool.TryParse(Console.ReadLine(), out bool volar);

                    m = new Ave(nombre, peso, sexo, edad, propietario, envergadura, volar);
                    break;

                case 4:
                    Console.Write("\nTipo de caparazón de la tortuga: ");
                    string caparazon = Console.ReadLine();

                    Console.Write("\n¿Es acuática la tortuga? (true / false): ");
                    bool.TryParse(Console.ReadLine(), out bool acuatica);

                    m = new Tortuga(nombre, peso, sexo, edad, propietario, caparazon, acuatica);
                    break;

                default:
                    Console.WriteLine("Tipo de mascota no válido.");
                    return;
            }

            if (m != null)
            {
                listaMascotas.Add(m);
                Console.WriteLine("\n    - Se registró el paciente exitosamente - ");
                Console.WriteLine($"El código de la mascota es: {m.Codigo}"); 
            }
        }


        
    }
}