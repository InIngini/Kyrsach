﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Курсач.Core.Interfaces;
using Курсач.Data.Entities;

namespace Курсач.Services
{
    public class PictureService : IPictureService
    {
        private readonly HttpClient _httpClient;

        public PictureService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Picture> CreatePicture(Picture picture)
        {
            var response = await _httpClient.PostAsJsonAsync("user/picture", picture);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Picture>();
        }

        public async Task<Picture> GetPicture(int id)
        {
            var response = await _httpClient.GetAsync($"user/picture/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Picture>();
        }

        public async Task DeletePicture(int id)
        {
            var response = await _httpClient.DeleteAsync($"user/picture/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
