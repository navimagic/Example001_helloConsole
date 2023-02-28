Console.Clear();
Console.WriteLine("Введите любое трехзначное число");
int n = Convert.ToInt32(Console.ReadLine());
if (n <= 99 || n >= 1000)
    {
        Console.WriteLine("Ошибка. Вы ввели " + n + ". Введите трехзначное число.");
        
        return;}

int result = n / 10 % 10;
Console.WriteLine("Вторая цифра трехзначного числа: " + result);