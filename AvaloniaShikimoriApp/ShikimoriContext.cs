using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using AvaloniaShikimoriApp.Models;

namespace AvaloniaShikimoriApp;

public class ShikimoriContext
{
    private const string URL = "https://shikimori.one/";
    private HttpClient httpClient;

    public ShikimoriContext()
    {
        httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri(URL);
    }

    public List<Anime>? GetAnimes()
    {
        // season
        // page
        string param = "api/animes?limit=50&page=1&order=ranked";
        List<Anime>? animes = new List<Anime>();
        HttpResponseMessage response = httpClient.GetAsync(param).Result;
        if (response.IsSuccessStatusCode)
        {
            string json = response.Content.ReadAsStringAsync().Result;
            animes = JsonSerializer.Deserialize<List<Anime>>(json); 
        }

        return animes;
    }
}