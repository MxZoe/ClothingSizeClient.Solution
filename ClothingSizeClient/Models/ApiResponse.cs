using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClothingSizeClient.Models
{
  public class ApiResponse
  {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string ClothingType { get; set; }
        public string Gender { get; set; }
        public string XXXS { get; set; }
        public string XXS { get; set; }
        public string XS { get; set; }
        public string S { get; set; }
        public string M { get; set; }
        public string L { get; set; }
        public string XL { get; set; }
        public string XXL { get; set; }
        public string XXXL { get; set; }
        public string XXXXL { get; set; }
    
    public static List<ApiResponse> GetWhatever(string userInput)
    {
      var apiCallTask = ApiHelper.GetUserInput(userInput);
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<ApiResponse> whateverList = JsonConvert.DeserializeObject<List<ApiResponse>>(jsonResponse.ToString());

      return whateverList;
    }
  }
}