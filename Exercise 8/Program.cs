// See https://aka.ms/new-console-template for more information
{
    Console.WriteLine("Enter maximum number: ");
    int number = Int32.Parse(Console.ReadLine());
    for (int i = 0; i < number; i++)
    {
        //for loop body
        if(i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
    //print asterisk row
    Console.WriteLine("Asterisks:");
    Console.ReadLine("How many rows of asterisks");



  Console.WriteLine(number);
}

//asterisk
Console.WriteLine("How many rows of asterisks");
int number = Int32.Parse(Console.ReadLine());

for(int a=0; a<number; a++)
{
    Console.Write("*");
}

//Console.WriteeLine(maxNum);
       
