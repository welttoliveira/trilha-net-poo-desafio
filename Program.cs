using DesafioPOO.Models;

Console.WriteLine("Nokia: ");
Nokia nk = new Nokia("987654", "Nokia Flip", "ABC321123", 32);
nk.Ligar();
nk.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone: ");
Iphone ip = new Iphone("123456", "Iphone 16 Pro Max", "ABC546789", 256);
ip.ReceberLigacao();
ip.InstalarAplicativo("WhatsApp");