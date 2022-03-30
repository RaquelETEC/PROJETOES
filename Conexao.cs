using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teladelogin
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();
        //construtor 
        public Conexao()
        {
            con.ConnectionString = "";
        }
        //metodo  conectar 
      //  public SqlConnection conectar()
      //  {
 //           return;

   //     }
        //metodo desconectar 
        public void desconectar()
        {

        }
    }
}
