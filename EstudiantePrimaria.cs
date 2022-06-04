using System;

namespace ExamenP1
{
    class EstudiantePrimaria : Estudiante, IEstudiante
    {
        public int ValorFijo { set; get; }

        public EstudiantePrimaria(string Nombre, string Apellido, string Institucion, int CedulaIdentidad, int ValorFijo) : base(Nombre,Apellido,Institucion, CedulaIdentidad)
        {
            this.ValorFijo = ValorFijo;
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Informacion de Estudiante Primaria");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Institucion: " + Institucion);
            Console.WriteLine("Cedula Identidad: " + CedulaIdentidad);
            Console.WriteLine("Valor Fijo Anual: " + ValorFijo);
        }

        public void CalcularMatricula()
        {
            int Valor;
            Valor = ValorFijo;
            Console.WriteLine("El valor la matricula anual es: " + Valor);
        }
    }
}