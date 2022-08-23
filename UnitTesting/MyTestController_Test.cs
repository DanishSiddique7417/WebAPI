using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WebAPI;
using WebAPI.Controllers;
using WenRepository;

namespace UnitTesting
{
    public  class MyTestController_Test
    {
        public readonly IConfiguration configuration;
        public readonly ApplicationContext cont=null;


        //[Fact]
        //public void When_GetSum_Expected_SumofDigit()
        //{

        //    MyTestController cntr = new MyTestController();
        //    var Result = cntr.GetSum(5, 6);
        //    Assert.Equal(11, Result);


        //}

        //[Fact]
        //public async Task When_GetTEsting_NotNull()
        //{
        //    MyTestController cntr = new MyTestController();

        //    var result = cntr.GetUser;
        //    Assert.NotNull(result);
        //}

        //[Fact]
        //public async Task When_GetUser_New_NotNull()
        //{
        //    MyTestController cntr = new MyTestController();
        //    var result = cntr.GetUser_New;
        //    Assert.NotNull(result);


        //}


    }
}
