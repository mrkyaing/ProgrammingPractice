using System;
using System.Linq;
using System.Globalization;
class SplitStringDemo{
    static void Main(){
            char delimiterChars ='.';
            string text = "2.08:00:00";
             int numberOfdays = 0;
            string tS = string.Empty;
            if(text.Contains(delimiterChars)){
            string[] rateSetToTimeWithDays =text.Split(delimiterChars);
            foreach(var item in rateSetToTimeWithDays){
               if (rateSetToTimeWithDays.First() == item) numberOfdays = int.Parse(item);
                  else tS+=item;
            }
            }else{
                tS=text;
            }
            DateTime.TryParse(tS, CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal, out DateTime rateSetTimeValidToTimeDate);
            rateSetTimeValidToTimeDate.AddDays((int)numberOfDays);
Console.WriteLine(numberOfdays);
Console.WriteLine(rateSetTimeValidToTimeDate);
    }
}