Console.Clear();
Console.WriteLine("Введите число и получите числа от 1 до введенного числа в квадрате: ");
int a = Convert.ToInt32(Console.ReadLine());

WriteA(a);

void WriteA(int num){
	int i = 1;
	while(i <= num){
		Console.WriteLine($"|{i} | {i*i*i,2}|");
		i++;
	}
}