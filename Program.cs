var cantidad1 = 5;
var cantidad2 = 5;

var esIgual = cantidad1 == cantidad2;

Console.WriteLine($"Son {cantidad1} y {cantidad2} {esIgual}");

var nombre1 = "test";
var nombre2 = "test";

var isNull = nombre1 is null;
var isNotNull = nombre2 is not null;

Console.WriteLine($" {nombre1} es nulo {isNull}");
Console.WriteLine($" {nombre1} no es nulo {isNotNull}");
