namespace PresentacionEstudiante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Tu Nombre Completo";
            string carrera = "Tu Carrera / Profesión";
            string motivo = "Interés en el desarrollo de software y automatización.";
            string bienvenida = "¡Bienvenido al curso de programación! Éxito en tu aprendizaje.";

            Console.Clear();
            Console.WriteLine(new string('─', 65));
            Console.WriteLine("               FICHA DE PRESENTACIÓN DEL ESTUDIANTE               ");
            Console.WriteLine(new string('─', 65));

            Console.WriteLine($" NOMBRE:            {nombre}");
            Console.WriteLine($" CARRERA:           {carrera}");
            Console.WriteLine($" MOTIVO DE ESTUDIO: {motivo}");

            Console.WriteLine(new string('─', 65));
            Console.WriteLine($" MENSAJE:           {bienvenida}");
            Console.WriteLine(new string('─', 65));

            Console.ReadKey();
        }
    }
}