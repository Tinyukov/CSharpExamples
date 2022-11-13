Console.Clear();                       // Очистили консоль
//Console.SetCursorPosition(10, 4);    // Задали установку курсора с отступами от левого и верхнего края
//Console.WriteLine("+");              // Написали "+" в указанном ранее месте

int xa = 40, ya = 1,                   // Указали координаты точек a b c по оси ординат
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;                   // Определяем точку x и для определенности кладем координаты

int count = 0;                       // Старт начала цикла 

while(count < 10)
{
    int what = new Random().Next(0, 3); // Генерируем случайное число what при помощи генератора случайных чисел в диапазоне от 0 до 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count = count + 1;
}

