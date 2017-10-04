using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        HashSet<int> hashSet =  new HashSet<int>();
        for (int i = 0; i < n ; i++ ){
            if(!hashSet.Add(a[i]))
                hashSet.Remove(a[i]);
        }
        Console.WriteLine(hashSet.FirstOrDefault());
    }
}