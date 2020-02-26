using System;  
public class EnumExample  
{  
    public enum Season { WINTER=10, SPRING, SUMMER, FALL }    
  
    public static void Main()  
    {  
        int x = (int)Season.WINTER;  
        int y = (int)Season.SUMMER;  
        Console.WriteLine("WINTER = {0}", x);  
        Console.WriteLine("SUMMER = {0}", y);  
    }  
} 

// Normally enums start on index 0 but if we can change index number of any element.

