using System.Collections.Generic;

namespace PrimeNumber.Models
{
    public class PrimeNum
    {
        public Dictionary<int, string> GenNumber(int userEnteredNum) {
            Dictionary<int, string> allNumbers = new Dictionary<int, string>() { };
            for (int i = 2; i <= userEnteredNum; i++)
            {
                allNumbers[i] = "unProcessed";
            }
            return allNumbers;
        }
        // public string Description { get; set; }
        // private static List<PrimeNumber1> _instances = new List<PrimeNumber1> { };

        // public PrimeNumber1()
        // {
        //     // Description = description;
        //     // _instances.Add(this); // New code.
        // }

        // public static List<PrimeNumber1> GetAll()
        // {
        //     return _instances;
        // }

        // public static void ClearAll()
        // {
        //     _instances.Clear();
        // }

    }
}