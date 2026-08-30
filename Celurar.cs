using System;

namespace INF512_Unidad1_POO
{
    public class Celular
    {
        // Atributos (Estado)
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Bateria { get; set; }
        public bool Encendido { get; set; }

        public Celular(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            Bateria = 100;
            Encendido = false;
        }

        // Métodos (Comportamiento)
        public void Encender()
        {
            Encendido = true;
            Console.WriteLine($"El celular {Marca} {Modelo} está encendido.");
        }

        public void TomarFoto()
        {
            if (Encendido && Bateria > 5)
            {
                Bateria -= 5;
                Console.WriteLine("Foto tomada con éxito. Batería restante: " + Bateria + "%");
            }
            else
            {
                Console.WriteLine("No se puede tomar la foto. Verifica la batería o si el equipo está encendido.");
            }
        }
    }
}
