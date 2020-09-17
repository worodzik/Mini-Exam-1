using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter your name");
    string name = Console.ReadLine();
    Console.WriteLine("Enter your height in inches");
    double height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter your weight in pounds");
    double weight = Convert.ToDouble(Console.ReadLine());

    double BMI = Math.Round((703 * weight) / (height * height), 2);
     Console.WriteLine(" " + name + " BMI = " + BMI);
     

     if (BMI < 18.5){
       Console.WriteLine("health states for  " + name + " is underweight");

     }
     else if ((BMI >= 18.5) && (BMI <= 24.9)){
        Console.WriteLine("health states for  " + name + " is normal");
     }
      else if ((BMI >= 25) && (BMI <= 29.9)){
        Console.WriteLine("health states for  " + name + " is Overweight");
     }
     else if (BMI >= 30){
        Console.WriteLine("health states for  " + name + " is Obese");
     }

  }
}