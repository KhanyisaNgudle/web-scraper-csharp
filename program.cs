using System;
using System.Net.Http;

class Program {
    static void Main(string[] args){
        var url = ""; // website url you wanna scrape
        var webClient = new HttpClient();
        var docHTML = webClient.GetStringAsync(url);

        Console.WriteLine(docHTML.Result);
        Console.ReadLine();
    }
}