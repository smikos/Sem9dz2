int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int func (int a,int b =0)
{
 if (a>b)
 {
    return 0;
 }

 return a+func(a+1,b);
}
int a = ReadInt("введите число");
int b = ReadInt("введите число");

System.Console.WriteLine(func (a,b));