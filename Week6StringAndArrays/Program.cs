string hello = " we are the champions!";

int stringLenght = hello.Length;
//string trimmedString = hello.Trim();

hello = hello.Trim();
char firstLetter = hello[0];
Console.WriteLine(firstLetter);
hello = hello.Replace(hello[0], 'W'); 

firstLetter = hello[0];
Console.WriteLine(firstLetter); //=H
Console.WriteLine(hello);