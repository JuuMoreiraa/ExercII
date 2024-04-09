using System.Reflection.Metadata.Ecma335;

double CalculaMetro(int qtd, double tempo){
    double umpigas = 0.08;
    double metro = qtd*umpigas*tempo;
    return metro;
}



Console.WriteLine("Já parou para pensar quantos metros de cigarro você já fumou na vida?");

Console.Write("Quantos cigarros você fuma por dia?");
int qtd = int.Parse(Console.ReadLine());
Console.Write("Há quanto tempo você fuma na sua vida em dias?");
double tempo = double.Parse(Console.ReadLine());

Console.WriteLine($"Com base nas informações passadas, você já fumou {CalculaMetro(qtd, tempo)} metros de cigarro durante a sua vida. \nBora refletir?");


Console.WriteLine("Pressione qualquer tecla para encerrar");
Console.ReadKey();