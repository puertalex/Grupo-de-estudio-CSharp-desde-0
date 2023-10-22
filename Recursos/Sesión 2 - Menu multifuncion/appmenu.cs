// Desarrolla un proyecto que muestre en pantalla un menú con las siguientes opciones:
// a) Calcular la edad de una persona
// b) Números pares y primos
// c) Palíndromos
// d) Salir
using System;
using System.Runtime.InteropServices;
// * =========================================================================================
// * =========================================================================================
// ! KaltH
void KaltH()
{
    Console.WriteLine("Menú\nSelecciona la letra para la función que quieras utilizar");
    Console.WriteLine("a) Calcular la edad de una persona");
    Console.WriteLine("b) Números pares y primos");
    Console.WriteLine("c) Palindromos");
    Console.WriteLine("d) Salir");
    var userinput = Console.ReadLine();

    // ! Edad de la persona 
    if (userinput == "a")
    {
        Console.WriteLine("Ingresa tu año de nacimiento");
        int anioNacimiento = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Tienes " + (2023 - anioNacimiento) + " años");
    }

    // ! Pares y primos 
    else if (userinput == "b")
    {
        Console.WriteLine("Hasta que número deseas el cálculo?: ");
        int numMax = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numMax; i++)
        {
            if ((i % 2) == 0)
            {
                Console.WriteLine(i + " Es par");
            }
            else
            {
                Console.WriteLine(i + " Es impar");
            }
        }
    }

    // ! Palíndromos
    else if (userinput == "c")
    {
        var inputPalindromo = Convert.ToString(Console.ReadLine());
        char[] chars = inputPalindromo.ToCharArray();
        Array.Reverse(chars);
        if (Convert.ToString(chars) == inputPalindromo)
        {
            Console.WriteLine(Convert.ToString(chars) + " Es palíndromo");
        }
        else
        {
            Console.WriteLine(Convert.ToString(chars) + " No es un palíndromo");
        }

    }

    // ! Salir 
    else if (userinput == "d")
    {
        Console.WriteLine("Hasta luego...");
    }
}
// * =========================================================================================
// * =========================================================================================



// * =========================================================================================
// * =========================================================================================
// valkubo

void Valkubo()
{
    int age, userYear, option, numberMax;
    

    // menu
    do
        {
            Console.Clear();
            Console.WriteLine("Bienvenido a tu app, multifunción\n");
            Console.WriteLine("\t1. Calcular edad de una persona.\n\t2. numeros pares y primos.\n\t3. palimdromo.\n\t4. salir");
            Console.Write("Elije una opción: ");
            option = Convert.ToInt32(Console.ReadLine());



            switch (option)
            {
                case 1:
                    {
                        Console.Clear();
                        // obtener año
                        Console.Write("Ingrese año de nacimiento: ");
                        userYear = Convert.ToInt32(Console.ReadLine());
                        age = 2023 - userYear;
                        Console.WriteLine("La edad es de : {0}", age);
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    };
                case 2:
                    {
                        Console.Write("Ingrese número maximo: ");
                        numberMax = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < numberMax; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.Clear();
                        Console.Write("Ingrese la palabra u oración: ");
                        string palimdromo = Console.ReadLine().ToLower();
                        palimdromo = palimdromo.Replace(" ", "");
                        string palabraInvertida = "";
                        foreach (char c in palimdromo)
                        {
                            palabraInvertida = c + palabraInvertida;
                        }

                        if (palabraInvertida == palimdromo)
                        {
                            Console.WriteLine("{0}, es un palimdromo", palimdromo);
                        }
                        else
                        {
                            Console.WriteLine("{0}, no es un palimdromo", palimdromo);
                        }
                        Console.WriteLine("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                    }
            }
        } while (option > 0 && option < 4);

}
// * =========================================================================================
// * =========================================================================================
#region Jorlan
// jorlan
void jorlan()
{
    string opcion = "";
    do
    {
        Console.WriteLine("Bienvenido elige una opcion:\n a) Calcular edad \n b) Numeros pares y primos \n c) Palindromo \n d) Salir");
        opcion = Console.ReadLine();
        if (opcion == null)
        {
            Console.WriteLine("Debe elegir una opción");
        }
        else
        {
            switch (opcion)
            {
                case "a":
                    edadPersona();
                    break;
                case "b":
                    numerosPrimosPares();
                    break;
                case "c":
                    validadorPalindromo();
                    break;
            }
        }

    } while (!opcion.Contains('d'));
}

void edadPersona()
{
    int anioNacimiento = 0;
    Console.WriteLine("Ingrese tu anio de nacimiento:");
    anioNacimiento = int.Parse(Console.ReadLine());
    int anio = DateTime.Now.Year;
    Console.WriteLine("Tu edad es: " + (anio - anioNacimiento));
}

void numerosPrimosPares()
{
    Console.WriteLine("Ingrese la cantidad de datos a generar:");
    int cantidad = int.Parse(Console.ReadLine());
    primos(cantidad);
    pares(cantidad);
}

void primos(int cantidad)
{
    Console.WriteLine($"Los {cantidad} primos son:");
    int index = 0;
    int primo = 1;
    while (cantidad != 0)
    {
        if (primo % 2 != 0)
        {
            Console.WriteLine(primo);
            cantidad -= 1;
        }
        primo++;
    }
}

void pares(int cantidad)
{
    Console.WriteLine($"Los {cantidad} pares son:");
    int par = 1;
    while (cantidad != 0)
    {
        if (par % 2 == 0)
        {
            Console.WriteLine(par);
            cantidad -= 1;
        }
        par += 1;
    }
}
void validadorPalindromo()
{
    Console.WriteLine("Ingrese una palabra");
    string palabra = Console.ReadLine();
    string nuevaPalabra = "";
    foreach (char r in palabra.Reverse())
    {
        nuevaPalabra += r;
    }
    if (nuevaPalabra.Equals(palabra))
    {
        Console.WriteLine("es palindromo");
    }
    else
    {
        Console.WriteLine("no es palindromo");
    }
}
#endregion
// * =========================================================================================
// * =========================================================================================

KaltH();
Valkubo();
jorlan();

