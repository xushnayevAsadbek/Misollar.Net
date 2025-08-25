// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// 1-misol 
/* Console.Write("Son kiriting:");
int son = int.Parse(Console.ReadLine());
int Qiymat;
if (son > 10)
{
    Qiymat = son + 3;
}
else if (son < 10){
    Qiymat = son * 2;
}
else{
    Qiymat = 22;
}

Console.WriteLine("Qiymat: " + Qiymat);
*/

// 2-misol 3-misol

/*
 * int son = 16;
Console.WriteLine(son % 3); 
*/

// 4-misol 

/*
Console.Write("Sonni kiriting:");
int son= int.Parse(Console.ReadLine());
if (son % 2 == 0)
{
    Console.WriteLine("Juft son");
}
else
{
    Console.WriteLine("Toq son");
}
*/

//5-misol 
/*
 Console.Write("a sonni kiriting:");
int a = int.Parse(Console.ReadLine());
Console.Write("b sonni kiriting:");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("a soni katta");
}
else if (a < b)
{
    Console.WriteLine("b soni katta");
}
else
{
    Console.WriteLine("Sonlar teng");
}
*/

// 6-misol Son yasash

Console.Write("a sonni kiriting:");
int a = int.Parse(Console.ReadLine());
Console.Write("b sonni kiriting:");
int b = int.Parse(Console.ReadLine()); 
Console.Write("c sonni kiriting:");
int c = int.Parse(Console.ReadLine());
if(a>0 && b>0 && c > 0)
{
    Console.WriteLine(a*100 +   b*10 + c);
}
else
{
    Console.WriteLine(0);
}


