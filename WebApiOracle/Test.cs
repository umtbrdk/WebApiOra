using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;

namespace WebApiOracle
{
    [ApiController]
    [Route("api/[controller]")]
    public class Test : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return son;
        }

        [HttpGet("{_a}")]
        public string GetUmut(int _a)
        {
            return MalzemeGetir(_a);
        }

        public string Hesapla(int sayi)
        {
            int a = sayi;
            int sonuc = a + 2;
            if (sonuc == 10)
            {
                return "eşit";
            }
            else
                return "değil";
        }
        public static string son = "";
       

        public static string  MalzemeGetir(int arizaNo)
        {

            string cmdtxt = @"select * from hastane.tek_ariza where ariza_no =" + arizaNo; ;
            string sonuc = "";
            try
               
            {
                System.Data.DataTable dataTable = new System.Data.DataTable();
                using (OracleConnection conn = new OracleConnection(Database.connstr))
                using (OracleCommand cmd = new OracleCommand(cmdtxt, conn))
                {
                    conn.Open();

                    
                    // reader is IDisposable and should be closed
                    using (OracleDataReader dr = cmd.ExecuteReader())
                    {
                        //List<String> items = new List<String>();
                        if (dr.HasRows)
                        {
                            
                            dataTable.Load(dr);
                            //while (dr.Read())
                            //{
                            //    sonuc = (dr[0].ToString());
                            //}
                        }
                    }
                }
                return dataTable.ToString() ;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
