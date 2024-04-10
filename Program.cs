using System.Reflection.Metadata.Ecma335;

//Entrada
Console.WriteLine("Já parou para pensar quantos metros de cigarro você já fumou na vida?");

Console.Write("Quantos cigarros você fuma por dia?");
int qtd = int.Parse(Console.ReadLine());
Console.Write("Há quanto tempo você fuma na sua vida em meses?");
double tempo = double.Parse(Console.ReadLine());

//Processamento
double CalculaMetroPigas(int qtd, double tempo){
    return qtd*0.08*tempo*30;
}

double CalculaQtdPigas(int qtd, double tempo){
    return qtd*30*tempo;
}

double CalculaGastosPigas(int qtd, double tempo){
    return 8.50/20*qtd*tempo*30;
}

double CalculaMacosPigas(int qtd, double tempo){

    return qtd*30*tempo/20;
}


//Saída
Console.Clear();
Console.WriteLine($"Com base nas informações passadas, você já fumou {CalculaQtdPigas(qtd, tempo)} unidades de cigarros ,\nOque totaliza {CalculaMetroPigas(qtd, tempo)} metros de cigarro fumado durante todo esse tempo. \nO valor que você gastou nessa brincadeira é {CalculaGastosPigas(qtd,tempo):c}, \n valor correspondente a {CalculaMacosPigas(qtd,tempo)} maços de cigarro. \nBora refletir? \n#FumaNãoPo #SingaroDáCãrse");


Console.WriteLine("Pressione qualquer tecla para encerrar");
Console.ReadKey();