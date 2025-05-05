// See https://aka.ms/new-console-template for more information
using DSA_practice;

Console.WriteLine("Hello, World!");



coadfunction coadfunction = new coadfunction();

List<int> arguments = new List<int>() { 1,1,1,1,2,2,3,4,5,6,7};

//Find the duplicate number in an array of integers.

List<int> outpi = coadfunction.dublicatearray(arguments);
//foreach(int i in outpi)
//{
//  //  Console.Write(i);

//    Console.WriteLine(i);
//}


//Merge two sorted arrays into a single sorted array.

int[] a1 = { 1, 5, 10, 11 };
int[] a2 = { 0, 4, 7, 8 };

int[] ot = coadfunction.addsorerarra(a1, a2);
foreach(int a in ot)
{
    Console.WriteLine(a);
}



Console.ReadLine();
