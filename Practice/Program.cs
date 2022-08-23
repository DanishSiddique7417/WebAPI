// See https://aka.ms/new-console-template for more information
using Practice;
using System.Collections;

Console.WriteLine("Hello, World!");
Learning abc = new Learning();
abc.Method1();
string vr = "Danish";
string fistextensionmethod=vr.ConvertWhitespacesToSingleSpaces();
string secondextensionmethod = vr.countt();

Console.WriteLine($"This string without space{fistextensionmethod}");
Console.WriteLine($"This string without space{secondextensionmethod}");

var list = new List<int>(new[] { 1, 2, 4, 7, 9 });
var result = Enumerable.Range(list.FirstOrDefault(), list.LastOrDefault()).Except(list);


foreach(var a in result)
{
    Console.WriteLine(a);
}
int[] arrayint = { 1, 3, 5, 7 };
arrayint[0] = 5;

ArrayList al = new ArrayList();
al.Add(1);
al.Add("danish");

foreach(var d in arrayint)
{
    Console.WriteLine(d);
}
