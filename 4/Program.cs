/*Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
Сформировать строку, в которой слова расположены в обратном порядке. 
В полученной строке слова должны быть также разделены пробелами.*/ 

void ReverseString(string input){
    string result = "";
    string temp = "";
    for (int i = 0; i < input.Length; i++){
        if (input[i] != ' '){
            temp += input[i]; 
        } else {
            result = String.Concat(temp,' ',result);
            if (input[i] == ' '){
                temp = "";
            }
        }
    }
    result = String.Concat(temp,' ',result);
    Console.Write(result);
}

string str = "Hello my world 1111";
ReverseString(str);