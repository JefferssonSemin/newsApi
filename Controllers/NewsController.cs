using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsApi.Data;
using NewsApi.DTOs;
using Newtonsoft.Json;

namespace NewsApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class NewsController : ControllerBase
    {
        private readonly SqLiteDbContext _sqLiteDbContext;

        public NewsController(SqLiteDbContext dbContext)
        {
            _sqLiteDbContext = dbContext;
        }

        [HttpGet]
        public string Index()
        {
            var news = _sqLiteDbContext.Find<New>();

            var result = JsonConvert.SerializeObject(news);

            return result;
        }

        [HttpPost]
        public bool Create(New letter)
        {
            var checkEscroto = false;

            try
            {
                _sqLiteDbContext.Add(letter);
                checkEscroto = true;
            }
            catch (InvalidCastException ex)
            {
                checkEscroto = false;
            }

            return checkEscroto;
        }
    }
}