using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations.Schema;
 using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WenRepository;
using WenRepository.Entity;
using System.Text.Json;
using Azure.Storage.Queues;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = Microsoft.AspNetCore.Authentication.JwtBearer.JwtBearerDefaults.AuthenticationScheme)]
    public class MyTestController : ControllerBase
    {
        Dictionary<string, string> UsersRecords = new Dictionary<string, string>
    {
        { "user1","password1"},
        { "user2","password2"},
        { "user3","password3"},
    };
        public readonly IConfiguration configuration;
        public readonly ApplicationContext cont;

        //public MyTestController()
        //{
        //}
        public MyTestController(IConfiguration _config,ApplicationContext contt)
        { 
        configuration=_config;
            cont= contt;
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult sendqueuemessage(string mess)
        {
            //Console.WriteLine($"C# Timer trigger function executed at: {DateTime.Now}");
            var connectionString = "DefaultEndpointsProtocol=https;AccountName=learningqueuestorage;AccountKey=yaOw85i+gvP6+V+Vx4MogHkoZbYrSO4zpFCIoEeaaKflATo0pJ1Vd/sB3gDTXvboa4id2zxG+q8l+AStuEaOBw==;EndpointSuffix=core.windows.net";

            var queuename = "learningqueue";
            var Queclint = new QueueClient(connectionString, queuename);
            // var message = "First message to be stored in queue";
            var abc = Queclint.ReceiveMessages(2);
            var serializemessage = JsonSerializer.Serialize(mess);
            Queclint.SendMessageAsync(serializemessage);
            return Ok();
        }

        [NonAction]
        public IEnumerable<TblUser> GetUser()
        {
            return cont.tblUsers;
        }

        [HttpGet]
        public int GetSum(int a,int b)
        { 
        return (a+b);
        }

        [HttpGet]
        public int? GetInteger(int? digitt,string abc)
        {
            int a = 80;
            abc = abc ?? "Danish";
            digitt = digitt ?? a ;
            return digitt;
        }

        [HttpPost]
        [ActionName("CreateTesting")]
        [AllowAnonymous]
        public ActionResult AddUser(Testing11 test)
        {
            List<Testing11> lstobj = new List<Testing11>();
           
            for(int a=0;a<5;a++)
            {
                Testing11 testobj = new Testing11();
                testobj.Id = a;
                testobj.Name = "danish"+a;

            }
           // cont.Testing11.Select()
            cont.Testing11.AddRange(test);
            cont.SaveChanges();
            return Ok();
        }
        [HttpPost]
        [ActionName("GetTesting_New")]
        [AllowAnonymous]
        public ActionResult GetUser_New()
        {

            var abc = cont.tblUsers;
            
            return Ok(abc);
        }


        [HttpPost]
        [ActionName("CreateUser")]
        [AllowAnonymous]
        public ActionResult AddUser(TblUser user)
        {
            
            cont.tblUsers.Add(user);
            cont.SaveChanges();
            return Ok();
        }
        [HttpPost]
        [ActionName("CreateEmployee")]
        [AllowAnonymous]
        public ActionResult AddUser(Employeeinsert emp)
        {
            Employee emp1 = new Employee();
            emp1.EmployeeName = emp.EmployeeName;
            emp1.CreatedDate = emp.CreatedDate;
            cont.Employee.Add(emp1);
            cont.SaveChanges();
            return Ok();
        }


        [AllowAnonymous]
        [HttpPost]
        [ActionName("Authenticate")]
        public ActionResult Authenticate(Users userdata)
        {
            var Token = GetToken(userdata);

            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(Token),
                expiration = Token.ValidTo
            });
        }


        [HttpPost(Name = "MyInformation")]
        [ActionName("DanishDetails")]
        public IActionResult GetDetails()
        {
            MyDetails obj = new MyDetails();

            obj.EmpID = 11710;
            obj.Name = "Danish";
            obj.Address = "Afzalgarh";
            obj.Designation = "Senior Software Engineer";
            obj.Mobile = 8077869820;

            return Ok(obj);
            
        }
       [AllowAnonymous]
        [ResponseCache(Duration =600)]
        [HttpGet]
        public ActionResult GetCachDate()
        {
            
           
            return Ok(DateTime.UtcNow);
        }



        [NonAction]
        public JwtSecurityToken GetToken(Users users)
        {
            if (!UsersRecords.Any(x => x.Key == users.Name && x.Value == users.Password))
            {
                return null;
            }
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:SecretKey"]));
            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,"Danish"),
                    new Claim(ClaimTypes.Role,"Admin"),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
            var token = new JwtSecurityToken(
                issuer: configuration["JWT:Issuer"],
                audience: configuration["JWT:Audience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }



    }
    public class Employeeinsert
    {
        
        public int Id { get; set; }
        public string? EmployeeName { get; set; }

        public DateTime CreatedDate { get; set; }

        public int UserId { get; set; }
        
    }

    public static class extns
    {
        public static string title(ref string str)
        {
            var abc = str[0].ToString().ToUpper();
            var xyz = abc + str;

            return xyz;


        }

        public static int ccount(ref string str)
        {
            var abc = str[0].ToString().ToUpper();
            var xyz = abc + str;

            return xyz.Length;


        }

    }


}
