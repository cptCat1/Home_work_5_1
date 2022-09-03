//Home_work_5.1------------------------------

//5.1.1--------------------------------------

//Из int в short    // явное приведение
//Из short в int    // неявное приведение
//Из bool в string  // невозможно
//Из double в float // явное приведение
//Из byte в float   // неявное приведение
//Из double в float //явное приведение

//5.1.2--------------------------------------

//byte a = 43;
//int b = a; //ne javnoje privedenie
//ushort c = b; //ne javnoje privedenie
//bool d = true;
//a = d; //невозможное приведение
//byte e = 300; //слишком большое значение
//long[] e1 = 40000203; //массив не может равняться одной цифре
//int f = c; //javnoje privedenie
//int g = e; //в переменной е присвоено невозможное значение
//d = a; //невозможное приведение

//5.1.3--------------------------------------

//byte a = 0b0100; // 4
//byte b = 0b0101; // 5
//byte c = 0b0110; // 6
//byte d = 0b0111; // 7

//5.1.4--------------------------------------

//0b101 == 101 = 1*2(2) + 0*2(1) + 1*2(0) = 4 + 0 + 1 = 5
//0b1111 == 1111 = 1*2(3) + 1*2(2) + 1*2(1) + 1*2(0) = 8 + 4 + 2 + 1 = 15
//0b11111111 == 11111111 = 1*2(7) + 1*2(6) + 1*2(5) + 1*2(4) + 1*2(3) + 1*2(2) + 1*2(1) + 1*2(0) = 128 + 64 + 32 + 16 + 8 + 4 + 2 + 1 = 255

//5.1.5--------------------------------------

//A45B == 10 4 5 11 = 10*16(3) + 4*16(2) + 5*16(1) + 11*16(0) = 40960 + 1024 + 80 + 11 = 42075
//12FF == 1 2 15 15 = 1*16(3) + 2*16(2) + 15*16(1) + 15*16(0) = 4096 + 512 + 240 + 15 + 4863
//FCBE ==16 12 11 15 = 15*16(3) + 12*16(2) + 11*16(1) + 14*16(0) = 61440 + 3072 + 176 + 14 = 64702

//5.1.6--------------------------------------

//45      // byte
//200     // byte
//300     // short
//256     // short
//1000    // short
//- 255   // short
//- 50    // sbyte
//55555   // ushort
//0.34    // float
//70000   // int
//- 60000 // int

//5.1.7--------------------------------------

//int a;                         // 4 byte
//byte a;                        // 1 byte
//bool a;                        // 1 byte
//ushort[] a = new ushort[1000]; // 2 * 1000 = 2000 byte
//float[a] = new float[82349];   // 4 * 82349 = 329396 byte
//int[] a = new int[3405522458]; // 4 * 3405522458 = 13622089832 byte
//char[] a = new char[4444];     // 2 * 4444 = 8888 byte
//bool[] a = new bool[8];        // 1 * 8 = 8 byte

//5.1.8--------------------------------------

//Возраст                              // byte
//Зарплата                             // int
//Количество жителей в квартире        // byte
//Количество учителей в школе          // byte
//Количество учеников в школе          // ushort
//Год рождения                         // ushort
//Вес                                  // byte
//Количество этажей                    // byte
//Возраста всех сотрудников в компании // byte[]
//Номера всех офисов в здании          // ushort[]
//Все размеры обуви (в числах), которые предоставляет магазин. // byte[]
//Зарплаты всех сотрудников в компании // int[]


//Home_work_5.2------------------------------

//5.2.1--------------------------------------

//mnogo woprosow po zapisiam w primerach ot docs.microsoft

/*double x = 90;
double y = Math.Cos(x * Math.PI / 180);
Console.WriteLine(y);

double a = 90;
double b = Math.Sin(a * Math.PI / 180);
Console.WriteLine(b);

double c = 90;
double[] d = Math.SinCos(c * Math.PI / 180);
Console.WriteLine(d[1], d[1]); // ne razobralsa
*/


/*string a = "1 2 3";
a = a.Replace(' ', ',').Replace('1','2');
Console.WriteLine(a); // tyt poniatno
*/

/*String s = new String('a', 3);
Console.WriteLine("The initial string: '{0}'", s);
s = s.Replace('a', 'b').Replace('b', 'c').Replace('c', 'd');
Console.WriteLine("The final string: '{0}'", s);
tut nie pojmu zachem {0} vezde staviat
 */

//5.2.2--------------------------------------

/*double a, b, c;
Console.WriteLine($"Enter b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine($"Enter c:");
c = double.Parse(Console.ReadLine());
Console.WriteLine($"a = {Math.Pow(b, 10) * Math.Pow(c, 3)}");
*/

/////////////

/*double a, b, c;
Console.WriteLine($"Enter b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine($"Enter c:");
c = double.Parse(Console.ReadLine());
a = Math.Pow(c, 2) - Math.Pow(b, 2);
a = Math.Sqrt(a);
Console.WriteLine($"a = {a}"); // esli 3 i 2 to otvet ne chislo. Pochemu?
*/

/////////////

//Primer 3

//5.2.3--------------------------------------

/*double r, line, sqrt;
Console.WriteLine($"Enter radius:");
r = double.Parse(Console.ReadLine());
Console.WriteLine($"line = {line = r * 2 * Math.PI}");
Console.WriteLine($"Sqrt = {sqrt = Math.PI * Math.Pow(r, 2)}");
*/

///////////////

/*double r, sqrt, v;
Console.WriteLine($"Enter radius:");
r = double.Parse(Console.ReadLine());
Console.WriteLine($"Sqrt = {sqrt = 4 * Math.PI * Math.Pow(r, 2)}");
Console.WriteLine($"v = {v = 4 * Math.PI * Math.Pow(r, 3) / 3}");
*/

///////////////

/*double h, r, v;
Console.WriteLine($"Enter height:");
h = double.Parse(Console.ReadLine());
Console.WriteLine($"Enter radius:");
r = double.Parse(Console.ReadLine());
Console.WriteLine($"v = {v = Math.PI * h * Math.Pow(r, 2)}");
*/

//5.2.4--------------------------------------

Console.WriteLine("Enter your email:");
string mail = Console.ReadLine();
char symb1 = '@';
char symb2 = '.';
Console.Clear();

bool a = false;
while (a == false)
{
    a = mail.Contains(symb1);
    Console.WriteLine("Please, enter a valid email address: ");
    mail = Console.ReadLine();

    while (a == false) 
    {
        a = mail.Contains(symb2);
        Console.WriteLine("Please, enter a valid email address!: ");
        mail = Console.ReadLine();
    }
}

string email = mail.Trim();
Console.Clear();
Console.WriteLine($"Thank you! Your email: {email}");


//5.2.5--------------------------------------

//for (int i = 0; i <= 19; i++)
//{
//    Console.SetCursorPosition(i, 0);
//    Console.Write('*');
//}
//for (int i = 0; i <= 19; i++)
//{
//    Console.SetCursorPosition(0, i);
//    Console.Write('*');
//}
//for (int i = 0; i <= 19; i++)
//{
//    Console.SetCursorPosition(i, 19);
//    Console.Write('*');
//}
//for (int i = 19; i >= 0; i--)
//{
//    Console.SetCursorPosition(19, i);
//    Console.Write('*');
//}
