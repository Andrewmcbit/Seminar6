/*Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.*/

void IsPalindrome(string inputString){
    bool result = true;
    int i = 0;
    while ((result != false) && (i < inputString.Length/2)){
        if (inputString[i] == inputString[inputString.Length - 1 - i]){
            result = true;
        } else {
            result = false;
        }
        i++;
    }
    Console.Write(inputString);
    if (result == true) {
        Console.Write(" => Да");
    } else {
        Console.Write(" => Нет");
    }
    Console.WriteLine();
}

string str = "“aBcD1ef!-";
IsPalindrome(str);
str = "шалаш";
IsPalindrome(str);
str = "5445";
IsPalindrome(str);