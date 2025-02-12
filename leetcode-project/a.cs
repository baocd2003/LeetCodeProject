using System;
using System.Collections.Generic;

public class CountCharactersInString
{
    static public void ParseText(string data)
    {
        //Input your solution here
        string output = "";
        char[] charsArray = data.ToCharArray();
        Dictionary<char,int> dic = new Dictionary<char,int>();
       for(int i = 0; i < charsArray.Length;i++){
           int start = 0;
           int end = charsArray.Length - 1;
           int count = 1;     
        if(!dic.ContainsKey(charsArray[i])){
            dic[charsArray[i]] = count;
        }else{
            count++;
            dic[charsArray[i]] = count;
        }
              start++;
           
       }
       foreach(char word in dic.Keys){
           string s = word.ToString() + " " +  dic[word].ToString() + ", ";
           output = output + s;
       } 
    Console.WriteLine(output);
    }

    static public void Main()
    {
        string input;
        input = Console.In.ReadToEnd();
        string[] data = input.Split("\n");
        foreach (string item in data)
        {
            ParseText(item);
        }
    }
}
