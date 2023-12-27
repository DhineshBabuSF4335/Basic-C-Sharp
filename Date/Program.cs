using System;
namespace Date;
class Program{

    public static void Main(string[] args)
    {   

        // DateTime date = DateTime.TryParseExact()
        // bool temp  = DateTime.TryParseExact(Console.ReadLine(),"hh:mm tt",null,System.Globalization.DateTimeStyles.None,out DateTime date);
        // Console.WriteLine(date);

        Console.WriteLine("Enter the Date of CheckIn format of dd/MM/yyyy:");
        DateTime inDate;
        bool temp3 = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out inDate);
        while(!temp3){
            Console.WriteLine("Enter the Date Correctly:");
            Console.WriteLine("Enter the Date hh:mm ttt");
            DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out inDate);

        }
        Console.WriteLine(inDate);
        Console.WriteLine("Enter the Date of CheckOut format of dd/MM/yyyy:");
        DateTime outDate;
        bool temp4 = DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out outDate);
        while(!temp4){
            Console.WriteLine("Enter the Date Correctly:");
            Console.WriteLine("Enter the Date hh:mm ttt");
            DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,System.Globalization.DateTimeStyles.None,out outDate);

        }
        Console.WriteLine(outDate);
         


        DateTime checkInTime;
        Console.WriteLine("Enter the CheckInTime hh:mm ttt");
        bool temp = DateTime.TryParseExact(Console.ReadLine(),"hh:mm ttt",null,System.Globalization.DateTimeStyles.None,out checkInTime);
        while(!temp){
            Console.WriteLine("Enter the Date Correctly:");
            Console.WriteLine("Enter the Date hh:mm ttt");
            DateTime.TryParseExact(Console.ReadLine(),"hh:mm ttt",null,System.Globalization.DateTimeStyles.None,out checkInTime);

        }
        Console.WriteLine(checkInTime);
                DateTime checkOutTime;
        Console.WriteLine("Enter the CheckOutTime hh:mm ttt");
        bool temp1  = DateTime.TryParseExact(Console.ReadLine(),"hh:mm ttt",null,System.Globalization.DateTimeStyles.None,out checkOutTime);
        while(!temp1){
            Console.WriteLine("Enter the Date Correctly:");
            Console.WriteLine("Enter the Date hh:mm ttt");
            DateTime.TryParseExact(Console.ReadLine(),"hh:mm ttt",null,System.Globalization.DateTimeStyles.None,out checkOutTime);

        }
        Console.WriteLine(checkOutTime);

        TimeSpan time = checkOutTime - checkInTime;
        int totalHours = time.Hours;

        if(inDate == outDate && totalHours >= 8){

        }else{
            Console.WriteLine("Input Invalid..");
        }
    }
}
