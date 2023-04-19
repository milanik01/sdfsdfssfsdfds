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
    for(int i=1; i<=longArray.GetLength(0); i++)
    {
        if(longArray[i].Length<=3) Console.WriteLine(longArray[i]+" ,");
    }
}

Console.WriteLine("Input size array ");
int num = Convert.ToInt32(Console.ReadLine());

CreateArray(num);
