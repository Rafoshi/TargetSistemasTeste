//1 - Calcular o valor total da distribuidora - SOMAR TUDO
//2 - Percentual de cada estado

//SP – R$67.836,43
//RJ – R$36.678,66
//MG – R$29.229,88
//ES – R$27.165,48
//Outros – R$19.849,53

double SP = 67836.43;
double RJ = 36678.66;
double MG = 29229.88;
double ES = 27165.48;
double Others = 19849.53;

double totalValue = SP + RJ + MG + ES + Others;

double spPercent = (SP * 100) / totalValue;
double rjPercent = (RJ * 100) / totalValue;
double mgPercent = (MG * 100) / totalValue;
double esPercent = (ES * 100) / totalValue;
double othrerPercent = (Others * 100) / totalValue;


Console.WriteLine("O percentual de representação que cada estado teve dentro do valor total mensal da distribuidora é:" +
    $"\n SP: {spPercent} %" +
    $"\n RJ: {rjPercent} %" +
    $"\n MG: {mgPercent} %" +
    $"\n ES: {esPercent} %" +
    $"\n Others: {othrerPercent} %");
 