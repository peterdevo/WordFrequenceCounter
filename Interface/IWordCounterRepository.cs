

using System.Collections.Generic;

namespace WordFrequenceCounter.Interface
{
  public interface IWordCounterRepository
  {
    Dictionary<string,int> CountWord(string textString);

  }
}