using ApiClientLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientLibrary.Services
{
    public  interface IServices
    {
        public  Task<HttpResponseMessage> Leer();
        public Task<HttpResponseMessage> Guardar(IBaseDTO baseDTO);
        public Task<HttpResponseMessage> Actualizar(IBaseDTO baseDTO);

        public void SetToken(string token);


    }
}
