using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
 
 int[] days = new int[7];
 double[] cel = new double[7];
 double[] faren = new double[7];
 
 for(int i = 0; i <7; i++)
 {
   Console.WriteLine("Enter Temperature in celcius");
   cel[i] = Convert.ToInt32(Console.ReadLine());
   faren[i]=(cel[i] * 9/5)+32;
   
 }
 Console.WriteLine("Temperature in Fahrenheit ");
 for(int i =0; i<7; i++)
 {
   Console.WriteLine(faren[i]);
   Array.Reverse(faren);
   
 }
 foreach(int sum in faren){
   var add = faren.Sum();
  var average= add/7;
   Console.WriteLine("Average weekly Temperature is " + average + " degrees Fahrenheit");
   Console.ReadLine();
 }
 

    }
  
}