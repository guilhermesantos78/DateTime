using System;
using System.Security.Cryptography;

// Tipo de inicialização

DateTime dt1 = new DateTime(2024, 7, 1, 8, 30, 25);
Console.WriteLine(dt1);
Console.WriteLine(dt1.ToString());
Console.WriteLine(dt1.ToString("g"));
Console.WriteLine(DateTime.Now.ToString("G"));
Console.WriteLine(dt1.ToString("d"));
Console.WriteLine(dt1.ToString("D"));
Console.WriteLine(dt1.ToString("t"));
Console.WriteLine(dt1.ToString("T"));
Console.WriteLine(dt1.ToString("yyy-MM-dd HH:mm:ss"));





string Data2 = "2020-06-06";
DateTime dt2 = DateTime.Parse(Data2);
Console.WriteLine(Data2);

DateTime dt3 = DateTime.Now;
Console.WriteLine(dt3);
Console.WriteLine(dt3.Year);
Console.WriteLine(dt3.Month);
Console.WriteLine(dt3.Day);
Console.WriteLine(dt3.Hour);
Console.WriteLine(dt3.Minute);
Console.WriteLine(dt3.Second);
Console.WriteLine(dt3.Millisecond);

//Opercações

DateTime hoje = DateTime.Now;
DateTime DataDevolucao = hoje.AddDays(7);//Adiciona Dias
DataDevolucao = DataDevolucao.AddHours(2);//Adiciona Horas


//diferenças


Console.WriteLine($"Você pegou o livro no dia {hoje}");
Console.WriteLine($"e terá que devolver dia {DataDevolucao}");

TimeSpan resultado = DataDevolucao - hoje;
TimeSpan diferenca = hoje.Subtract(DataDevolucao);

Console.WriteLine(resultado);
Console.WriteLine(resultado.Days);
Console.WriteLine(resultado.Hours);
Console.WriteLine(diferenca);
Console.WriteLine(diferenca.Days);
Console.WriteLine(diferenca.Hours);
Console.WriteLine(diferenca.TotalHours);
Console.WriteLine(diferenca.TotalSeconds);