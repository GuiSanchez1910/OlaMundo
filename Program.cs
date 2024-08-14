int a = 10;
int b = 5;
// int x = 1910;
int r = a + b;

// string str = "Palmeras não tem mundial";

// Console.WriteLine($"Valor {x}");

// var str = "Palmeras não tem mundial";

// Console.WriteLine(str);

// Console.WriteLine("Resultado -> " + r);

Console.WriteLine("Informe a primeira nota:");
var nota1 = Console.ReadLine();
Console.WriteLine("Informe a segunda nota:");
var nota2 = Console.ReadLine();

Console.WriteLine($"Nota1: {nota1}");
Console.WriteLine($"Nota2: {nota2}");

var media = (Convert.ToDouble(nota1) + Convert.ToDouble(nota2)) / 2;

Console.WriteLine($"Media: {media}");

if(media > 6) {
    Console.WriteLine("Aprovado");
}

else {
    Console.WriteLine("Reprovado");
}