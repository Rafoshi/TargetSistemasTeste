using System.IO;
using System.Linq;
using Json_03;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

IList<Billing> dailyBillings = getListFromJsonFile();
IEnumerable<Billing> sortedEnum = dailyBillings.OrderBy(f => f.Value);
IList<Billing> sortedBillings = sortedEnum.ToList();
IList<Billing> sortedBillingsFiltered = sortedEnum.ToList();
double monthBiling = 0;

foreach (var item in sortedBillings)
{
    if(item.Value == 0)
    {
        sortedBillingsFiltered.Remove(item);
    }
}

foreach (var item in sortedBillingsFiltered)
{
    monthBiling += item.Value;
}

int numberOfDays = sortedBillingsFiltered.Count;
double monthlyAverage = monthBiling / numberOfDays;
int aboveAverage = sortedBillingsFiltered.Where(b => b.Value < monthlyAverage).Count();

double MinValue = sortedBillingsFiltered.Min(b => b.Value);   
double MaxValue = sortedBillingsFiltered.Max(b => b.Value);
Console.WriteLine($"O menor valor de faturamento ocorrido em um dia do mês é: {MinValue}\n");
Console.WriteLine($"O maior valor de faturamento ocorrido em um dia do mês é: {MaxValue}\n");
Console.WriteLine($"Número de dias no mês em que o valor de faturamento diário foi superior à média mensal é : {aboveAverage}\n");

Console.Read();

IList<Billing> getListFromJsonFile()
{
    JArray jsonArrayBilling = JArray.Parse(File.ReadAllText(@"..\..\..\dados.json"));

    IList<Billing> billings = jsonArrayBilling.Select(p => new Billing
    {
        Day = (int)p["dia"],
        Value = (double)p["valor"]
    }).ToList();

    return billings;
}