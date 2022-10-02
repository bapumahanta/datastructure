namespace datastructure
{
    class Conversion
    {
       public static void conversion()
       {
        Decimal bottles=0.00M;
        decimal number=0.0M;
        Console.Write("Enter Number of Litres: ");      

        number = Convert.ToDecimal(Console.ReadLine());
        bottles = (number / 5*10); 
        Console.Write(number +"L water will fill "+ decimal.Truncate(bottles)
        +" bottles " +"("+ Math.Round((number-Math.Truncate(number)),2) +"L remaining)");
    }
}
}   
