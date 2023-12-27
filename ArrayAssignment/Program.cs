using System;
using System.ComponentModel;
using System.Linq;
namespace ARRAYASSIGNMENT;

class Program{
    public static void Main(String[] args){
        string [] arr = new string[5];
        arr[0] = "h";
        arr[1] = "Dhinesh";
        arr[2] = "Babu";
        arr[3] = "vikas";
        arr[4]  = "kholi0";
        foreach(string i in arr){
            Console.WriteLine(i);
        }
        Console.WriteLine("Enter the name:");
        string name = Console.ReadLine();
        int count = 0;
        for(int i = 0; i<arr.Length; i++){
            if(arr[i]==name){
               // Console.WriteLine($"name found in array {name}");
                //Console.WriteLine($"the index of array is"+ i);
                count++;
            }
            
        }
        if(count < 1){
            Console.WriteLine("The name is not present in array");
        }else{
            Console.WriteLine("The name is present in array");
        }
        int inc = 0;
        foreach(string j in arr){
            if(j==name){
             inc++;
            }
        }
          if(inc < 1){
            Console.WriteLine("The name is not present in array");
        }else{
            Console.WriteLine("The name is present in array");
        }

    }
}
