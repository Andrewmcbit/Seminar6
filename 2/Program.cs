/*Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
Сформируйте строку, в которой все заглавные буквы заменены на строчные.*/ 

void GetLowString (string inputString){
    Console.WriteLine(inputString.ToLower());
    foreach (char c in inputString){
        Console.Write(Char.ToLower(c) + " ");
    }
}

string str = "aBcdeFgH1";
Console.WriteLine(str);
GetLowString(str);