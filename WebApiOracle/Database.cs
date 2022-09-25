using System;

namespace WebApiOracle
{
    public class Database
    {
        public static string dbAdres, dbKullAdi, dbSifre, connstr;
        public static DateTime guncelTar;
        public static string ConnStr(string _dbAdres, string _dbKullAdi, string _dbSifre)
        {
            dbAdres = _dbAdres;
            connstr = "data source=" + dbAdres + ";user id=" + _dbKullAdi + ";password=" + _dbSifre + ";";
            return connstr;
        }

    }

}
