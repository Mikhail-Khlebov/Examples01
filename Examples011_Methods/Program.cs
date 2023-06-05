// // Виды методов:

// // Вид 1
// void Method1() // Метод
// {
//     Console.WriteLine("...."); // Тело метода.
// }
// // Method1(); - Как вызываются  методы, вызов метода без () то будет ошибка


// // Вид2
// void Method2(string msg) // Метод может принимать но не возвращать
// //ключслово-индеФЕКАТОР-(аргументы)
// {
//     Console.WriteLine(msg);  
// }
// // Method2("текст сообщения");
// // Method2("msg: текст сообщения"); - аргументы именнованые , это нужно когда методы принимабют какое-то кол-во аргументов
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //++ - увелечения счетчика на ед назыв инкрементом, а у меньтшение декриментом

//     }
// }
// Method21(msg: "Text", count: 4);
// // Method21(count: 4, msg: "Text");
// // зацыкливание програмы убирает ctrl+c


// Вид3 - Методы что-то возвращаю но не принимают
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);


// Вид4 - Методы что-то принимают и что-то возвращают
// string Method4(int count, string Text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + Text;
//         i ++;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);
// Вид 4.2 for
// string Method4(int count, string Text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i ++)
//     {
//         result = result + Text;
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 0; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     // Console.WriteLine();
}
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?
Console.Clear();
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля." 
            + "Вы так красноречивы. Вы дадите мне чаю?";
string Replace(String text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for ( int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
}