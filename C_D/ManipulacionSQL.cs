using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace C_D
{
    public abstract class ManipulacionSQL
    {
        public abstract SqlConnection Conn { get; set; }
        public ManipulacionSQL(SqlConnection Conn) { 
            this.Conn = Conn;
        }
        public abstract void DeleteEntry(int Index);
        public abstract void InsertEntry(String campo1, string campo2, string campo3, string campo4,string campo5);
        public abstract void UpdateEntry(int Index, String campo1, string campo2, string campo3, string campo4, string campo5);
    }
}
