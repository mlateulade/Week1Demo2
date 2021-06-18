using System;

class MainClass {
  public static void Main (string[] args) {
    //write code to add 2 numbers
    //Operators : + - * / %
    var x = Console.ReadLine();//2 becomes "2"
    var y = Console.ReadLine();//3 becomes "3"
    Console.WriteLine(x+y);//concatenates "2" and "3"

    int x1 = Convert.ToInt32(x);//converts string to interger now "2" becomes 2
    int y1 = Convert.ToInt32(y);//converts string to interger now "3" becomes 3
    Console.WriteLine(x1+y1);


  }
}