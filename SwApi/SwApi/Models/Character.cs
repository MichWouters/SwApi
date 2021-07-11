using System;

namespace SwApi.Models
{
    public class Character
    {
        public DateTime Edited { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public string Gender { get; set; }
        public string skin_color { get; set; }
        public string hair_color { get; set; }
        public string Height { get; set; }
        public string EyeColor { get; set; }
        public string Mass { get; set; }
        public int Homeworld { get; set; }
        public string birth_year { get; set; }
        public string Image { get; set; }
        public int Id { get; set; }
        public int?[] Vehicles { get; set; }
        public int?[] Starships { get; set; }
        public int?[] Films { get; set; }
    }
}