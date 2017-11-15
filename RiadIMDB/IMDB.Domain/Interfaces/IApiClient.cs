﻿using System.Threading.Tasks;

namespace IMDB.Domain.Interfaces
{
    public interface IApiClient
    {
        Task<T> GetAsync<T>(string url, string lang = "");
        Task<byte[]> GetImage(string url);
        Task<TResponse> PostAsync<TResponse, TContent>(string url, TContent content);
    }
}
