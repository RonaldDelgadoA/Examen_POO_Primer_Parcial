using System;

namespace ExamenP1
{
    class EstudianteSecundaria : Estudiante, IEstudiante
    {
        public int NivelCrusado { set; get; }
        public int PrecioNivel { set; get; }
        public EstudianteSecundaria(string Nombre, string Apellido, string Institucion, int CedulaIdentidad, int NivelCrusado, int PrecioNivel) : base(Nombre,Apellido,Institucion, CedulaIdentidad)
        {
            this.NivelCrusado = NivelCrusado;
            this.PrecioNivel = PrecioNivel;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Informacion de Estudiante Secundaria");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Institucion: " + Institucion);
            Console.WriteLine("Cedula Identidad: " + CedulaIdentidad);
            Console.WriteLine("Nivel Crusado: " + NivelCrusado);
            Console.WriteLine("Precio Fijo Nivel: " + PrecioNivel);
        }

        public void CalcularMatricula()
        {
            int Valor;
            Valor = NivelCrusado * PrecioNivel;
            Console.WriteLine("El valor anual de la matricula es: " + Valor);
        }
    }
}