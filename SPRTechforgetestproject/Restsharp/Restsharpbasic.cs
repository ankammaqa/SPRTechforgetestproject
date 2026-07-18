using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SPRTechforgetestproject.Utilitys;

namespace SPRTechforgetestproject.Restsharp
{
    public class Restsharpbasic
    {
        [Test]
        public void GetMethod()
        {
            var client = new RestClient("https://restful-booker.herokuapp.com");

            var request = new RestRequest("booking/894", Method.Get);
            request.AddHeader("Accept", "application/json");

            var response = client.Execute(request);

            Console.WriteLine("Status Code: " + response.StatusCode);
            Console.WriteLine("Response Content: " + response.Content);

            if (response.IsSuccessful)
            {
                var jsondata = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine(jsondata);
            }
            else
            {
                Console.WriteLine("API call failed");
            }

            
        }
        [Test]
        public void PostMethod()
        {
            var client = new RestClient("https://restful-booker.herokuapp.com");

            var request = new RestRequest("booking", Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            var body = new
            {
                firstname = "John",
                lastname = "Doe",
                totalprice = 150,
                depositpaid = true,
                bookingdates = new
                {
                    checkin = "2024-02-01",
                    checkout = "2024-02-05"
                },
                additionalneeds = "Breakfast"
            };

            request.AddJsonBody(body);

            var response = client.Execute(request);

            Console.WriteLine("Status Code: " + response.StatusCode);
            Console.WriteLine("Response: " + response.Content);

            if (response.IsSuccessful)
            {
                var jsondata = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine(jsondata);
            }
            else
            {
                Console.WriteLine("API call failed");
            }
        }

    }
}
