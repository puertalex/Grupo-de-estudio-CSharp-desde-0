using System;
class HelloWorld
{
    static void Main(string[] args)
    {
        // ! Tipos de datos y consola
        // * imprimir en consola
        Console.WriteLine("¡Hello C#!\n");

        string myString = "Esto es un String\n";
        Console.WriteLine(myString);

        myString = "Ahora es un String distinto\n";
        Console.WriteLine(myString);

        // * Suma y declaración de enteros
        int num1 = 10;
        int num2 = 7;
        Console.WriteLine(num1 + num2);
        // * Suma y declaración de flotantes
        float float1 = 6.5f;
        float float2 = 2.5f;
        Console.WriteLine(float1 - float2);
        // * Suma de distintos tipos
        int numInt = 10;
        float numFloat = 5.5f;
        double numDouble = 4.5;
        Console.WriteLine(numInt + numFloat + numDouble);
        // * Booleanos
        bool myBool = true;
        Console.WriteLine(myBool);
        // * Añadir variables dentro de un string 
        string myText = "añadida";
        Console.WriteLine($"La variable myText ha sido {myText}");
        // * Declaración de constantes
        // ? debes declarar el contenido de las constantes (Aquí se declaró 'string')
        const string MyConst = "Mi constante";
        Console.WriteLine(MyConst);

        Console.WriteLine("\n \n");

        // ! Listas
        // * Arrays
        var myArray = new string[] {"Brais", "Moure", "MoureDev"};
        Console.WriteLine(myArray[0], myArray[1]);
        
        // * Tuples
        var myTuple = ("Brais", "Moure", "MoureDev");
        Console.WriteLine(myTuple);

        // ! Bucles
        // * Ciclo for
        for (int index = 0; index < 10; index++)
        {
            Console.WriteLine(index);
        }

        int myInt = 10;
        bool myBool2 = true;

        if (myInt == 10)
        {
            Console.WriteLine("Es igual a 10");
        }
        else if (myInt == 11)
        {
            Console.WriteLine("Es igual a 11");
        }
        else if (myInt == 11 && myBool2 == true)
        {
            Console.WriteLine("Es igual a 11 y es True");
        }
        if (myInt == 10 || myBool2 == false)
        {
            Console.WriteLine("Es igual a 10 o es falso");
        }

        // ! Funciones
        static int myFunction(int param)
        {
            return 10 + param;
        }

        Console.WriteLine(myFunction(5));

    }
}
