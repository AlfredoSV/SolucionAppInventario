using AppInventario.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppInventario.Controllers
{
    public class BaseController : Controller
    {
        public Task<HttpResponseMessage> GetReq(string url)
        {
            using (var cliente = new HttpClient())
            {

                var respuesta = cliente.GetAsync(new Uri(url));
                respuesta.Wait();

                return respuesta;

            }
        }
        public Task<HttpResponseMessage> PostReq(string url, HttpContent httpContent)
        {
            using (var cliente = new HttpClient())
            {
         
                var respuesta = cliente.PostAsync(new Uri(url), httpContent);
                respuesta.Wait();

                return respuesta;


            }
        }

        public Task<HttpResponseMessage> PutReq(string url, HttpContent httpContent)
        {
            using (var cliente = new HttpClient())
            {
                
   
                var respuesta = cliente.PutAsync(new Uri(url), httpContent);
                respuesta.Wait();

                return respuesta;

            }
        }

        public Task<HttpResponseMessage> DeleteReq(string url)
        {
            using (var cliente = new HttpClient())
            {

                var respuesta = cliente.DeleteAsync(new Uri(url));
                respuesta.Wait();

                return respuesta;

            }
        }




    }
}
