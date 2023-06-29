using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using System.Xml.Linq;

namespace Lab1.Controllers
{
    public class WeatherData
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Degree { get; set; }
        public string Location { get; set; }
    }
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> Summaries = new()
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        private static List<WeatherData> weatherDatas = new()
        {
        new WeatherData(){Id = 1,Date = "21.01.2022", Degree = 10, Location = "Мурманкс"},
        new WeatherData(){Id = 23,Date = "19.08.2019", Degree = 20, Location = "Пермь"},
        new WeatherData(){Id = 24,Date = "05.11.2020", Degree = 15, Location = "Омск"},
        new WeatherData(){Id = 25,Date = "07.02.2021", Degree = 0, Location = "Томск"},
        new WeatherData(){Id = 30,Date = "30.05.2022", Degree = 2, Location = "Москва"},
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<WeatherData> GetAll()
        {
            return weatherDatas;
        }
        [HttpPost]
        public IActionResult Add(WeatherData data)
        {
            if (data.Id<0)
            {
                return BadRequest("Id меньше 0");
            }
            for (int i = 0; i < weatherDatas.Count; i++)
            {
                if (weatherDatas[i].Id == data.Id)
                {
                    return BadRequest("Записьс таким Id уже есть");
                }
            }
            weatherDatas.Add(data);
            return Ok();
        }
        [HttpPut]
        public IActionResult update(WeatherData data) 
        {
            if (data.Id < 0)
            {
                return BadRequest("Id меньше 0");
            }
            for (int i = 0; i < weatherDatas.Count; i++)
            {
                if (weatherDatas[i].Id == data.Id)
                {
                    weatherDatas[i] = data;
                    return Ok();
                }
            }
            return BadRequest("Нет такой записи");
        }
        [HttpDelete]
        public IActionResult Delete(int Id) 
        {
            for(int i = 0;i< weatherDatas.Count;i++)
            {
                if (weatherDatas[i].Id == Id) 
                {
                    weatherDatas.RemoveAt(i);
                    return Ok();
                }
            }
            return BadRequest("Нет такой записи");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            for(int i = 0; i<weatherDatas.Count;i++)
            {
                if (weatherDatas[i].Id == id)
                {
                    return Ok(weatherDatas[i]);
                }
            }
            return BadRequest("Нет такой записи");
        }
        [HttpGet("find-by-city")]
        public IActionResult GetByCityName(string location)
        {
            for (int i = 0; i < weatherDatas.Count; i++)
            {
                if (weatherDatas[i].Location.ToLower() == location.ToLower())
                {
                    return Ok("Запись с указанным городом имеется в нашем списке");
                }
            }
            return BadRequest("Запись с указанным городом не обнаружено");
        }
    }
}