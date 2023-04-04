internal class Program
{
    private static void Main(string[] args)
    {
        /* 
         Enunciado: Desarrolla una aplicación en C# para evaluar exámenes de selección múltiple. La aplicación debe permitir ingresar las preguntas y respuestas, así como las opciones de respuesta para cada pregunta. Una vez que se ingresan las preguntas y respuestas, la aplicación debe permitir al usuario responder el examen y mostrar los resultados al final de la evaluación.
         Para resolver este ejemplo, primero debemos definir la estructura de datos necesaria para almacenar las preguntas, opciones de respuesta y respuestas correctas. Podemos utilizar una matriz bidimensional o unidimensional para almacenar las opciones de respuesta para cada pregunta y una matriz unidimensional para almacenar las respuestas correctas.

           La solución propuesta utiliza dos instancias. La primera que es la del ingreso de datos y la segunda que es la del examen. Utiliza dos arreglos en la primera instancia para guardar preguntas y opciones (bidimensional) y respuestas correctas (unidimensional). En la segunda instancia utiliza otro arreglo unidimensional que contiene las respuestas ingresadas por el usuario y lo compara con el arreglo de las respuestas correctas. También utiliza un contador para las respuestas correctas.
           Todas las operaciones se realizan con la estructura repetitiva for.
         */


        //INSTANCIA DEL INGRESO DE DATOS
        Console.WriteLine("Ingrese la cantidad de preguntas que quiere tener en el examen: ");
        int cantidadPreguntas = int.Parse(Console.ReadLine());
        string[,] preguntas = new string[cantidadPreguntas, 2];
        string[] respuestasCorrectas = new string[cantidadPreguntas];

        //Ingreso de las preguntas por teclado.
        for (int i = 0; i < preguntas.GetLength(0); i++)
        {
            Console.WriteLine($"Ingrese la pregunta número {i + 1}");
            preguntas[i, 0] = Console.ReadLine();
        }

        //Muestra las preguntas al usuario.
        Console.WriteLine("\nLas preguntas ingresadas son: ");
        for (int i = 0; i < preguntas.GetLength(0); i++)
        {
            Console.WriteLine(preguntas[i,0]);
        }

        //Ingreso de las opciones por teclado
        Console.WriteLine("\nIngrese las opciones. Las opciones deben alfabeticas.");
        for (int i = 0; i < preguntas.GetLength(0); i++)
        {
            Console.WriteLine($"Ingrese las opciones de la pregunta número {i + 1}");
            preguntas[i, 1] = Console.ReadLine();

        }
        //Muestra las preguntas y respuestas al usuario
        Console.WriteLine("\nLas preguntas y respectivas opciones ingresadas son: ");
        for (int i = 0; i < preguntas.GetLength(0); i++)
        {
            Console.WriteLine($"{i+1})");
            Console.WriteLine(preguntas[i, 0]);
            Console.WriteLine(preguntas[i, 1]);
        }

        //Ingreso de las respuestas correctas
        Console.WriteLine("\nA continuación, ingrese cual es la respuesta correcta de cada pregunta: ");
        for (int i = 0; i < respuestasCorrectas.Length; i++)
        {
            Console.WriteLine($"Ingrese la respuesta de la pregunta número {i + 1}");
            respuestasCorrectas[i]=Console.ReadLine().ToUpper();
        }
        //Muestra las respuestas correctas a cada una de las preguntas ingresadas por el usuario
        Console.WriteLine("\nLas preguntas y respectivas opciones y respuestas correctas ingresadas son: ");
        for (int i = 0; i < preguntas.GetLength(0); i++)
        {
            Console.WriteLine(preguntas[i, 0]);
            Console.WriteLine(preguntas[i, 1]);
            Console.WriteLine("Respuesta correcta: ");
            Console.WriteLine(respuestasCorrectas[i]);
            Console.WriteLine("\n");
        }



        //INSTANCIA DEL EXAMEN
        string[] respuestasUsuario = new string[cantidadPreguntas];  
        Console.WriteLine("Para tomar el examen, pulse cualquier tecla.");
        Console.ReadKey();
        Console.Clear(); //Aseguramos limpiar la consola para que el ingreso de los datos no sea visible.
        Console.WriteLine("Ingrese la opción correcta: ");
        for (int i = 0; i < preguntas.GetLength(0); i++)
        {
            Console.WriteLine(preguntas[i, 0]);
            Console.WriteLine(preguntas[i, 1]);
            respuestasUsuario[i]=Console.ReadLine().ToUpper();
        }
        Console.WriteLine("\nResultados del examen: ");
        int cantidadCorrectas=0;
        for (int i = 0;i<respuestasCorrectas.Length;i++)
        {
            if (respuestasUsuario[i] == respuestasCorrectas[i])
            {
                cantidadCorrectas++;
            }
        }
        Console.WriteLine($"Usted ha obtenido {cantidadCorrectas} respuestas correctas de {cantidadPreguntas} preguntas");
        Console.ReadKey();
    }
}