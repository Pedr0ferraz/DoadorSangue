Console.Clear();
 
int Idade;
 
Console.Write("Digite sua idade: ");
Idade = Convert.ToInt32(Console.ReadLine());
 
if (Idade >= 18 && Idade <= 67)
{                    
    Console.WriteLine("Você pode ser doador de sangue.");
}
else
{
    Console.WriteLine("Você não pode ser doador de sangue.");
}