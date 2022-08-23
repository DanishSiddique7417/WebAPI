using System.ComponentModel.DataAnnotations;

namespace WebAPI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }

    public class MyDetails
    {
        public int EmpID { get; set; }
        public string Name { get; set; }

        public string Designation { get; set; }
        public string Address { get; set; }
        
        public long Mobile { get; set; }



    }

    public class UserModel
    {
        [Required] 
        public string Email { get; set; }
        [Required]
        public  string Password { get; set; }
    }

    public class Tokens
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }

    public class Users
    {
        public string Name { get; set; }
        public string Password { get; set; }
        

    }

   
}