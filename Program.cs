// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:

// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

int total = 0;
int desconto = 0;
int totalPagar = 0;

Console.WriteLine($"Informe o produto adquirido: ");
string produto = Console.ReadLine();

Console.WriteLine($"Informe a quantidade adquirida: ");
int quantidadeAdquirida = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o preço unitário do seu produto: ");
float precoUnitario = float.Parse(Console.ReadLine());

total = quantidadeAdquirida * (int)precoUnitario;

if (quantidadeAdquirida <= 5)
{
    desconto = total * (int)0.02;
}
else if (quantidadeAdquirida > 5 && quantidadeAdquirida <= 10)
{
    desconto = total * (int)0.03;
}
else
{
    desconto = total * (int)0.05;
}

totalPagar = total - desconto;

Console.WriteLine($"O produto é {produto}");
Console.WriteLine($"A quantidade adquirida é {quantidadeAdquirida}");
Console.WriteLine($"O preço unitario do {produto} é de {precoUnitario}");
Console.WriteLine($"O valor total é de R${total}");
Console.WriteLine($"O desconto é de R${desconto}");
Console.WriteLine($"O total a pagar é de R${totalPagar}");