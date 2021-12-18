using System;
using System.Collections.Generic;
class ForEachAction {
    public static void Main () {
        List<int> items = new List<int> () { 14, 19 };
        items.ForEach (item => Console.WriteLine (item));
    }
}