using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            // Key: Province or City, Value: Index of the Parent (Key)
            dictionary.Add("South Africa", -1);
            dictionary.Add("Gauteng", 0);
            dictionary.Add("Pretoria", 1);
            dictionary.Add("Johannesburg", 1);
            dictionary.Add("Cape Town", 1);
            dictionary.Add("Western Cape", 5);
            dictionary.Add("Durban", 1);
            dictionary.Add("KwaZulu-Natal", 7);

            // Call the FindParent method for each leaf node
            FindParent(dictionary, "Pretoria");
            FindParent(dictionary, "Johannesburg");
            FindParent(dictionary, "Western Cape");
            FindParent(dictionary, "KwaZulu-Natal");
        }

        private static void FindParent(Dictionary<string, int> dictionary, string child)
        {
            if (dictionary.ContainsKey(child))
             {
             int parentIndex = dictionary[child];

             // Check if the child has a parent
             if (parentIndex >= 0)
             {
             string parent = GetKeyByValue(dictionary, parentIndex);
             Console.WriteLine("Parent of {0}: {1}", child, parent);

             // Recursively call the FindParent method with the parent as the new child
             FindParent(dictionary, parent);
             }
             else
             {
             Console.WriteLine("Leaf node: {0}", child);
             }
             }
             else
             {
             Console.WriteLine("Child node not found: {0}", child);
             }

        }

        private static string GetKeyByValue(Dictionary<string, int> dictionary, int value)
        {
            {
                foreach (var pair in dictionary)
                {
                    if (pair.Value == value)
                    {
                        return pair.Key;
                    }
                }
                return null;
            }
        }
    }

}

