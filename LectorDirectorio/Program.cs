// See https://aka.ms/new-console-template for more information
string path;
Console.WriteLine("Ingrese el directorio a analizar: ");
path = Console.ReadLine();
while (!Directory.Exists(path))
{
    Console.WriteLine("El directorio indicado no existe, ingrese un directorio valido");
    path = Console.ReadLine();
}
Console.WriteLine("-------------------------------------------------------------------\n");
Console.WriteLine("Directorio elegido:");
Console.WriteLine(path + "\n");
Console.WriteLine("-------------------------------------------------------------------");
