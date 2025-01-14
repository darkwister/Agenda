using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_D;
namespace C_LN
{
    public class ManipulacionAgenda : ManipulacionSQL
    {
        public override SqlConnection Conn { get; set; }
        public ManipulacionAgenda(SqlConnection Conn) : base(Conn) => Conn.ConnectionString = "Server = localhost; Database = prog2; Trusted_Connection = True";
        //Metodos heredados, algunos no usados
        public override void DeleteEntry(int Index)
        {
            string DeleteQuery = "Delete from Agenda where IDEvento = " + Index + ";";
            SqlCommand DeleteExecute = new SqlCommand(DeleteQuery, Conn);
            Conn.Open();
            DeleteExecute.ExecuteNonQuery();
            Conn.Close();
        }
        public override void InsertEntry(string campo1, string campo2, string campo3, string campo4, string campo5) => throw new NotImplementedException();
        public override void UpdateEntry(int Index, string NombreEvento, string FechaEvento, string nullable, string nullable1, string nullable2) => throw new NotImplementedException();
        //Metodos
        public void InsertEntry(string NombreEvento, DateTime FechaEvento, string nullable, string nullable1, string nullable2)
        {
            string InsertQuery = "Insert into Agenda(Evento, FechaEvento) values(@NombreEvento, @FechaEvento);";
            SqlCommand InsertExecute = new SqlCommand(InsertQuery, Conn);
            InsertExecute.Parameters.AddWithValue("@NombreEvento", NombreEvento);
            InsertExecute.Parameters.AddWithValue("@FechaEvento", FechaEvento);
            Conn.Open();
            InsertExecute.ExecuteNonQuery();
            Conn.Close();
        }
        public void UpdateEntry(int Index, string NombreEvento, DateTime FechaEvento, string nullable, string nullable1, string nullable2)
        {  
            string UpdateQuery = "Update Agenda set Evento = @NombreEvento, FechaEvento = @FechaEvento where IDEvento = @ID;";
            SqlCommand UpdateExecute = new SqlCommand(UpdateQuery, Conn);
            UpdateExecute.Parameters.AddWithValue("@NombreEvento", NombreEvento);
            UpdateExecute.Parameters.AddWithValue("@FechaEvento", FechaEvento);
            UpdateExecute.Parameters.AddWithValue("@ID", Index);
            Conn.Open();
            UpdateExecute.ExecuteNonQuery();
            Conn.Close();
        }
        public DataTable SearchByEvento(string searchTerm)
        {
            DataTable dataTable = new DataTable();
            try
            {
                string selectQuery = "SELECT * FROM Agenda WHERE Evento LIKE @SearchTerm OR CONVERT(VARCHAR(10), FechaEvento, 103) LIKE @SearchTerm";
                SqlCommand selectCommand = new SqlCommand(selectQuery, Conn);
                selectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(selectCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return dataTable;
        }
    }
}
