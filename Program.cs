using System;

namespace ExamenP1
{
    class Program
    {
        public static void Main(string[] args)
        {
            EstudiantePrimaria E1 = new EstudiantePrimaria("Jose","Mora","ABCDE",123456789, 100);
            E1.ImprimirDatos();
            E1.CalcularMatricula();
            
            EstudianteSecundaria E2 = new EstudianteSecundaria("Juna","Zambrano","QWERT",545465683,5,20);
            E2.ImprimirDatos();
            E2.CalcularMatricula();
            
            EstudianteUniversitario E3 = new EstudianteUniversitario("Mario","Vasques","AEIOU",568967452,20,30);
            E3.ImprimirDatos();
            E3.CalcularMatricula();
        }
    }
}
