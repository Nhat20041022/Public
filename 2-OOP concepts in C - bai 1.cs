using System;

class Employee{
    private string name;
    private int age;


    public Employee(){
        name = "Dung";
        age = 20;
    }

    public Employee(string varName, int varAge{
        name = varName;
        age = varAge;
    }

    public void ShowData(){
        Console.WriteLine("Name = " + name);
        Console.WriteLine("Age = " + age);
    }

    static void Main(){
        Employee objEmpOne = new Employee();
        Employee objEmpTwo = new Employee("Hoang", 21);
        
        objEmpOne.ShowData();
        Console.WriteLine();
        objEmpTwo.ShowData();
    }
}