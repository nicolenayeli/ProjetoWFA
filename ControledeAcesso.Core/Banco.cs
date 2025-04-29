using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControledeAcesso.Core
{
    using MySql.Data.MySqlClient;

    namespace ControleAcesso.Core

    {

        public static class Banco

        {

            public static MySqlCommand Abrir()

            {

                MySqlCommand cmd = new MySqlCommand();

                string strConn = @"server=10.91.47.25;database=projetowfa;user=root;password="; // server local

                MySqlConnection cn = new(strConn);

                try

                {

                    cn.Open();

                    cmd.Connection = cn;

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex.Message);

                }

                return cmd;

            }

        }

    }


}
