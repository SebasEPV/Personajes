using Personajes;

var personaje = new Personaje
{
    Nombre = "Dhayan Drollat",
    Velocidad = 82,
    Pase = 75,
    Regate = false,
    Tiro = 87,
    Defensa = 54,
    Fisico = 44
};

Console.WriteLine($"Nombre: {personaje.Nombre}");
Console.WriteLine($"Velocidad: {personaje.Velocidad}");
Console.WriteLine($"Pase: {personaje.Pase}");
Console.WriteLine($"Regate: {personaje.Regate}");
Console.WriteLine($"Tiro: {personaje.Tiro}");
Console.WriteLine($"Defensa: {personaje.Defensa}");
Console.WriteLine($"Fisico: {personaje.Fisico}");
