/*using ObligatorioP2_De_Gregorio_y_Echenique;
using System;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Interfaz_ObligatorioP2_De_Gregorio_y_Echenique
{
    internal class Program
    {
        private static Sistema miSistema = new Sistema();
        //Menú desplegable
        static void Main(string[] args)
        {
            foreach (Animal animal in miSistema.Animales)
            {
                Console.WriteLine($"Animal: {animal.Caravana} - Registros: {animal.RegistroVacunaciones.Count}");
                foreach (RegistroVacunacion registro in animal.RegistroVacunaciones)
                {
                    Console.WriteLine("hola");
                    Console.WriteLine(registro.ToString());
                }
                if (animal.RegistroVacunaciones.Count == 0)
                {
                    Console.WriteLine("No vaccination records found for this animal.");
                }
            }
            int opcion = -1;
            while(opcion != 0)
            {
                MostrarMenu();
                Console.WriteLine("Ingrese opción seleccionada");
                int.TryParse(Console.ReadLine(), out opcion);
                EvaluarOpcionSeleccionada(opcion);
            }
        }

        //Método que despliega el menú
        private static void MostrarMenu()
        {
            Console.WriteLine("1-Listar animales");
            Console.WriteLine("2-Mostrar potreros con mayor cantidad de hectáreas y capacidad máxima");
            Console.WriteLine("3-Establecer el precio por kilogramo de lana de los ovinos");
            Console.WriteLine("4-Alta bovino");
            Console.WriteLine("0-Salir");
        }

        //Método que llama distintos métodos según la opcion seleccionada en el menú
        private static void EvaluarOpcionSeleccionada(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    MostrarAnimales();
                    break;
                case 2:
                    MostrarPotreroAreaCapacidad();
                    break;
                case 3:
                    EstablecerPrecioPorKgLana();
                    break;
                case 4:
                    AltaBovino();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }

        //Métodos para mostrar los datos (simplemente utilizados para corroborar que la precarga funcione), no se llaman en Program
        static void MostrarAnimalesPorPotrero()
        {
            foreach (Potrero potrero in miSistema.Potreros)
            {
                Console.WriteLine($"Potrero: {potrero.Id} - Capacidad: {potrero.Capacidad}");
                foreach (Animal animal in potrero.Animales)
                {
                    Console.WriteLine(animal);
                }
                Console.WriteLine(""); // Espacio entre potreros
            }
        }

        static void MostrarEmpleados()
        {
            foreach (Empleado empl in miSistema.Empleados)
            {
                Console.WriteLine(empl);
            }
        }

        static void MostrarVacunas()
        {
            foreach (Vacuna vac in miSistema.Vacunas)
            {
                Console.WriteLine(vac);
            }
        }

        static void MostrarPotreros()
        {
            foreach (Potrero potrero in miSistema.Potreros)
            {
                Console.WriteLine(potrero);
            }
        }

        //Método para la parte 3.a muestra una lista de todos los animales con sus ids, razas, pesos actuales y sexos
        static void MostrarAnimales()
        {
            try
            {
                if (miSistema.Animales.Count == 0)
                {
                    Console.WriteLine("Todavía no hay animales");
                }
                else
                {
                    foreach(Animal animal in miSistema.Animales)
                {
                        Console.WriteLine(animal);
                    }
                }
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }
        }
        //Método para la parte 3.b (mostrar potreros con más hectareas y capacidad de las ingresadas)
        private static List<Potrero> MostrarPotreroAreaCapacidad()
        {
            List<Potrero> potrerosEncontrados = new List<Potrero>();
            Console.WriteLine("Especifique una cantidad de hectáreas");
            double.TryParse(Console.ReadLine(), out double hectareas);
            Console.WriteLine("Especifique una capacidad maxima");
            int.TryParse(Console.ReadLine(), out int capacidad);
            try
            {
                if (hectareas > 0 && capacidad > 0)
                {
                    foreach (Potrero potrero in miSistema.Potreros)
                    {
                        if (potrero.Hectareas > hectareas && potrero.Capacidad > capacidad)
                        {
                            potrerosEncontrados.Add(potrero);
                            Console.WriteLine(potrero);
                        }
                    }
                    if (potrerosEncontrados.Count == 0)
                    {
                        Console.WriteLine("No existen potreros con estas características");
                    }
                }
                else
                {
                    Console.WriteLine("Los datos ingresados deben ser mayores a 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return potrerosEncontrados;
        }
        
        //Método para la parte 3.c establece un nuevo precio por kg de lana
        private static void EstablecerPrecioPorKgLana()
        {
            try
            {
                Console.WriteLine("El precio por Kg de lana es: " + Ovino._precioLanaPorKilo);
                Console.WriteLine("Especifique el precio por Kg para lana");
                decimal.TryParse(Console.ReadLine(), out decimal precio);
                if (precio > 0)
                {
                    Ovino._precioLanaPorKilo = precio;
                    Console.WriteLine("El precio por Kg de lana fue cambiado a " + Ovino._precioLanaPorKilo);
                }
                else
                {
                    Console.WriteLine("El precio debe ser mayor a 0");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Método para la parte 3.d da de alta un bovino con los datos ingresados por el usuario 
        private static void AltaBovino()
        {
            try
            {
                Console.WriteLine("Ingrese un código de caravana");
                string caravana = Console.ReadLine();
                Console.WriteLine("Ingrese el sexo del animal");
                string sexo = Console.ReadLine();
                Console.WriteLine("Ingrese la raza del animal");
                string raza = Console.ReadLine();
                Console.WriteLine("Ingrese la fecha de nacimiento, formato yyyy,mm,dd");
                DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento);
                Console.WriteLine("Ingrese el costo de adquisición");
                decimal.TryParse(Console.ReadLine(), out decimal costoAdquisicion);
                Console.WriteLine("Ingrese el costo de alimentación");
                decimal.TryParse(Console.ReadLine(), out decimal costoAlimentacion);
                Console.WriteLine("Ingrese el peso actual");
                decimal.TryParse(Console.ReadLine(), out decimal pesoActual);
                Console.WriteLine("Indique S si el animal es híbrido");
                string esHibrido = Console.ReadLine();
                Console.WriteLine("Ingrese el tipo de alimentación");
                string tipoAlimentacion = Console.ReadLine();
                if (caravana.Length == 8 && !string.IsNullOrEmpty(sexo) && !string.IsNullOrEmpty(raza) && fechaNacimiento != null && fechaNacimiento < DateTime.Now && costoAdquisicion > 0
                    && costoAlimentacion >0 && pesoActual > 0 && (tipoAlimentacion == "Grano" || tipoAlimentacion == "Pastura"))
                {
                    bool hibrido = false;
                    if (esHibrido.Trim() == "S")
                    {
                        hibrido = true;
                    }

                    miSistema.AltaBovino(new Bovino(caravana, sexo, raza, fechaNacimiento, costoAdquisicion, costoAlimentacion, pesoActual, hibrido, tipoAlimentacion));
                    Console.WriteLine("Bovino agregado");
                }
                else
                {
                    Console.WriteLine("Datos incorrectos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}*/