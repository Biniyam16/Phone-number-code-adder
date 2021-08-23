using System;
using System.Linq;         //Is Used for counting elements in Array


namespace Phone_number_adder       //name of the project
{
    class Program
    {
        static void Main(string[] args)     // the Main class
        {

            string[] Phone_numbers = { "555-5555", "555-5556", "555-5557", "555-5558"};
           
            //this is the list of the phone nubmers

            string Phone_Code = "858-";

            //declare a varibale that holds code we wanna add before the phone number 

            int Phone_number_amont = Phone_numbers.Count();
            
            //counts elembents in the list and assign to a vairble called phone_number_amont

            for (int i = 0; i < Phone_number_amont; i++)    //we will use for calling the element in the list
            {
                Console.WriteLine(Phone_Code + Phone_numbers[i]);  //print the phone number with the code
            }

            Console.ReadLine();       //makes the window to stay open

}
    }
}
