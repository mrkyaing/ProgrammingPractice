using System;
class ErrorHandling {
    static void Main () {
        try {
            Console.Write ("Enter your age:");
            int age = int.Parse (Console.ReadLine ());
            bool result = IsGreaterThan18 (age);
            if (result) {
                Console.WriteLine ("You can vote.");
            } else {
                Console.WriteLine ("You cannot vote.");
            }
        } catch (Exception e) {
            Console.WriteLine ("Hummmm.....Error Occur because of " + e.Message);
        }
    } //end of main

    //define a method 
    static bool IsGreaterThan18 (int age) {
        bool result = false;
        if (age <= 0) {
            throw new Exception ("your age cannot be nagative value.");
        } else if (age > 18) {
            result = true;
        }
        return result;
    } //end of IsGreaterThan18 Method 
} //end of class