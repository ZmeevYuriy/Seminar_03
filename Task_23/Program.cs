Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter < length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArray(int[] point)
{
  int count = point.Length;
  int index = 0;
  while(index < count)
  {
    Console.Write(point[index]+ ",");
    index++;
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);


//Извените но я не понял как в ответе убрать последнюю запятую.
//Прошу если вас не затруднит объяснить, заранее спасибо!