using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "456", modelo: "Modelo 2", imei: "456", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");