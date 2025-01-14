using C_LN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Test_4
{
    public partial class AgendaInterfaz : Form 
    {
        static SqlConnection sqlConnection = new SqlConnection("Server = localhost; Database = prog2; Trusted_Connection = True");
        static ManipulacionAgenda agendaImplementacion = new ManipulacionAgenda(sqlConnection);
        static MetodosInterfaz metodos = new MetodosInterfaz();
        public AgendaInterfaz()
        {
            InitializeComponent();
        }
        //Precarga
        private void AgendaInterfaz_Load(object sender, EventArgs e)
        {
            // Esta línea de código carga datos en la tabla 'agendaDataSet.Agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.agendaDataSet.Agenda);
            AgendaDataGridView.ClearSelection();
        }
        //Los metodos implementados en los botones
        private void FlatButtonAñadir_Click(object sender, EventArgs e)
        {
            DateTime FechaHora = DatepickerFechaEvento.Value;
            metodos.MetodAgregar(agendaImplementacion, TextboxEvento.Text, FechaHora);
            RefreshData();
        }

        private void FlatButtonEditar_Click(object sender, EventArgs e)
        {
            DateTime FechaHora = DatepickerFechaEvento.Value;
            metodos.MetodEditar(AgendaDataGridView, agendaImplementacion, TextboxEvento.Text, FechaHora);
            RefreshData();
        }

        private void FlatButtonEliminar_Click(object sender, EventArgs e)
        {
            metodos.MetodEliminar(AgendaDataGridView, agendaImplementacion);
            RefreshData();
        }
        //Este metodo se encarga de cargar la informacion seleccionada en el DataGridView
        private void AgendaDataGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(AgendaDataGridView.SelectedRows.Count > 0)
            {
                int Row = AgendaDataGridView.SelectedRows[0].Index;
                if (TextboxEvento.Text != null)
                {
                    TextboxEvento.Text = AgendaDataGridView.Rows[Row].Cells["eventoDataGridViewTextBoxColumn"].Value.ToString();
                }
                if (AgendaDataGridView.Rows[Row].Cells["fechaEventoDataGridViewTextBoxColumn"].Value != null)
                {
                    DateTime dateTime = (DateTime)AgendaDataGridView.Rows[Row].Cells["fechaEventoDataGridViewTextBoxColumn"].Value;
                    DatepickerFechaEvento.Value = dateTime;
                }
            }
        }
        //Metodo comun que uso para refrescar al hacer cambios
        private void RefreshData()
        {
            this.agendaTableAdapter.Fill(this.agendaDataSet.Agenda);
            this.AgendaDataGridView.Refresh();
        }
        //Este es el evento con la implementacion del metodo de busqueda.
        private void MaterialTextboxBuscador_OnValueChanged(object sender, EventArgs e)
        {
            if (MaterialTextboxBuscador.Text == "Buscar" || MaterialTextboxBuscador.Text == null)
            {
                AgendaDataGridView.DataSource = agendaDataSet.Agenda;
                RefreshData();
            }
            else
            {
                metodos.MetodBuscar(agendaImplementacion, MaterialTextboxBuscador.Text, AgendaDataGridView);
            }
        }
        //Estos metodos son los que se encargan de poner el texto predefinido de los TextBox
        private void MaterialTextboxBuscador_Enter(object sender, EventArgs e)
        {
            if(MaterialTextboxBuscador.Text == "Buscar")
            {
                MaterialTextboxBuscador.Text = "";
                MaterialTextboxBuscador.ForeColor = Color.Black;
            }
        }
        private void MaterialTextboxBuscador_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaterialTextboxBuscador.Text))
            {
                MaterialTextboxBuscador.Text = "Buscar";
                MaterialTextboxBuscador.ForeColor = Color.Gray;
            }
        }
        private void TextboxEvento_Enter(object sender, EventArgs e)
        {
            if(TextboxEvento.Text == "Evento")
            {
                TextboxEvento.Text = "";
                TextboxEvento.ForeColor = Color.Black;
            }
        }
        private void TextboxEvento_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextboxEvento.Text))
            {
                TextboxEvento.Text = "Evento";
                TextboxEvento.ForeColor = Color.Gray;
            }
        }
        //Este se encarga de limpiar la seleccion luego de seleccionar del DataGridView
        private void AgendaDataGridView_Leave(object sender, EventArgs e)
        {
            AgendaDataGridView.ClearSelection();
        }
    }
}
