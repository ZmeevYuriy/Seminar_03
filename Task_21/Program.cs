int NameNumber(string massege)
{
    Console.WriteLine(massege);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int [] WriteNumber()
{
    int x = 0;
    int y = 1;
    int z = 2;
    int [] axis = new int [3];
    axis[x] = NameNumber("Введите значение x");
    axis[y] = NameNumber("Введите значение y");
    axis[z] = NameNumber("Введите значение z");
    return axis;
}

double NumSquare(int [] A, int [] S)
{
    double summa = 0;
    for(int i = 0; i < A.Length; i++)
    {
        summa += Math.Pow(A[i] - S[i], 2);
    }
    Console.WriteLine("Сумма = " + summa);
    return summa;
}

double FindDistance(int [] A, int [] S)
{
    double distance = Math.Sqrt(NumSquare(A, S));
    return distance;
}

int [] A = WriteNumber();
int [] S = WriteNumber();
double distance = FindDistance(A, S);
Console.WriteLine("Получен ответ =" + distance);

