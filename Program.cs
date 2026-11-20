using System.Text;
using DesafioPOO.Models;

Console.OutputEncoding = Encoding.UTF8;

// Testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo Nokia", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo iPhone", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
