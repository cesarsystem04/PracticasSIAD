using ApiClientLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiClientLibrary.Services
{
    public class ValoresReferenciaServices : IServices
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        private readonly string _basePath = "F1_ConfiguracionInicial/";

        public ValoresReferenciaServices() 
        {

            var builder = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            _configuration = builder.Build();

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri($"{_configuration["ApiSettings:BaseUrl"]}{_basePath}")
            };

            var token = _configuration["ApiSettings:Token"];
            if (!string.IsNullOrEmpty(token))
            {
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }

        }

        public void SetToken(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
             new AuthenticationHeaderValue("Bearer", token);
        }


       public async Task<HttpResponseMessage> Leer()
        {
            var response = await _httpClient.GetAsync("ValorReferencia");
            return response;
        }


        public async Task<HttpResponseMessage> Guardar(IBaseDTO baseDTO)
        {
            var json = JsonSerializer.Serialize(baseDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("ValorReferencia", content);
            return response;
        }


        public async Task<HttpResponseMessage> Actualizar(IBaseDTO baseDTO)
        {
            var json = JsonSerializer.Serialize(baseDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PutAsync("ValorReferencia", content);
            return response;
        }
    }
}
