//Math >=90; Biology >=90; Chemistry >=90; 

int math, biology, chemistry;

Console.WriteLine("Enter your Math score: ");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology score: ");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry score: ");
chemistry = Int32.Parse(Console.ReadLine());

if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congrats you are accepted!");
}
else
{
    Console.WriteLine("You application cannot be approved");
}