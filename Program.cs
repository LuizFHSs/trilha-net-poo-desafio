using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
string numero;
string modelo;
string imei;
int memoria;

Console.WriteLine("Informe as especificações de seu smartphone");
Console.WriteLine("Número do seu smartphone:");
numero = Console.ReadLine();
Console.WriteLine("Modelo do seu smartphone:");
modelo = Console.ReadLine();
Console.WriteLine("Imei do seu smartphone:");
imei = Console.ReadLine();
Console.WriteLine("Memória do seu smartphone:");
memoria = Convert.ToInt32(Console.ReadLine());

Smartphone nokia = new Nokia(numero, modelo, imei, memoria);
Console.WriteLine($"Número do smartphone Nokia: {nokia.Numero}");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("-----------------------------------");

Console.WriteLine("Informe as especificações de seu smartphone");
Console.WriteLine("Número do seu smartphone:");
numero = Console.ReadLine();
Console.WriteLine("Modelo do seu smartphone:");
modelo = Console.ReadLine();
Console.WriteLine("Imei do seu smartphone:");
imei = Console.ReadLine();
Console.WriteLine("Memória do seu smartphone:");
memoria = Convert.ToInt32(Console.ReadLine());

Smartphone iphone = new Iphone(numero, modelo, imei, memoria);
Console.WriteLine($"Número do smartphone Iphone: {iphone.Numero}");
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");