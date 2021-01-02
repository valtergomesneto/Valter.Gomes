using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Valter.DAL.Base
{
    public static class CreateDataBase
    {
        /// <summary>
        /// _DiretorioLocal - Pega o nome do diretorio local da aplicação
        /// _SqliteBase     - Pega o nome arquivo Sqlite do app.config
        /// _CaminhoBase    - Seta o Caminho da base de dado 
        /// </summary>
        private static string _DiretorioLocal = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        private static string _SqliteBase = System.Configuration.ConfigurationManager.AppSettings["SqliteBase"].ToString();
        private static string _CaminhoBase = "";

        /// <summary>
        /// Método para criação da base de dado sqlite
        /// </summary>
        public static void CreateDbase()
        {
            try
            {
                // Seta diretorio do sqlite
                _CaminhoBase = _DiretorioLocal + _SqliteBase;

                // Pega a informação do caminho onde está a base de dado
                DirectoryInfo dirInfo = new DirectoryInfo(_CaminhoBase);

                // Verificar se existe a base de dado. 
                if (!dirInfo.Name.Contains("acme.sqlite"))
                {
                    //Em caso de não existi é criada no diretorio da aplicação.
                    SQLiteConnection.CreateFile(_CaminhoBase);
                    // Chamada do método de criação da tabela tb_voo
                    CreateTable();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
        /// <summary>
        /// Método para criação da tabela TB_VOO na base de dado acme.sqlite
        /// </summary>
        private static void CreateTable()
        {
            try
            {
                using (var comm = new SQLiteCommand(Connection.SqliteConnection()))
                {
                    comm.CommandText = @"CREATE TABLE IF NOT EXISTS TB_VOO (ID_VOO INTEGER PRIMARY KEY AUTOINCREMENT,
                                                                            DATA_VOO DATETIME NOT NULL,
                                                                            CUSTO NUMERIC(10,2) NOT NULL,
                                                                            DISTANCIA INT NOT NULL, 
                                                                            CAPTURA CHAR(1) NOT NULL,
                                                                            NIVEL_DOR INT NOT NULL)";
                    comm.ExecuteNonQuery();
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
    }
}
