bool Palindrom(string number)
{
  int length = number.Length;
  for (int i = 0; i < length-1-i; i++)
  {
    if (number[i] == number[length-1-i]) return true;
  }
  return false;
}

Console.Write("Введите число: ");
string number = Console.ReadLine();
Console.WriteLine(Palindrom(number));





