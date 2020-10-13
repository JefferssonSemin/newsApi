
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NewsApi.DTOs;
using Newtonsoft.Json;

namespace NewsApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class NewsController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
           
            var news = new List<New>();


            news.Add(new New
            {
                Title = "Teste",
                Description = "Aqui voce deixa sua descricao"
            });
            
            var result =  JsonConvert.SerializeObject(news);

            return result;
        }
    }
}