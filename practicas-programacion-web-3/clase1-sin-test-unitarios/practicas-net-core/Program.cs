//Practica 0: probando visual studio + concatenacion y tipos de variables

//TIPOS DE VARIABLES
int anio = Convert.ToInt16("2026"); 
double doble = 2.5;
string nombre = "Jesi";
decimal decimales = 2.07M;
float flotante = 8.0f;
bool valor = true;
char letra = 'A';
String nombres = "Jesica Belen";
Decimal dec = 28.6M;
Boolean valor2 = false;
Double vDouble = 8.8;
Char structLetra = 'z';

Console.WriteLine("Programacion web 3 "+ anio);

Console.WriteLine("Taller Web 2 {0}", anio);

int cuatri = 1;

Console.WriteLine("Programacion Web 3 {0}, Cuatrimestre {1}", anio,cuatri);

Console.WriteLine(nombres + " {0} {1} {2}", anio, doble, decimales);

Console.WriteLine("{4} {3} {2} {1} {0}", letra, structLetra, dec, valor2, vDouble);

//TIPOS DE OPERADORES

int operando1 = 10;
int operando2 = 11;
int operando3 = 2;

//operadores aritmeticos
var suma =  operando1 + operando2; 
var resto = operando2 % operando1;


Console.WriteLine("{0} + {1} = {2}", operando1, operando2, suma);

Console.WriteLine("El resto de la division {0}/{1} = {2}", operando2, operando1, resto);

//operadores de asignacion
operando2 -= operando3;
operando1 %= operando3;

Console.WriteLine("resultado de operador resta y asignacion {0}", operando2);
Console.WriteLine("resultado de operador modulo y asignacion {0}", operando1);

//operadores de comparacion y relaciones (como debuguear en vs)
int valorA = 10;
int valorB = 3;

var data = valorB < valorA;

Console.WriteLine("Resultado de data {0}", data);

//operadores de igualdad






