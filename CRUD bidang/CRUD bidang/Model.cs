using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CRUD_bidang
{
    internal class Model
    {
        public NpgsqlConnection DbConnection;
        public Model()
        {
            this.DbConnection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123;Database=el");
        }
        public int getIdBidang (string bidang)
        {
            int id = 0;
            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT id FROM \"bidang\" WHERE bidang = '{bidang}'",DbConnection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while ( reader.Read() )
            {
                id = (int)reader[0];
            }
            reader.Close();
            return id;
        }
        public List<string> getAllBidang()
        {
            List<string> list = new List<string>();
            NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM \"bidang\"",DbConnection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read() )
            {
                list.Add((string)reader[1]);
            }
            return list;
        }
    }
}
