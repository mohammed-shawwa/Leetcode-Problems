using System;
using System.Collections.Generic;

public class Solution
{
    public class RandomizedSet {
        private List<int> list;
        private Dictionary<int, int> dict; 
        private Random random; 

        public RandomizedSet() {
            this.list = new List<int>(); 
            this.dict = new Dictionary<int, int>();
            this.random = new Random();
        }
        
        public bool Insert(int val) {  
            if (dict.ContainsKey(val)) return false; 

            list.Add(val);
            dict[val] = list.Count - 1; 

            return true;
        }
        
        public bool Remove(int val) {
            if (!dict.TryGetValue(val, out int index)) return false;

            int lastElement = list[list.Count - 1]; 
            list[index] = lastElement;
            dict[lastElement] = index; 

            list.RemoveAt(list.Count - 1);
            dict.Remove(val);

            return true;
        }
        
        public int GetRandom() {
            return list[random.Next(list.Count)]; 
        }
    }
    
    public static void Main()
    {
        RandomizedSet randomizedSet = new RandomizedSet();
        Console.WriteLine(randomizedSet.Insert(1)); // true
        Console.WriteLine(randomizedSet.Remove(2)); // false
        Console.WriteLine(randomizedSet.Insert(2)); // true
        Console.WriteLine(randomizedSet.GetRandom()); // 1 or 2
        Console.WriteLine(randomizedSet.Remove(1)); // true
        Console.WriteLine(randomizedSet.Insert(2)); // false
        Console.WriteLine(randomizedSet.GetRandom()); // 2
    }
}
