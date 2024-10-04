// See https://aka.ms/new-console-template for more information
bool w, t, r, p;
Console.WriteLine([A]tivado / [D]esativado);

Console.WriteLine("Sensor de temperatira...");
T = Console.ReadLine();!.ToUpper() == "A";
Console.WriteLine("Sensor de pressão");
p = Console.ReadLine()!.ToUpper() == "A";
Console.WriteLine("Sensor de rotação");
r = Console.ReadLine()!.ToUpper() == "A";
w = T && (p || !r);
if (w)
{
    Console.WriteLine("A luz de advertência estará ATIVADA.");
}
else
{
    Console.WriteLine("A luz de advertência estará DESATIVADA.");
}
