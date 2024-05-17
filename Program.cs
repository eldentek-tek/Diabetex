Console.Clear();
int diabete;
void loopzao()
{
 
    Console.WriteLine("=== Diabete Gestacional ==\n");
    
    Console.WriteLine("Digite a sua glicose...\n");
    diabete = Convert.ToInt32(Console.ReadLine());

if(diabete < 92)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;

        Console.Write("Reavaliar entre 24 e 28 semanas com TTOG 75g de glicose...\n");
    }

if(diabete < 126 && diabete >= 92)
{
     Console.ForegroundColor = ConsoleColor.Red;

      Console.Write("Compatível com diabete gestacionail.\n");
}
if(diabete >= 126)
{
     Console.ForegroundColor = ConsoleColor.Green;

      Console.Write("Diabetes Mellitus na gravidez.\n");
}
Console.ResetColor();

Console.WriteLine("Deseja recomeçar o programa?[S/N]\n");
string resposta = Console.ReadLine()!;

if(resposta.ToUpper() == "S")
{
    Console.ResetColor();
    Console.Clear();
    loopzao();
}

if(resposta.ToUpper() == "N")
{
    Console.Clear();
}
else
{

}
}
loopzao();