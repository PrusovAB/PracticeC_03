Console.Clear();
Console.WriteLine("Введите число и проверим полидром ли введеное число: ");
double number = Convert.ToInt32(Console.ReadLine());

double numberTwo = number;


double sum = 0;


while(number > 0){
	double rem = number % 10;
	sum = sum * 10 + rem;
	double sumNumbers = number/10;
	number = Math.Truncate(sumNumbers);
}
if (numberTwo == sum){
	Console.WriteLine($"Введеное число {numberTwo} полидром");
}else{
	Console.WriteLine($"Введеное число {numberTwo} не полидром");
}