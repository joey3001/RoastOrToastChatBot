using System.Threading.Tasks;
using RestSharp;

namespace ConsultingBot.Model
{
  class ComplimentApiHelper
  {
    public static async Task<string> ComplimentApiCall()
    {
      RestClient client = new RestClient("https://complimentr.com/api");
      RestRequest request = new RestRequest("", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}

