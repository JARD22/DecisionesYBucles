var cantidad1 = 6;
var cantidad2 = 5;

var esIgual = cantidad1 == cantidad2;

//Console.WriteLine($"Son {cantidad1} y {cantidad2} {esIgual}");

var nombre1 = "test";
var nombre2 = "test";

var isNull = nombre1 is null;
var isNotNull = nombre2 is not null;

//Console.WriteLine($" {nombre1} es nulo {isNull}");
//Console.WriteLine($" {nombre1} no es nulo {isNotNull}"); 

// =====================================IF ELSE==============================================

var valor1 = cantidad1 > 5 && cantidad1 < 10;

//Console.WriteLine($"El numero {cantidad1} esta entre 5 y 10 {valor1}");

var valor2 = cantidad2 == 5 || cantidad1 == 6;

//Console.WriteLine($"Es {cantidad1} igual a 5 o 6 {valor2}");


if (cantidad1 > 5){
    //Console.WriteLine("es mayor a 5");
}else{
    //Console.WriteLine("fin");
}

string esMayor = cantidad1 > 4 ? "true" : "false";

Console.WriteLine(esMayor);
//=====================================SWITCH==================================================

switch (cantidad1)
{
    case 4:
        Console.WriteLine("Case 4");
        break;
    case 5: Console.WriteLine("case 5");
        break;
    case 6: Console.WriteLine("case 6");
        break;

}

//PATRONES RELACIONALES

var temperatura = 37;

var mensaje = temperatura switch
{
    37 => "No tienes ninguna condicion",
    >37 => "Tienes fiebre",
    <37 => "Puede que tengas baja el azucar"
};

//Console.WriteLine(mensaje);


//PATRONES LOGICOS

string? apellido = "Aguilera";
if (apellido is not null)
{
    Console.WriteLine(apellido.ToUpper());
}

//pattern matching;
mensaje = temperatura switch
{
    37 => "no tienes ninguna condicion",
    > 37 and < 39 => "tienes fiebre",
    >= 39 and < 43 => "Debes ir al medico"
};

Console.WriteLine(mensaje);
Console.WriteLine("FIN");

var hoy = DateTime.Today;

var estacion = hoy.Month switch
{
    3 or 4 or 5 => "Primavera",
    6 or 7 or 8 => "Verano",
    9 or 10 or 11 => "Otonio",
    12 or 1 or 2 => "invierno",
    _ => throw new ApplicationException("Mes incorrecto")
};

Console.WriteLine(estacion); 

