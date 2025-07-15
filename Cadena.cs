using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto_DesarrolloSoftware
{
    internal class Cadena
    {
        private readonly string conexionString = "Server=mssql-199159-0.cloudclusters.net,10002;Database=implementacion;User Id=freed;Password=Homofredus1;Encrypt=True;TrustServerCertificate=False;";

        public string ConexionString
        {
            get { return conexionString; }

        }

        public SqlConnection Conectar()
        {
            return new SqlConnection(conexionString);
        }
    }

}
