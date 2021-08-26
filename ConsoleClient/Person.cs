using System;
using System.Text.Json.Serialization;

namespace ConsoleClient
{
    public class Person
    {
        [JsonPropertyName("Id")] public Guid Id { get; set; }

        [JsonPropertyName("FirstName")] public string FirstName { get; set; }

        [JsonPropertyName("LastName")] public string LastName { get; set; }
    }
}