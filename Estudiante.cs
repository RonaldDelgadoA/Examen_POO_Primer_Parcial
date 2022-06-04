using System;

namespace ExamenP1
{
    class Estudiante
    {
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Institucion { set; get; }
        public int CedulaIdentidad { set; get; }

        public Estudiante(string Nombre, string Apellido, string Institucion, int CedulaIdentidad)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Institucion = Institucion;
            this.CedulaIdentidad = CedulaIdentidad;
        }
        public void ImprimirDatosE()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Informacion de Estudiante Primaria");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Institucion: " + Institucion);
            Console.WriteLine("Cedula Identidad: " + CedulaIdentidad);
        }
    }
}