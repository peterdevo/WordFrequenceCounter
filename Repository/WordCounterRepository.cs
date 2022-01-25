using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using WordFrequenceCounter.Interface;

namespace WordFrequenceCounter.Repository
{
  public class WordCounterRepository : IWordCounterRepository
  {
    public Dictionary<string, int> CountWord(string textString)

    {
      var temp = Regex.Replace(textString.ToLower(), @"[^0-9a-zA-ZåäöÅÄÖ]", " ");

      string[] arr = temp.Split(' ', StringSplitOptions.RemoveEmptyEntries);

      Dictionary<string, int> occurences = new Dictionary<string, int>();

      for (int i = 0; i < arr.Length; i++)
      {

        if (occurences.ContainsKey(arr[i]))
        {
          occurences[arr[i]]++;
        }
        else
        {
          occurences.Add(arr[i], 1);
        }

      }

      var sortedDict = from entry in occurences orderby entry.Value descending select entry;
      var result = sortedDict.Take(10);

      return result.ToDictionary(p => p.Key[0].ToString().ToUpper() + p.Key.Substring(1), p => p.Value);
    }


  }
}