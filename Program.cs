
int numero, unidades, dezenas, centenas;

Console.WriteLine("--- Decomposição Decimal ---\n"); Thread.Sleep(2000);

Console.WriteLine("Digite Algum Numero.."); 
numero = int.Parse(Console.ReadLine()!);

unidades = numero % 10;
dezenas = (numero / 10) % 10;
centenas = (numero / 100) % 10;

Thread.Sleep(2000);

Console.WriteLine("O número " + numero + " é composto por:"); Thread.Sleep(1000);
Console.WriteLine(+ unidades + " unidade"); Thread.Sleep(1000);
Console.WriteLine(+ dezenas + " dezena"); Thread.Sleep(1000);
Console.WriteLine(+ centenas + " centena"); Thread.Sleep(1000);


