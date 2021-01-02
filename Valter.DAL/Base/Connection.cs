using System.Reflection;
using System.Configuration;
using System.Data.SQLite;
using System.Collections.Generic;
using System;
using System.Data;

namespace Valter.DAL.Base
{
    public static class Connection
    {
        private static string _stringConnection = System.Configuration.ConfigurationManager.ConnectionStrings["SqLiteConnectionString"].ToString();
        private static string _SqliteBase = System.Configuration.ConfigurationManager.AppSettings["SqliteBase"].ToString();
        private static string _SqliteVersion = System.Configuration.ConfigurationManager.AppSettings["SqliteVersion"].ToString();
        private static string _diretorioBase = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        private static string _CaminhoBase = _stringConnection + _diretorioBase + _SqliteBase + ";" + _SqliteVersion;

        private static SQLiteConnection _sqliteConnection;
        private static DataSet ds = null;
                
        public static SQLiteConnection SqliteConnection()
        {
            //_stringConnection + _diretorioBase
            _sqliteConnection = new SQLiteConnection(_CaminhoBase);
            _sqliteConnection.Open();

            return _sqliteConnection;

        }

        public static bool Executar(string SqlQuery, List<SQLiteParameter> param = null)
        {
            try
            {
                using (var cmd = new SQLiteCommand())
                {
                    cmd.CommandText = SqlQuery;
                    cmd.Connection = SqliteConnection();

                    if (param != null)
                        if (param.Count > 0)
                            foreach (var p in param)
                            {
                                cmd.Parameters.Add(p);
                            }
                    var linha = cmd.ExecuteNonQuery();

                    if (linha > 0)
                        return true;
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message.ToString());
            }
            return false;
        }

        public static DataSet Read(string SqlQuery, List<SQLiteParameter> param = null)
        {
            try
            {
                using (var cmd = new SQLiteCommand())
                {
                    cmd.CommandText = SqlQuery;
                    cmd.Connection = SqliteConnection();

                    if (param != null)
                        if (param.Count > 0)
                            foreach (var p in param)
                            {
                                cmd.Parameters.Add(p);
                            }
                    var dr = new SQLiteDataAdapter(cmd);
                    ds = new DataSet();
                    dr.Fill(ds);
                }
            }
            catch (Exception ex)
            {
                new Exception(ex.Message.ToString());
            }
            return ds;
        }

        public static bool ExisteBase()
        {
            return false;
        }

        public static bool CreateBase()
        {
            return false;
        }
    }
}
