class Program
{
    static void Main()
    {
        char[,] matrix = {  { 'B', 'B', 'W' }, 
                            { 'W', 'W', 'W' }, 
                            { 'W', 'W', 'W' }, 
                            { 'B', 'B', 'B' } };
        int locationX = 2;
        int locationY = 2;
        char oldPixel = matrix[locationX, locationY];
        char newPixel = 'G';

        ChangePixels(ref matrix, oldPixel, newPixel, locationX, locationY);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void ChangePixels(ref char[,] matrix, char oldPixel, char newPixel, int locationX, int locationY)
    {
        if ((locationX < matrix.GetLength(0) && locationX >= 0) && (locationY < matrix.GetLength(1) && locationY >=0))
        {
            if (matrix[locationX, locationY] == oldPixel) matrix[locationX, locationY] = newPixel;
            else return;
        }
        else return; 

        ChangePixels(ref matrix, oldPixel, newPixel, locationX, locationY + 1);
        ChangePixels(ref matrix, oldPixel, newPixel, locationX + 1, locationY);
        ChangePixels(ref matrix, oldPixel, newPixel, locationX, locationY - 1);
        ChangePixels(ref matrix, oldPixel, newPixel, locationX - 1, locationY);
    }
}