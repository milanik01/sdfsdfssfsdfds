// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");





string [] CreateArray(int rows)
{   
    string [] newArray = new string [rows];
    
    for(int i=0; i<rows; i++)
    {
            Console.WriteLine("Input "+i+" element array ");
            newArray[i] = Console.ReadLine();

            
    }

    return newArray;
}

void SortArray (string [] longArray)
{
    Console.Write("->");
    for(int i=0; i<longArray.GetLength(0); i++)
    {
        if(longArray[i].Length<=3) 
        Console.Write(longArray[i]+", ");
    }
}



int num;

String Result = Console.ReadLine();

while(!Int32.TryParse(Result, out num))
{
   Console.WriteLine("Not a valid number, try again.");

   Result = Console.ReadLine();
}
SortArray(CreateArray(num));
