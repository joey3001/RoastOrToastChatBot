using System.Threading.Tasks;
using RestSharp;

namespace RoastOrToastBot.Model
{
  class InsultApiHelper
  {
    public static async Task<string> InsultApiCall()
    {
      RestClient client = new RestClient("http://private-anon-cb44b106bf-insultgenerator.apiary-mock.com/insults");
      RestRequest request = new RestRequest("", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}