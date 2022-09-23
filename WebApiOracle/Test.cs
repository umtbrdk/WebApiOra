using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiOracle
{
    [ApiController]
    [Route("api/[controller]")]
    public class Test : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "sa";
        }

        [HttpGet("{_a}")]
        public string GetUmut(int _a)
        {
            return Hesapla(_a);
        }

        public string Hesapla(int sayi)
        {
            int a = sayi;
            int sonuc = a + 2;
            if (sonuc == 10)
            {
                return "abc";
            }
            else
                return "bilmiyorum";
        }
    }
}
