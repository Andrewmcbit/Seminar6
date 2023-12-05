/*Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.*/ 

string GetStringFromChar(char[,] inputArray){
    string outputString = "";
    for (int i = 0; i < inputArray.GetLength(0); i++){
        for (int j = 0; j < inputArray.GetLength(1); j++){
            outputString += inputArray[i,j];
        }
    }
    return outputString;
}

char[,] array = {{'a','b','c','d'},{'e','f','g','h'}};
string str = GetStringFromChar(array);
Console.Write(str);