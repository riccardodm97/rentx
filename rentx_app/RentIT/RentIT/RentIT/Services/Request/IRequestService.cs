﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RentIT.Services.Request
{
    public interface IRequestService
    {
        Task<TResult> GetAsync<TResult>(string uri, string token);

        Task<TResult> PostAsync<TResult>(string uri, TResult data, string token);

        Task<TResult> PutAsync<TResult>(string uri, TResult data, string token);

        Task DeleteAsync(string uri, string token);

    }
}

