Dictionary<string, string> estados = new Dictionary<string, string>();

//1° parâmetro chave, 2° parâmetro valor
estados.Add("RJ", "Rio de Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}");
}

Console.WriteLine("--------");

//Removendo item
estados.Remove("BA");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}");
}

//Alterando item
estados["MG"] = "Minas Gonçalves";

Console.WriteLine("--------");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key} | Valor: {item.Value}");
}

//Verificando se a chave já existe.
string chave = "BA";

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Chave {chave} já existe.");
}
else
{
    Console.WriteLine($"Não existe.");
}