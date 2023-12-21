int InputNumber(string text) 
{ 
    do 
    { 
        Console.Write(text); 
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0) 
             
            return index; 
 
        else 
            Console.WriteLine("Некорректный ввод. Введите положительное целое число."); 
    } while (true); 
} 
 
int Ackerman(int m, int n) 
{ 
    if ((m == 0) && (n == 0)) 
    { 
        return 1; 
    } 
 
    else 
    { 
        if (m == 0) { return n + 1; } 
 
        else if (n == 0) { return Ackerman(m - 1, 1); } 
 
        else { return Ackerman(m - 1, Ackerman(m, (n - 1))); } 
    } 
} 
 
int m = InputNumber("Введите число m: "); 
int n = InputNumber("Введите число n: "); 
int result = Ackerman(m, n); 
 
Console.WriteLine($"m = {m}, n = {n} -> A({m},{n}) = {result}");
