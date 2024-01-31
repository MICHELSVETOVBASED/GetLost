using System;
using System.Text;
using System.Collections.Generic;

public class Solution{
    public bool 
    public int RomanToInt(string s){
        int count = 0;
        char[] ch = s.ToCharArray();
        int valVal, nextVal;
        for (int i = 0; i < ch.Length; i++){
            valVal = map[ch[i]];
            
            if (i != ch.Length-1){
                nextVal = map[ch[i + 1]];
                if (nextVal > valVal){
                    count += nextVal - valVal;
                    i++;
                    if ( ch[i+1].)
                }
            }

            count += valVal;

        }

        return count;
    }

    private readonly Dictionary<char, int> map = new Dictionary<char, int>
        { { 'I', 1 },{ 'V', 5 },{ 'X', 10 },{ 'L', 50 },{ 'C', 100 },{ 'D', 500 },{ 'M', 1000 } };

    static void Main(){
        var a = new Solution();
        int ss = a.RomanToInt("MCMXCIV");
        Console.WriteLine(ss);
    }d
}