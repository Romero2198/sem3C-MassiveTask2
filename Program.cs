double X1 = InputInt("Введите X первой точки: ");
double Y1 = InputInt("Введите Y первой точки: ");
double Z1 = InputInt("Введите Z первой точки: ");
double X2 = InputInt("Введите X второй точки: ");
double Y2 = InputInt("Введите Y второй точки: ");
double Z2 = InputInt("Введите Z второй точки: ");
double distance = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1) + (Z2 - Z1)*(Z2 - Z1));
Console.WriteLine($"A ({X1},{Y1},{Z1}); B({X2},{Y2},{Z2}) -> {distance}");
int InputInt(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}