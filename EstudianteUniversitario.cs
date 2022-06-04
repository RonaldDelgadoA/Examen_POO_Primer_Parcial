using System;

namespace ExamenP1
{
    class EstudianteUniversitario : Estudiante, IEstudiante
    {
        public int CantidadCreditos { set; get; }
        public int PrecioCredito { set; get; }
        public EstudianteUniversitario(string Nombre, string Apellido, string Institucion, int CedulaIdentidad, int CantidadCreditos, int PrecioCredito) : base(Nombre,Apellido,Institucion, CedulaIdentidad)
        {
            this.CantidadCreditos = CantidadCreditos;
            this.PrecioCredito = PrecioCredito;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Informacion de Estudiante Universitario");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Institucion: " + Institucion);
            Console.WriteLine("Cedula Identidad: " + CedulaIdentidad);
            Console.WriteLine("Cantidad de creditos: " + CantidadCreditos);
            Console.WriteLine("Precio de credito: " + PrecioCredito);
        }

        public void CalcularMatricula()
        {
            int Valor;
            Valor = CantidadCreditos * PrecioCredito;
            Console.WriteLine("El valor anual de la matricula es: " + Valor);
        }
    }
}