using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_D;
namespace C_LN
{
    //Esta clase es donde se declaran todos los metodos que se utilizaran en la interfaz
    public class MetodosInterfaz
    {
        //Metodo encargado de agregar los eventos(Agendar las cosas) a la agenda.
        public void MetodAgregar(ManipulacionAgenda manipulacionAgenda, string Evento, DateTime FechaEvento)
        {
            try
            {
                if (Evento == null || FechaEvento == null)
                {
                    MessageBox.Show("Los campos solicitados deben estar llenos");
                    return;
                }
                manipulacionAgenda.InsertEntry(Evento, FechaEvento, null, null, null);
            }
            catch (Exception ex)
            {
                manipulacionAgenda.Conn.Close();
                MessageBox.Show("Ha ocurrido la siguiente exepcion: " + ex.ToString());
            }
        }
        //Metodo encargado de la eliminacion de los mismos
        public void MetodEliminar(DataGridView dataGrid, ManipulacionAgenda manipulacionAgenda)
        {
            try
            {
                DialogResult result = MessageBox.Show("Seguro desea eliminar el evento?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (dataGrid.SelectedRows.Count == 1)
                    {
                        int Index = dataGrid.SelectedRows[0].Index;
                        int ID = (int)dataGrid.Rows[Index].Cells[0].Value;
                        manipulacionAgenda.DeleteEntry(ID);
                        MessageBox.Show("Se ha eliminado la entrada");
                    }
                }
            }
            catch (Exception ex)
            {
                manipulacionAgenda.Conn.Close();
                MessageBox.Show("Ha ocurrido la siguiente exepcion: " + ex.ToString());
            }
        }
        //Metodo para la edicion de los mismos
        public void MetodEditar(DataGridView dataGrid, ManipulacionAgenda manipulacionAgenda, string Evento, DateTime FechaEvento)
        {
            try
            {
                if (dataGrid.SelectedRows.Count == 1)
                {
                    int Index = dataGrid.SelectedRows[0].Index;
                    int ID = (int)dataGrid.Rows[Index].Cells[0].Value;
                    manipulacionAgenda.UpdateEntry(ID, Evento, FechaEvento, null, null, null);
                    MessageBox.Show("Se ha editado la entrada");
                }
            }
            catch (Exception ex)
            {
                manipulacionAgenda.Conn.Close();
                MessageBox.Show("Ha ocurrido la siguiente exepcion: " + ex.ToString());
            }
        }
        //Metodo para la busqueda, este permite buscar tanto los eventos como la fecha de estos, siguiendo el Formato dd/mm/yyyy
        public void MetodBuscar(ManipulacionAgenda manipulacionAgenda, string Busqueda, DataGridView dataGridView)
        {
            try
            {
                DataTable dataTable = manipulacionAgenda.SearchByEvento(Busqueda);
                dataGridView.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                manipulacionAgenda.Conn.Close();
                MessageBox.Show("Ha ocurrido la siguiente exepcion: " + ex.ToString());
            }
        }
    }
}
