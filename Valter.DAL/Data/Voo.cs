using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valter.DAL.Base;

namespace Valter.DAL.Data
{
    public class Voo
    {
        /// <summary>
        ///  Cadastra - Método para cadastro de voo.
        /// </summary>
        /// <param name="_voo"></param>
        /// <returns></returns>
        /// 

        private List<Valter.DAO.Voo> lstVoo = null;
        public bool Cadastra(Valter.DAO.Voo _voo)
        {
            // Aqui eu monto o comando para o comando de insert 
            var cmd = "INSERT INTO TB_VOO (DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) VALUES (@Data, @Custo, @Distancia, @Captura, @NivelDor)";

            // Aqui eu crio a variavel sqlParamenter
            var sqlParameter = new List<SQLiteParameter>();

            // Aqui eu monto os parametros com os valores a ser salvo na base
            sqlParameter.Add(new SQLiteParameter("@Data", _voo.DATA_VOO));
            sqlParameter.Add(new SQLiteParameter("@Custo", _voo.CUSTO));
            sqlParameter.Add(new SQLiteParameter("@Distancia", _voo.DISTANCIA));
            sqlParameter.Add(new SQLiteParameter("@Captura", _voo.CAPTURA.ToString()));
            sqlParameter.Add(new SQLiteParameter("@NivelDor", _voo.NIVEL_DOR));

            // Aqui eu passo comando aexecutar mais os parametros com valores.
            return Connection.Executar(cmd, sqlParameter);
        }

        public bool Altera(Valter.DAO.Voo _voo)
        {
            // Aqui eu monto o comando para o comando de update 
            var cmd = @"UPDATE TB_VOO 
                           SET DATA_VOO = @Data, 
                               CUSTO = @Custo, 
                               DISTANCIA = @Distancia,
                               CAPTURA = @Captura, 
                               NIVEL_DOR = @NivelDor
                         WHERE ID_VOO = @id_voo";

            // Aqui eu crio a variavel sqlParamenter
            var sqlParameter = new List<SQLiteParameter>();

            // Aqui eu monto os parametros com os valores a ser salvo na base
            sqlParameter.Add(new SQLiteParameter("@Data", _voo.DATA_VOO));
            sqlParameter.Add(new SQLiteParameter("@Custo", _voo.CUSTO));
            sqlParameter.Add(new SQLiteParameter("@Distancia", _voo.DISTANCIA));
            sqlParameter.Add(new SQLiteParameter("@Captura", _voo.CAPTURA.ToString()));
            sqlParameter.Add(new SQLiteParameter("@NivelDor", _voo.NIVEL_DOR));
            sqlParameter.Add(new SQLiteParameter("@id_voo", _voo.ID_VOO));

            // Aqui eu passo comando para executar mais os parametros com valores.
            return Connection.Executar(cmd, sqlParameter);            
        }

        public bool Deleta(Valter.DAO.Voo _voo)
        {
            // Aqui eu monto o comando para o comando de deletar 
            var cmd = @"DELETE FROM TB_VOO WHERE ID_VOO = @id_voo";

            // Aqui eu crio a variavel sqlParamenter
            var sqlParameter = new List<SQLiteParameter>();

            // Aqui eu monto os parametros com os valores a ser excluido da base            
            sqlParameter.Add(new SQLiteParameter("@id_voo", _voo.ID_VOO));

            // Aqui eu passo comando a executar mais os parametros com valores.
            return Connection.Executar(cmd, sqlParameter);
        }

        public List<DAO.Voo> Consulta(int id)
        {
            string sql = "SELECT * FROM TB_VOO WHERE ID_VOO = @ID_VOO";

            // Aqui eu crio a variavel sqlParamenter
            var sqlParameter = new List<SQLiteParameter>();

            // Aqui eu monto os parametros com os valores para a consulta
            sqlParameter.Add(new SQLiteParameter("@ID_VOO", id));

            DataSet ds = Connection.Read(sql, null);

            if (ds.Tables.Count > 0)
            {
                DataSetList(ds);
            }

            return (ds.Tables.Count > 0 ? lstVoo : new List<DAO.Voo>());
        }

        public List<DAO.Voo> ListaTodos()
        {
            string sql = "SELECT * FROM TB_VOO ORDER BY 1";

            DataSet ds = Connection.Read(sql, null);

            if (ds.Tables.Count > 0)
            {
                DataSetList(ds);
            }

            return (ds.Tables.Count > 0 ? lstVoo : new List<DAO.Voo>());
        }

        private void DataSetList(DataSet ds)
        {
            lstVoo = new List<DAO.Voo>();

            for (var i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                lstVoo.Add(new DAO.Voo()
                {
                    ID_VOO = Convert.ToInt32(ds.Tables[0].Rows[i]["ID_VOO"]),
                    DATA_VOO = Convert.ToDateTime(ds.Tables[0].Rows[i]["DATA_VOO"]),
                    CUSTO = Convert.ToDouble(ds.Tables[0].Rows[i]["CUSTO"]),
                    DISTANCIA = Convert.ToInt32(ds.Tables[0].Rows[i]["DISTANCIA"]),
                    CAPTURA = Convert.ToChar(ds.Tables[0].Rows[i]["CAPTURA"].ToString()),
                    NIVEL_DOR = Convert.ToInt32(ds.Tables[0].Rows[i]["NIVEL_DOR"])
                });
            }
        }
    }
}
