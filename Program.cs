string[] mass;
Console.WriteLine("Введите символы через запятую");
string stroka = Console.ReadLine();
mass = stroka.Split(',');
var result = new string[mass.Length]; 
var i = 0;
foreach (var elem in mass )
{
    if (elem.Length <= 3)
    {
        result[i] = elem;
        i++;
    } 
}
Console.Write(string.Join(", ", result, 0, i));

