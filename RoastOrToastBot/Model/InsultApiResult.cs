using System.Collections.Generic;
using Newtonsoft.Json;
using System;

namespace RoastOrToastBot.Model
{
  public class InsultApiResult
  {
    public string Title { get; set; }
    public List<Dictionary<String, String>> Insults { get; set;}


    public static string GetInsults()
    {
      var apiCallTask = InsultApiHelper.InsultApiCall();

      var result = apiCallTask.Result;
      List<InsultApiResult> apiResults = JsonConvert.DeserializeObject<List<InsultApiResult>>(result);

      int random = new Random().Next(0, 3);

      var insultString = apiResults[random].Insults[0]["insult_no_name"];
      
      return insultString;
    }
  }
}