//строки
//неизменяемые string
//using System.Text;

//string s1 = "My name is Masha";
//string s2 = new String('a', 6);
//string s3 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' });
//string s4 = new string(new char[] { 'h', 'e', 'l', 'l', 'o' }, 1, 2);
//Console.WriteLine(s1);
//Console.WriteLine(s2);
//Console.WriteLine(s3);
//Console.WriteLine(s4);
//Console.WriteLine(s1[8]);
//s1[8] = 'p';
//s1 = s1.Remove(8, 1);
//s1 = s1.Insert(8, "p");
//Console.WriteLine(s1);
//Console.WriteLine(s1.Length);
//изменяемые StringBuilder
//StringBuilder  sb1 = new StringBuilder();
//Console.WriteLine(sb1.Length);
//Console.WriteLine(sb1.Capacity);
//sb1.Append("Hello world and Masha");
//Console.WriteLine(sb1.Length);
//Console.WriteLine(sb1.Capacity);
//sb1[10] = 'y';
//Console.WriteLine(sb1);
//sb1.Append("super");
//Console.WriteLine(sb1);
//Console.Write("Введите строку:");
//string st=Console.ReadLine();
//char[] s = st.ToCharArray();
//Array.Reverse(s);
//st = new string(s);
//Console.WriteLine(st);
//using System.Text;

//string st = "яблоко";
//string st1= st.Substring(1,4);
//Console.WriteLine(st1);
//string st2 = st.Substring(3);
//Console.WriteLine(st2);
//StringBuilder sb = new StringBuilder();
//string s1 = "вирус";
//s1=s1.Replace("вир","фок");
//Console.WriteLine(s1);

//Регулярные выражения
using System.Text.RegularExpressions;

string pattern = @"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+";
string[] data=new string[]
{
    "tupica@mail.ru",
    "soroka@gmail.com",
    "pavliy@super.org",
    "masha.kbk.ru",
    "login#mail.ru"
};
for (int i = 0; i < data.Length; i++)
{
    if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
    {
        Console.WriteLine(data[i]);
    }
}