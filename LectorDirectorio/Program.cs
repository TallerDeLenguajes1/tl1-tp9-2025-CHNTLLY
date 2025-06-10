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
Console.WriteLine("-------------------------------------------------------------------\n");

//Listado de los directorios encontrados en la ruta especificada

string[] carpetas;
carpetas = Directory.GetDirectories(path);
Console.WriteLine("--------------------------Directorios encontrados: ");

foreach (var dir in carpetas)
{
    Console.WriteLine(dir);
}

string[] archivos;
archivos = Directory.GetFiles(path);
Console.WriteLine("\n--------------------------Archivos encontrados: ");

foreach (var file in archivos)
{
    var Info = new FileInfo(file);
    var Bytes = Info.Length;
    var nombre = Path.GetFileName(file);
    Console.WriteLine(nombre + "// tamaño: " + Bytes/1024 + " Kb");
}


//var a = new FileInfo("c:\\");
//a.

