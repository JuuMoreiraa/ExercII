using System.Reflection.Metadata.Ecma335;
//declaração de variáveis
const float tamanho = 0.08f;
const float mesBase = 30f;
const float maco = 20f;
const float valor = 8.50f;

//Entrada
Console.WriteLine("Já parou para pensar quantos metros de cigarro você já fumou na vida?");

Console.Write("Quantos cigarros você fuma por dia?");
int qtd = int.Parse(Console.ReadLine());
Console.Write("Há quantos meses você fuma?");
double mes = double.Parse(Console.ReadLine());

//Processamento
double CalculaMetroPigas(int qtd, double mes){
    return qtd*tamanho*mes*mesBase;
}

double CalculaQtdPigas(int qtd, double mes){
    return qtd*mesBase*mes;
}

double CalculaGastosPigas(int qtd, double mes){
    return valor/maco*qtd*mes*mesBase;
}

double CalculaMacosPigas(int qtd, double mes){

    return qtd*mesBase*mes/maco;
}


//Saída
Console.Clear();
Console.WriteLine($"Com base nas informações passadas: \nQuantidade de cigarros fumados (un): {CalculaQtdPigas(qtd, mes)} \nMetros de cigarro: {CalculaMetroPigas(qtd, mes)} \nValor gasto nessa brincadeira: {CalculaGastosPigas(qtd,mes):c} \nQuantidade de maços fumados: {CalculaMacosPigas(qtd,mes)}\nBora refletir? \n#FumaNãoPo #SingaroDáCãrse");







Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para encerrar");
Console.ReadKey();