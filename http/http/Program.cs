using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System;



using (HttpClient client = new HttpClient())
{
    string base_url = "https://jsonplaceholder.typicode.com/posts";
    HttpResponseMessage response = await client.GetAsync(base_url);
    string respon = await response.Content.ReadAsStringAsync();
    //Console.WriteLine(respon);
    var roots = JsonConvert.DeserializeObject<List<root>>(respon);
    foreach (var root in roots)
    {
        Console.WriteLine($"userId - {root.userId}");
       
        Console.WriteLine($"ID - {root.Id}");
        Console.WriteLine($"title - {root.title}");
        Console.WriteLine($"body - {root.body}");
        Console.WriteLine("  ");
    }
}
public class root
{
    public int userId { get; set; }
    public int Id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
}
