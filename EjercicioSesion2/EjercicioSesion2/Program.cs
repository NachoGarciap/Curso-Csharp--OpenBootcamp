/*Ejercicio 1
Variables Escribe un programa que reciba datos de una persona y genera un mensaje, usa una variable 
para cada dato y otra para el mensaje. Ej: nombre, apellido, edad, sabe programar, etc.*/
Console.WriteLine("Ejercicio 1: ");

Console.Write("Introduce tu nombre: ");
string nombre =Console.ReadLine();

Console.Write("Introduce tu apellido: ");
string apellido = Console.ReadLine();

Console.Write("Introduce tu edad: ");
int edad = int.Parse (Console.ReadLine());

Console.Write("¿Sabes programar? (si/no): ");
string sabeProgramar = Console.ReadLine();

string mensaje= "Hola, me llamo " + nombre + " " + apellido + ", tengo " + edad + " años y "+sabeProgramar+" se programar";

Console.WriteLine(mensaje);
Console.WriteLine("");

/*Ejercicio 2
Tipos Usando los tipos de variables más adecuados, describe los objetos siguientes:

Coche: puertas, ruedas, marca, ITV vigente

Mesa: peso, largo, material, color

Nota: puedes escribir estos datos por consola si prefieres verlos. 
La idea del ejercicio es almacenar los datos en los tipos más adecuados.*/
Console.WriteLine("Ejercicio 2: ");

//Coche
int puertas = 4;
int ruedas = 4;
string marca = "Renault";
bool itvVigente = true;//true = si, false = no

Console.WriteLine("Coche:");
Console.WriteLine("Puertas: " + puertas);
Console.WriteLine("Ruedas: " + ruedas);
Console.WriteLine("Marca: " + marca);
Console.WriteLine("ITV Vigente: " + itvVigente);

Console.WriteLine("");

//Mesa
double peso = 15.50;
int largo = 200;
string material = "Madera";
string color = "Verde";

Console.WriteLine("Mesa:");
Console.WriteLine("Peso: " + peso + " kilos");
Console.WriteLine("Largo: " + largo + " centimetros");
Console.WriteLine("Material: " + material);
Console.WriteLine("Color: " + color);

Console.WriteLine("");



/*Ejercicio 3
Operadores Determina los operadores para verificar las siguientes condiciones:

Un número es mayor o igual a 18

Un char es ‘a’

Se cumplen dos conciones a la vez (ambas verdaderas)

Se cumple una de dos condiciones a la vez (una true y otra false)

Nota: puedes escribir estos datos por consola si prefieres verlos. La idea del ejercicio es 
almacenar los datos en los tipos más adecuados.*/
Console.WriteLine("Ejercicio 3: ");

Console.WriteLine("Introduce un numero: ");    
int numero = int.Parse (Console.ReadLine());
bool mayorIgual = numero >= 18;//true = si, false =no
Console.WriteLine("¿Es el numero "+numero+" es mayor o igual a 18? " + mayorIgual);
Console.WriteLine("");

char letra = 'a';
bool letraA = letra == 'a';//true = si, false =no
Console.WriteLine("¿Es la letra 'a'? " + letraA);

Console.WriteLine("");
int num1 = 10;
int num2 = 5;
bool ambasVerdaderas = num1 > 5 && num2 < 7;
Console.WriteLine("¿Se cumplen ambas condiciones? " + ambasVerdaderas);

Console.WriteLine("");
int numero1 = 10;
int numero2 = 5;
bool verdaderoFalso = numero1 > 5 || numero2 < 3;
Console.WriteLine("¿Se cumplen alguna de las dos condiciones? " + verdaderoFalso);