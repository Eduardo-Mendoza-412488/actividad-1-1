// See https://aka.ms/new-console-template for more information
using Problema_1._1_ProgII.Clases;
using Problema_1._1_ProgII.Interfaces;

Console.WriteLine("Hello, World!");

var pila = new Pilas(10);
var cola = new Colas(5);

//Prueba con Cola
Console.WriteLine("-----Prueba con Cola FIFO");


//Comprobar si esta vacia
Console.WriteLine("la cola esta vacia");

//añadir elementos

Console.WriteLine("\n Añaniendo elementos a la Cola");

cola.Añadir(1);
cola.Añadir(2);
cola.Añadir(3);

// MOstrar elementos
cola.mostrarElementos();

//mostrar primer elemento
Console.WriteLine("¨\n extrayendo elementos: "+ pila.Primero());




//ColeccionAbstracta[] array = { pila, cola };







//pila.Añadir(1);
//pila.Añadir(4);
//pila.Añadir(4);
//pila.Añadir(4);
//pila.Longitud();
//int x = pila.Longitud();


//Console.WriteLine(pila.ToString() +"\n Longitud de array"+ x);
//Console.WriteLine();
//Console.ReadLine();

