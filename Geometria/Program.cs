using rectangle;
using System.Reflection.Metadata.Ecma335;

//PRENDO I PARAMETRI DEL RETTANGOLO

Console.WriteLine("Inserisci le dimensioni della base: ");
int xDim = int.Parse(Console.ReadLine());
Console.WriteLine("Inserisci le dimensioni dell'altezza: ");
int yDim = int.Parse(Console.ReadLine());

Rectangle myRectangle = new Rectangle(xDim, yDim);

//STAMPO LE INFO DEL RETTANGOLO

Console.WriteLine();
Console.WriteLine("-------------- INFO --------------");
Console.WriteLine("La base è: " + myRectangle.getxDimension());
Console.WriteLine("L'altezza è: " + myRectangle.getyDimension());
Console.WriteLine("Il perimetro è: " + myRectangle.getPerimeter());
Console.WriteLine("L'area è: " + myRectangle.getArea());
Console.WriteLine("----------------------------------");
Console.WriteLine();

//STAMPO IL RETTANGOLO IN CONSOLE

for (int i = 0; i < myRectangle.getyDimension(); i++)
{
    if (i == 0 || i == myRectangle.getyDimension() - 1)
    {
        for (int j = 0; j < myRectangle.getxDimension(); j++)
        {
            Console.Write("--");
        }
        Console.WriteLine();
    } else
    {
        for (int j = 0; j < myRectangle.getxDimension(); j++)
        {
            if(j == 0)
            {
                Console.Write("| ");
            } else if (j == myRectangle.getxDimension() - 1)
            {
                Console.Write(" |");
            } else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();
    }
}