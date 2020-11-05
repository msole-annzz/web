using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Модель  — это набор классов, представляющих данные, которыми управляет приложение. 
namespace MyApi.Models
{
    public class MyItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }
    }
    //Чтобы продемонстрировать подход с применением DTO, обновите класс TodoItem, включив в него поле секрета:
    //код не отображался в статье, DTO не заработало
    //https://docs.microsoft.com/ru-ru/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.1&tabs=visual-studio
    public class MyItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

}
