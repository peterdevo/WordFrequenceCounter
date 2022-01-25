using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WordFrequenceCounter.Interface;

namespace WordFrequenceCounter.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CountController : ControllerBase
  {
    private readonly IWordCounterRepository _wordCounterRepository;
    public CountController(IWordCounterRepository wordCounterRepository)
    {
      _wordCounterRepository = wordCounterRepository;
    }

    [HttpPost]
    public async Task<ActionResult> CountWord()
    {
      string jsonString;
      using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
      {
        jsonString = await reader.ReadToEndAsync();
      }

      return Ok(_wordCounterRepository.CountWord(jsonString));

    }

  }
}