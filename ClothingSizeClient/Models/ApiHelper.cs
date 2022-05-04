using System.Threading.Tasks;
using RestSharp;

namespace ClothingSizeClient.Models
{
  class ApiHelper
  {

    public static async Task<string> GetUserInput(string userInput)
    {
      RestClient client = new RestClient("http://localhost:5000/api/");
      RestRequest request = new RestRequest($"{userInput}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

  }
}