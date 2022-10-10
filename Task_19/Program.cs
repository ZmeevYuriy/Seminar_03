string GetText(string num)
{
    string result = string.Empty;
    int length = num.Length;
    int index = 0;
    int z = length;
    for (int i = 0; (num[i] == num[z - 1] && (i < z - 1)); i++)
    {
        z = z - 1;
        index = i;
    }
    if (index == (length / 2) - 1) result = "да ";
    else result = "нет";
    return result;
}
int InputNumbers(string message)
{
    Console.WriteLine(message);
    string number = Console.ReadLine();
    int a = int.Parse(number);
    return a;
}

int n = InputNumbers("Введите пятизначное число: ");
    if (n > 10000 && n < 100000)
    {
        string stroka = Convert.ToString(n);
        Console.Write(stroka + " -> ");
        Console.WriteLine(GetText(stroka));
        n++;
    }
    else Console.WriteLine("Введенное число не является пятизначным");