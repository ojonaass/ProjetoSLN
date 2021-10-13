using Projeto.ModelData.Logic.Northwind.Model;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Projeto.WebApplicationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RunAsync().Wait();
            Console.ReadKey();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new System.Uri("https://localhost:44394/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/Employees");
                if (response.IsSuccessStatusCode)
                {//GET
                   
                    List<Employees> employees = await response.Content.ReadAsAsync<List<Employees>>();
                    foreach (var item in employees)
                    {
                        Console.WriteLine($"{item.EmployeeID}\n\n{item.LastName}\n\n{item.FirstName}\n\n{item.Title}\n\n{item.TitleOfCourtesy}\n\n{item.BirthDate}\n\n{item.HireDate}\n\n{item.Address}\n\n{item.City}\n\n{item.Region}\n\n{item.PostalCode}\n\n{item.Country}\n\n{item.HomePhone}\n\n{item.Extension}\n\n{item.Notes} ");

                    }
                    //Console.WriteLine(response);
                    Console.ReadKey();
                }

            }
        }
    }
}
