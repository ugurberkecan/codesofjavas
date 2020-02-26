// TThere are 3 ways to initialize multidimensional array in C# while declaration.

int[,] arr = new int[3,3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 
int[,] arr = new int[,]{ { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  
int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };  


// In C#, jagged array is also known as "array of arrays" because its elements are arrays. 
// The element size of jagged array can be different.


public class JaggedArrayTest  
{  
    public static void Main()  
    {  
        int[][] arr = new int[2][];// Declare the array  
  
        arr[0] = new int[] { 11, 21, 56, 78 };// Initialize the array          
        arr[1] = new int[] { 42, 61, 37, 41, 59, 63 };  
  
        // Traverse array elements  
        for (int i = 0; i < arr.Length; i++)  
        {  
            for (int j = 0; j < arr[i].Length; j++)  
            {  
                System.Console.Write(arr[i][j]+" ");  
            }  
            System.Console.WriteLine();  
        }  
    }  
}  


// Output

// 11 21 56 78
// 42 61 37 41 59 63


public class JaggedArrayTest  
{  
    public static void Main()  
    {  
       int [][] jagged = new int[2][];
       jagged[0] = new int[1];
       jagged[1] = new int[3]{4,2,8};


       foreach(int x in jagged[1])
       {
         Console.Write(x);
       }
    }
}  


// Output : 428
