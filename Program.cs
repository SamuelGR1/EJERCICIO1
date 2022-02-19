// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingresa tu edad");
byte edad1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Usted no aparente " + edad1 + " años");
Console.WriteLine();

byte no1, no2;
ushort multi;
Console.WriteLine("Ingrese un numero:");
no1 = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Ingrese otro numero:");
no2 = Convert.ToByte(Console.ReadLine());
multi= (ushort)(no1 * no2);
Console.WriteLine("el resultado de la multiplicacione es: " + multi);
Console.WriteLine();

long num1, num2,suma,resta,prod;
Console.WriteLine("Ingrese un numero:");
num1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Ingrese un numero:");
num2 = Convert.ToInt64(Console.ReadLine());
suma = num1 + num2;
resta = num1 - num2;
prod = num1 * num2;
Console.WriteLine("La suma es: " + suma + " la resta es: " + resta + " y el prodcto es: " + prod);
