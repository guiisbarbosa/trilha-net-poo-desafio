using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia celular1 = new Nokia("991122", "Lumia10", "#123", 128);
Console.WriteLine("Dados do celular1: " + celular1.Numero);
celular1.InstalarAplicativo("Whatsapp");
celular1.Ligar();
celular1.ReceberLigacao();

Iphone celular2 = new Iphone("981122", "iPhone 15", "#456", 256);
Console.WriteLine("Dados do celular2: " + celular2.Numero);
celular2.InstalarAplicativo("Facebook");
celular2.Ligar();
celular2.ReceberLigacao();