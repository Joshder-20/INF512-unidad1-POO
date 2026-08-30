using System;

namespace INF512_Unidad1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación del objeto
            Celular miTelefono = new Celular("Samsung", "Galaxy S23");

            // Prueba de métodos
            miTelefono.Encender();
            miTelefono.TomarFoto();
        }
    }
}
