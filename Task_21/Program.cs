Console.Clear();
Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z ");
int z2 = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));

Console.WriteLine(Math.Round(result,2));
