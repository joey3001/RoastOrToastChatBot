using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace ConsultingBot.Model
{
  public class ComplimentApiResult
  {
    public string Compliment { get; set; }

    public static string GetCompliments()
    {
      var apiCallTask = ComplimentApiHelper.ComplimentApiCall();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      ComplimentApiResult apiResult = JsonConvert.DeserializeObject<ComplimentApiResult>(jsonResponse.ToString());
      
      return apiResult.Compliment;
    }
  }
}