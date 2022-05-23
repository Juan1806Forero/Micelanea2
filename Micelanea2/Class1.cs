using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int MenuPrin;
            int opcion1;
            int opcion2;
            int opcion3;

            Console.WriteLine("Menu Micelanea: " + "\n1.Operadores" + "\n2.Condicionales" + "\n3.Ciclos" + "\n4.Salir del Programa");
            MenuPrin = int.Parse(Console.ReadLine());



            switch (MenuPrin)
            {
                case 1:
                    Console.WriteLine("Menu de Operadores: \n1.Area Triangulo" + "\n2.Suma 2 Enteros" + "\n3.Elevacion al Cuadrado" + "\n4.Conversion Euros a Dolares" + "\n5.Valor area y perimetro (Cuadrado)" + "\n6.Area y Volumen (Cilindro)" + "\n7.Area de una circunferencia" + "\n8.Promedio de 3 Num.");
                    opcion1 = int.Parse(Console.ReadLine());
                    switch (opcion1)
                    {
                        case 1:
                            try
                            {
                                Console.WriteLine("Ingrese la base : ");
                                numero1 = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese la altura : ");
                                numero2 = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }

                            double AreaTriangulo;
                            //Console.WriteLine("Ingrese la base : ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            //Console.WriteLine("Ingrese la altura : ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            AreaTriangulo = numero1 * numero2 / 2;
                            Console.WriteLine("El resultado del area es:" + AreaTriangulo);
                            break;

                        case 2:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int Suma;
                            Console.WriteLine("Escriba dos numeros enteros: ");
                            Console.WriteLine("Ingrese 1er entero : ");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese 2do entero: ");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Suma = numero1 + numero2;
                            Console.WriteLine("El resultado del area es:" + Suma);
                            break;

                        case 3:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int numero;
                            Console.WriteLine("Ingrese el numero : ");
                            numero = Convert.ToInt32(Console.ReadLine());
                            double elevadoAlCuadrado = Math.Pow(numero, 2); // Elevarlo a la potencia 2
                            Console.WriteLine(string.Format("{0} elevado al cuadrado es {1}", numero, elevadoAlCuadrado));
                            break;

                        case 4:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            double euro, resultado;
                            Console.WriteLine("Ingrese la cantidad de euros : ");
                            euro = double.Parse(Console.ReadLine());
                            resultado = euro * 1.06;
                            Console.WriteLine("El resultado de la conversion: " + resultado);
                            break;

                        case 5:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            float lado, p, a;
                            Console.WriteLine("Ingrese el lado del cuadrado: ");
                            lado = float.Parse(Console.ReadLine());
                            p = lado * 4;
                            a = lado * lado;
                            Console.WriteLine("El perimetro es :" + p);
                            Console.WriteLine("El area es :" + a);
                            break;

                        case 6:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            double altura, area, radio, volumen;
                            Console.Write("Ingresa el valor de altura: ");
                            altura = double.Parse(Console.ReadLine());
                            Console.Write("Ingresa el valor de radio: ");
                            radio = double.Parse(Console.ReadLine());
                            volumen = Math.PI * radio * radio * altura;
                            area = 2.0 * Math.PI * radio * (radio + altura);
                            Console.WriteLine("Valor de area: " + area);
                            Console.WriteLine("Valor de volumen: " + volumen);
                            break;

                        case 7:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            Console.WriteLine("Ingrese el numero del Diametro");
                            numero1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El radio es:" + CircunferenciaEnteros(numero1));
                            static string CircunferenciaEnteros(int num1)
                            {
                                return Convert.ToString(num1 / 2);
                            }
                            Console.WriteLine("La longitud es:" + LongitudEnteros(numero1));
                            static string LongitudEnteros(int num1)
                            {
                                return Convert.ToString((2 * 3.14) * num1);
                            }
                            Console.WriteLine("Ingrese el numero del area");
                            numero2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("El area es:" + AreaCirEnteros(numero1, numero2));
                            static string AreaCirEnteros(int num1, int num2)
                            {
                                return Convert.ToString(3.14 * (2 * num2));
                            }
                            break;

                        case 8:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            double C1, C2, C3, Pro;
                            Console.Write("Ingresa 1er valor: ");
                            C1 = double.Parse(Console.ReadLine());
                            Console.Write("Ingresa 2do valor: ");
                            C2 = double.Parse(Console.ReadLine());
                            Console.Write("Ingresa 3er valor: ");
                            C3 = double.Parse(Console.ReadLine());
                            Pro = (C1 + C2 + C3) / 3;
                            Console.WriteLine("El promedio total es:" + Pro);
                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine("Menu Condicionales: \n1.Positivo o Negativo" + "\n2.Mayor y Menor" + "\n3.3 Numeros enteros (Mayor y Menor)" + "\n4.Suma o Resta entre A y B" + "\n5.Cociente entre A y B" + "\n6.Suma o Multiplicacion entre A y B" + "\n7.Año bisiesto o no ");
                    opcion2 = int.Parse(Console.ReadLine());
                    switch (opcion2)
                    {
                        case 1:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int num;
                            Console.WriteLine("Ingrese el numero: ");
                            num = int.Parse(Console.ReadLine());
                            if (num > 0)
                            {
                                Console.WriteLine("El numero ingresado es positivo");
                            }
                            if (num < 0)
                            {
                                Console.WriteLine("El numero ingresado es negativo");
                            }
                            Console.ReadKey();
                            break;

                        case 2:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int numb1, numb2;
                            Console.WriteLine("Digite el 1er numero");
                            numb1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el 2do numero");
                            numb2 = int.Parse(Console.ReadLine());
                            if (numb1 > numb2)
                            {
                                Console.WriteLine(numb1 + " Es mayor que " + numb2);
                            }
                            else
                            {
                                Console.WriteLine(numb2 + " Es mayor que " + numb1);
                            }

                            break;

                        case 3:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int A, B, C, MEN, MAX;
                            Console.WriteLine("Digite el 1er numero");
                            A = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el 2do numero");
                            B = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el 3er numero");
                            C = int.Parse(Console.ReadLine());
                            MAX = A;
                            if (B > MAX)
                                MAX = B;
                            if (C > MAX)
                                MAX = C;
                            Console.WriteLine("El numero mayor es:" + MAX);
                            MEN = A;
                            if (B < MEN)
                                MEN = B;
                            if (C < MEN)
                                MEN = C;
                            Console.WriteLine("El numero menor es:" + MEN);
                            break;

                        case 4:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int a1, b1, res, sum;
                            Console.WriteLine("Digite el 1er numero");
                            a1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite el 2do numero");
                            b1 = int.Parse(Console.ReadLine());
                            if (a1 < b1)
                            {
                                sum = a1 + b1;
                                Console.WriteLine("A es menor que B el resultado de la suma es :" + sum);
                            }
                            else
                            {
                                if (a1 > b1)
                                {
                                    res = a1 - b1;
                                    Console.WriteLine("A es mayor que B \nEl resultado de la resta es :" + res);
                                }

                            }
                            break;

                        case 5:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int op1, op2, Total;
                            Console.WriteLine("Ingrese el dividendo :");
                            op1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese le divisor :");
                            op2 = int.Parse(Console.ReadLine());

                            if (op1 > 0 && op2 > 0)
                            {
                                Total = op1 / op2;
                                Console.WriteLine("El cociente entre entre A y B es :" + Total);
                            }
                            else
                            {
                                if (op1 <= 0 || op2 <= 0)
                                {
                                    Console.WriteLine("la division no es posible");
                                }
                            }
                            break;

                        case 6:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int neg, pos, Res;
                            Res = 0;
                            Console.WriteLine("Ingrese 1er numero");
                            neg = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el 2do numero");
                            pos = int.Parse(Console.ReadLine());

                            if (neg < 0)
                            {
                                Res = neg + pos;
                                Console.WriteLine("El numero es negativo \n El resultado de la suma :" + Res);
                            }
                            else
                            {
                                if (neg > 0)
                                    Res = neg * pos;
                                Console.WriteLine("El numero es positivo \n El resultado de la multiplacion :" + Res);

                            }
                            break;

                        case 7:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int año;
                            Console.WriteLine("Ingrese el año :");
                            año = Convert.ToInt32(Console.ReadLine());
                            bool esBisiesto = DateTime.IsLeapYear(año);
                            Console.WriteLine("¿El año es bisiesto? : " + esBisiesto);
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Menu Ciclos: \n1.Multiplos de 3 entre 1 y 100" + "\n2.Impares entre 0 y 100" + "\n3.Pares entre 1 a 100" + "\n4.Cuadrados Numeros del 1 al 30" + "\n5.Suma de cuadrados" + "\n6.Secuencia Ascendente" + "\n7.Suma de numeros");
                    opcion3 = int.Parse(Console.ReadLine());
                    switch (opcion3)
                    {
                        case 1:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int mul3 = 0;
                            int contMul = 0;
                            do
                            {
                                Console.WriteLine("Los multiplos son: " + mul3);
                                mul3 = mul3 + 3;
                                contMul = contMul + 1;
                            }
                            while (mul3 < 100);
                            Console.WriteLine("El total de Multiplos son: " + contMul);
                            break;

                        case 2:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int i;
                            int impar = 0;
                            for (i = 1; i <= 100; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    Console.WriteLine(i);
                                    impar++;
                                }
                            }
                            break;

                        case 3:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int p;
                            for (p = 2; p <= 100; p += 2)
                            {
                                Console.WriteLine(p);
                            }
                            break;
                        case 4:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente, pedi un numeros no letras, ¡guevon!");
                            }
                            int numerod = 0;
                            for (numerod = 1; numerod <= 30; numerod++)
                            {
                                double elevadoAlCuadrado = Math.Pow(numerod, 2);
                                Console.WriteLine("Proceso " + numerod + "^2 = " + elevadoAlCuadrado);

                            }
                            break;

                            break;
                        case 5:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int numero, suma;
                            suma = 0;
                            for (numero = 1; numero <= 100; numero++)
                            {
                                Console.WriteLine("Proceso " + numero);
                                suma = numero * numero;
                            }
                            Console.WriteLine("Valor de la suma : " + suma);
                            break;
                        case 6:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int num1, num2, x;
                            Console.WriteLine("Digite el primer numero: ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite el segundo numero: ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            for (x = num1 + 1; x < num2; x++)
                            {
                                Console.WriteLine("Los numeros comprendidos entre " + num1 + " y " + num2 + " son :");
                                Console.WriteLine(x);
                            }
                            break;
                        case 7:
                            try
                            {
                                opcion2 = int.Parse(Console.ReadLine());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Sea inteligente pedi un numero no una letras ¡guevon!");
                            }
                            int sum1, cant, valor;
                            string linea;
                            sum1 = 0;
                            cant = 0;
                            do
                            {
                                Console.WriteLine("Ingrese un valor (0 para finalizar) :");
                                linea = Console.ReadLine();
                                valor = int.Parse(linea);
                                if (valor != 0)
                                {
                                    sum1 = sum1 + valor;
                                    cant++;

                                }
                                else
                                {
                                    Console.WriteLine("No se ingresan mas valores");
                                }
                            } while (valor != 0);
                            Console.WriteLine("La suma total es :" + sum1);
                            break;
                    }
                    break;

                case 4:
                    Environment.Exit(99);
                    break;
            }
        }
    }
}

