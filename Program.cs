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

//Console.WriteLine(mensaje);
//Console.WriteLine("FIN");

var hoy = DateTime.Today;

var estacion = hoy.Month switch
{
    3 or 4 or 5 => "Primavera",
    6 or 7 or 8 => "Verano",
    9 or 10 or 11 => "Otonio",
    12 or 1 or 2 => "invierno",
    _ => throw new ApplicationException("Mes incorrecto")
};

//Console.WriteLine(estacion);

// ========================================== BUCLES ============================================

int contador = 1;

/*while(contador <= 10)
{
    Console.WriteLine(contador);
    contador++;
};*/

var balance = 200m;
var interes = 1.07m;
var contadorInteres = 1;

while(contadorInteres <= 20)
{
    balance *= interes;
    contadorInteres++;
}
//Console.WriteLine(balance);

/*do
{
    Console.WriteLine(contador);
    contador++;
} while (contador > 10);*/


/*for(int i = 1; i <=10 ; i++)
{
    Console.WriteLine(i);
}*/

/*var nombre = "Jorge";
foreach (var letra in nombre)
{
    Console.WriteLine(letra);
}*/

//  Break and Continue


/*for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}
Console.WriteLine("Fin");*/

while(true) {
    Console.WriteLine("Bienvenida a la calculadora de C#");
    Console.Write("Escriba el primer numero");
    var entrada = Console.ReadLine();
    if (entrada is null)
    {
        Console.WriteLine("Error: Vuele a comenzar");
        continue;
    }
    var num1 = decimal.Parse(entrada);

    Console.Write("Escriba el segundo numero");
    entrada = Console.ReadLine();

    if (entrada is null)
    {
        Console.WriteLine("Error: Vuele a comenzar");
        continue;
    }

    var num2 = decimal.Parse(entrada);

    Console.WriteLine($"el resultado de sumar {num1} y {num2} es {num1 + num2}");

    Console.Write("Desea sumar otra vez? (y/n)");
    entrada = Console.ReadLine();

    if (entrada != "y")
    {
        break;
    }
}

Console.WriteLine("Adios!");


// ========================================== FIN BUCLES ============================================
