// See https://aka.ms/new-console-template for more information
void matriz()
{
    Console.WriteLine("Ingrese el número de estudiantes: ");
    int numEstudiantes = int.Parse(Console.ReadLine());

    string[] nombre = new string[numEstudiantes];
    int[] notas = new int[numEstudiantes];

    for (int i = 0; i < numEstudiantes; i++)
    {
        Console.WriteLine("Ingrese el nombre del estudiante " + (i + 1) + ": ");
        nombre[i] = Console.ReadLine();

        Console.WriteLine("Ingrese la nota del estudiante " + (i + 1) + ": ");
        notas[i] = int.Parse(Console.ReadLine());
    }

    int promedio = 0;
    foreach (int n in notas)
    {
        promedio = promedio + n;
    }
    promedio = promedio / notas.Length;
    Console.WriteLine("El promedio es=" + promedio);

    int notaMaxima = 0;
    int indiceMaximo = 0;
    int notaMinima = notas[0];
    int indiceMinimo = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > notaMaxima)
        {
            notaMaxima = notas[i];
            indiceMaximo = i;
        }

        if (notas[i] < notaMinima)
        {
            notaMinima = notas[i];
            indiceMinimo = i;
        }
    }

    string nombreMaximo = nombre[indiceMaximo];
    Console.WriteLine("La nota más alta es= " + notaMaxima + " y fue obtenida por " + nombreMaximo);

    string nombreMinimo = nombre[indiceMinimo];
    Console.WriteLine("La nota más baja es= " + notaMinima + " y fue obtenida por " + nombreMinimo);
}

matriz();

