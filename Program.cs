/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Enter number:");
string numberStr = Console.ReadLine() ?? "";

if(int.TryParse(numberStr, out int number)){
  int mod = number % 2;
  if(mod != 0){
    Console.WriteLine($"No, {number} is odd number");
  }else{
    Console.WriteLine($"Yes, {number} is even number");
  }
}else{
  Console.WriteLine($"invalid input");
}