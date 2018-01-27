﻿using System.Net.Http;
using System.Threading.Tasks;

namespace Firebase.Net.Http
{
    public interface IHttpClientFacade
    {
        Task<HttpResponseMessage> GetAsync(string url);
        Task<HttpResponseMessage> PostAsJsonAsync<T>(string url, T value);
        Task<HttpResponseMessage> PutAsJsonAsync<T>(string url, T value);
        Task<HttpResponseMessage> DeleteAsync(string url);
    }
}