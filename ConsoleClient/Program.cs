using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleClient
{
    internal class Program
    {
        private static readonly HttpClient Client = new();

        public static async Task Main(string[] args)
        {
            var persons = await GetPersons();
            Console.WriteLine("Test");
            foreach (var i in persons) Console.WriteLine(i.FirstName);

            Console.Read();
        }

        private static async Task<List<Person>> GetPersons()
        {
            var streamTask = Client.GetStreamAsync("http://localhost:45100/api/person");
            var persons = await JsonSerializer.DeserializeAsync<List<Person>>(await streamTask);

            return persons;
        }
    }
}