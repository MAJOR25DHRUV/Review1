using System;
class Diagonal{
    static void Main(string[] args){
    
        Console.WriteLine("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());
        
        int[,] matrix = new int [rows, cols];
        
        Console.WriteLine("Enter the matrix elements: ");
        
        for(int i = 0; i < rows; i++){
            for(int j = 0; j < cols; j++){
                matrix[i,j] = int.Parse(Console.ReadLine());
            }
        }
        
        int diagonalMul = DiagonalMultiplication(matrix);
        Console.WriteLine(diagonalMul);
    }
    
    static int DiagonalMultiplication(int[,] matrix){
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        int minDim = Math.Min(rows, cols);
        
        int product = 1;
        
        
        for(int i = 0; i < minDim; i++){
            product *= matrix[i, i];
        }
        
        
        for(int i = 0; i < minDim; i++){
            if (rows == cols && rows % 2 == 1 && i == minDim/2) {
                continue;
            }
            product *= matrix[i, cols-1-i];
        }
        
        return product;
    }
}