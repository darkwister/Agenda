namespace Test_4
{
    partial class AgendaInterfaz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaInterfaz));
            this.AgendaDataGridView = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.iDEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaDataSet = new Test_4.AgendaDataSet();
            this.FlatButtonAñadir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FlatButtonEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FlatButtonEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TextboxEvento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.agendaTableAdapter = new Test_4.AgendaDataSetTableAdapters.AgendaTableAdapter();
            this.DatepickerFechaEvento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.MaterialTextboxBuscador = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.AgendaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AgendaDataGridView
            // 
            this.AgendaDataGridView.AllowUserToAddRows = false;
            this.AgendaDataGridView.AllowUserToDeleteRows = false;
            this.AgendaDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AgendaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AgendaDataGridView.AutoGenerateColumns = false;
            this.AgendaDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.AgendaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgendaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AgendaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AgendaDataGridView.ColumnHeadersHeight = 29;
            this.AgendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDEventoDataGridViewTextBoxColumn,
            this.eventoDataGridViewTextBoxColumn,
            this.fechaEventoDataGridViewTextBoxColumn});
            this.AgendaDataGridView.DataSource = this.agendaBindingSource;
            this.AgendaDataGridView.DoubleBuffered = true;
            this.AgendaDataGridView.HeaderBgColor = System.Drawing.Color.Black;
            this.AgendaDataGridView.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgendaDataGridView.Location = new System.Drawing.Point(26, 236);
            this.AgendaDataGridView.MultiSelect = false;
            this.AgendaDataGridView.Name = "AgendaDataGridView";
            this.AgendaDataGridView.ReadOnly = true;
            this.AgendaDataGridView.RowHeadersWidth = 51;
            this.AgendaDataGridView.RowTemplate.Height = 24;
            this.AgendaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgendaDataGridView.Size = new System.Drawing.Size(556, 298);
            this.AgendaDataGridView.TabIndex = 5;
            this.AgendaDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgendaDataGrid_RowEnter);
            this.AgendaDataGridView.Leave += new System.EventHandler(this.AgendaDataGridView_Leave);
            // 
            // iDEventoDataGridViewTextBoxColumn
            // 
            this.iDEventoDataGridViewTextBoxColumn.DataPropertyName = "IDEvento";
            this.iDEventoDataGridViewTextBoxColumn.HeaderText = "IDEvento";
            this.iDEventoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDEventoDataGridViewTextBoxColumn.Name = "iDEventoDataGridViewTextBoxColumn";
            this.iDEventoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEventoDataGridViewTextBoxColumn.Visible = false;
            this.iDEventoDataGridViewTextBoxColumn.Width = 125;
            // 
            // eventoDataGridViewTextBoxColumn
            // 
            this.eventoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eventoDataGridViewTextBoxColumn.DataPropertyName = "Evento";
            this.eventoDataGridViewTextBoxColumn.HeaderText = "Evento";
            this.eventoDataGridViewTextBoxColumn.MinimumWidth = 25;
            this.eventoDataGridViewTextBoxColumn.Name = "eventoDataGridViewTextBoxColumn";
            this.eventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEventoDataGridViewTextBoxColumn
            // 
            this.fechaEventoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaEventoDataGridViewTextBoxColumn.DataPropertyName = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.HeaderText = "FechaEvento";
            this.fechaEventoDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.fechaEventoDataGridViewTextBoxColumn.Name = "fechaEventoDataGridViewTextBoxColumn";
            this.fechaEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "AgendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FlatButtonAñadir
            // 
            this.FlatButtonAñadir.Activecolor = System.Drawing.Color.DodgerBlue;
            this.FlatButtonAñadir.BackColor = System.Drawing.Color.Black;
            this.FlatButtonAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatButtonAñadir.BorderRadius = 0;
            this.FlatButtonAñadir.ButtonText = "Añadir";
            this.FlatButtonAñadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButtonAñadir.DisabledColor = System.Drawing.Color.Gray;
            this.FlatButtonAñadir.ForeColor = System.Drawing.Color.White;
            this.FlatButtonAñadir.Iconcolor = System.Drawing.Color.Transparent;
            this.FlatButtonAñadir.Iconimage = ((System.Drawing.Image)(resources.GetObject("FlatButtonAñadir.Iconimage")));
            this.FlatButtonAñadir.Iconimage_right = null;
            this.FlatButtonAñadir.Iconimage_right_Selected = null;
            this.FlatButtonAñadir.Iconimage_Selected = null;
            this.FlatButtonAñadir.IconMarginLeft = 0;
            this.FlatButtonAñadir.IconMarginRight = 0;
            this.FlatButtonAñadir.IconRightVisible = true;
            this.FlatButtonAñadir.IconRightZoom = 0D;
            this.FlatButtonAñadir.IconVisible = true;
            this.FlatButtonAñadir.IconZoom = 90D;
            this.FlatButtonAñadir.IsTab = false;
            this.FlatButtonAñadir.Location = new System.Drawing.Point(618, 236);
            this.FlatButtonAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlatButtonAñadir.Name = "FlatButtonAñadir";
            this.FlatButtonAñadir.Normalcolor = System.Drawing.Color.Black;
            this.FlatButtonAñadir.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.FlatButtonAñadir.OnHoverTextColor = System.Drawing.Color.White;
            this.FlatButtonAñadir.selected = false;
            this.FlatButtonAñadir.Size = new System.Drawing.Size(321, 59);
            this.FlatButtonAñadir.TabIndex = 6;
            this.FlatButtonAñadir.Text = "Añadir";
            this.FlatButtonAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FlatButtonAñadir.Textcolor = System.Drawing.Color.White;
            this.FlatButtonAñadir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatButtonAñadir.Click += new System.EventHandler(this.FlatButtonAñadir_Click);
            // 
            // FlatButtonEditar
            // 
            this.FlatButtonEditar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.FlatButtonEditar.BackColor = System.Drawing.Color.Black;
            this.FlatButtonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatButtonEditar.BorderRadius = 0;
            this.FlatButtonEditar.ButtonText = "Editar";
            this.FlatButtonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButtonEditar.DisabledColor = System.Drawing.Color.Gray;
            this.FlatButtonEditar.ForeColor = System.Drawing.Color.White;
            this.FlatButtonEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.FlatButtonEditar.Iconimage = ((System.Drawing.Image)(resources.GetObject("FlatButtonEditar.Iconimage")));
            this.FlatButtonEditar.Iconimage_right = null;
            this.FlatButtonEditar.Iconimage_right_Selected = null;
            this.FlatButtonEditar.Iconimage_Selected = null;
            this.FlatButtonEditar.IconMarginLeft = 0;
            this.FlatButtonEditar.IconMarginRight = 0;
            this.FlatButtonEditar.IconRightVisible = true;
            this.FlatButtonEditar.IconRightZoom = 0D;
            this.FlatButtonEditar.IconVisible = true;
            this.FlatButtonEditar.IconZoom = 90D;
            this.FlatButtonEditar.IsTab = false;
            this.FlatButtonEditar.Location = new System.Drawing.Point(618, 353);
            this.FlatButtonEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlatButtonEditar.Name = "FlatButtonEditar";
            this.FlatButtonEditar.Normalcolor = System.Drawing.Color.Black;
            this.FlatButtonEditar.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.FlatButtonEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.FlatButtonEditar.selected = false;
            this.FlatButtonEditar.Size = new System.Drawing.Size(321, 59);
            this.FlatButtonEditar.TabIndex = 7;
            this.FlatButtonEditar.Text = "Editar";
            this.FlatButtonEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FlatButtonEditar.Textcolor = System.Drawing.Color.White;
            this.FlatButtonEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatButtonEditar.Click += new System.EventHandler(this.FlatButtonEditar_Click);
            // 
            // FlatButtonEliminar
            // 
            this.FlatButtonEliminar.Activecolor = System.Drawing.Color.DodgerBlue;
            this.FlatButtonEliminar.BackColor = System.Drawing.Color.Black;
            this.FlatButtonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatButtonEliminar.BorderRadius = 0;
            this.FlatButtonEliminar.ButtonText = "Eliminar";
            this.FlatButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButtonEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.FlatButtonEliminar.ForeColor = System.Drawing.Color.White;
            this.FlatButtonEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.FlatButtonEliminar.Iconimage = ((System.Drawing.Image)(resources.GetObject("FlatButtonEliminar.Iconimage")));
            this.FlatButtonEliminar.Iconimage_right = null;
            this.FlatButtonEliminar.Iconimage_right_Selected = null;
            this.FlatButtonEliminar.Iconimage_Selected = null;
            this.FlatButtonEliminar.IconMarginLeft = 0;
            this.FlatButtonEliminar.IconMarginRight = 0;
            this.FlatButtonEliminar.IconRightVisible = true;
            this.FlatButtonEliminar.IconRightZoom = 0D;
            this.FlatButtonEliminar.IconVisible = true;
            this.FlatButtonEliminar.IconZoom = 90D;
            this.FlatButtonEliminar.IsTab = false;
            this.FlatButtonEliminar.Location = new System.Drawing.Point(618, 475);
            this.FlatButtonEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FlatButtonEliminar.Name = "FlatButtonEliminar";
            this.FlatButtonEliminar.Normalcolor = System.Drawing.Color.Black;
            this.FlatButtonEliminar.OnHovercolor = System.Drawing.Color.LightSkyBlue;
            this.FlatButtonEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.FlatButtonEliminar.selected = false;
            this.FlatButtonEliminar.Size = new System.Drawing.Size(321, 59);
            this.FlatButtonEliminar.TabIndex = 8;
            this.FlatButtonEliminar.Text = "Eliminar";
            this.FlatButtonEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FlatButtonEliminar.Textcolor = System.Drawing.Color.White;
            this.FlatButtonEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatButtonEliminar.Click += new System.EventHandler(this.FlatButtonEliminar_Click);
            // 
            // TextboxEvento
            // 
            this.TextboxEvento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxEvento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxEvento.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxEvento.HintText = "";
            this.TextboxEvento.isPassword = false;
            this.TextboxEvento.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxEvento.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxEvento.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxEvento.LineThickness = 3;
            this.TextboxEvento.Location = new System.Drawing.Point(26, 35);
            this.TextboxEvento.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxEvento.Name = "TextboxEvento";
            this.TextboxEvento.Size = new System.Drawing.Size(435, 44);
            this.TextboxEvento.TabIndex = 9;
            this.TextboxEvento.Text = "Evento";
            this.TextboxEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextboxEvento.Enter += new System.EventHandler(this.TextboxEvento_Enter);
            this.TextboxEvento.Leave += new System.EventHandler(this.TextboxEvento_Leave);
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // DatepickerFechaEvento
            // 
            this.DatepickerFechaEvento.BackColor = System.Drawing.Color.Black;
            this.DatepickerFechaEvento.BorderRadius = 0;
            this.DatepickerFechaEvento.ForeColor = System.Drawing.Color.White;
            this.DatepickerFechaEvento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DatepickerFechaEvento.FormatCustom = "YYYY-MM-DD";
            this.DatepickerFechaEvento.Location = new System.Drawing.Point(26, 118);
            this.DatepickerFechaEvento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatepickerFechaEvento.Name = "DatepickerFechaEvento";
            this.DatepickerFechaEvento.Size = new System.Drawing.Size(435, 44);
            this.DatepickerFechaEvento.TabIndex = 12;
            this.DatepickerFechaEvento.Value = new System.DateTime(2024, 4, 1, 21, 2, 20, 0);
            // 
            // MaterialTextboxBuscador
            // 
            this.MaterialTextboxBuscador.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaterialTextboxBuscador.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaterialTextboxBuscador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaterialTextboxBuscador.HintForeColor = System.Drawing.Color.Empty;
            this.MaterialTextboxBuscador.HintText = "";
            this.MaterialTextboxBuscador.isPassword = false;
            this.MaterialTextboxBuscador.LineFocusedColor = System.Drawing.Color.Blue;
            this.MaterialTextboxBuscador.LineIdleColor = System.Drawing.Color.Gray;
            this.MaterialTextboxBuscador.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.MaterialTextboxBuscador.LineThickness = 3;
            this.MaterialTextboxBuscador.Location = new System.Drawing.Point(618, 35);
            this.MaterialTextboxBuscador.Margin = new System.Windows.Forms.Padding(4);
            this.MaterialTextboxBuscador.Name = "MaterialTextboxBuscador";
            this.MaterialTextboxBuscador.Size = new System.Drawing.Size(321, 44);
            this.MaterialTextboxBuscador.TabIndex = 14;
            this.MaterialTextboxBuscador.Text = "Buscar";
            this.MaterialTextboxBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaterialTextboxBuscador.OnValueChanged += new System.EventHandler(this.MaterialTextboxBuscador_OnValueChanged);
            this.MaterialTextboxBuscador.Enter += new System.EventHandler(this.MaterialTextboxBuscador_Enter);
            this.MaterialTextboxBuscador.Leave += new System.EventHandler(this.MaterialTextboxBuscador_Leave);
            // 
            // AgendaInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 546);
            this.Controls.Add(this.MaterialTextboxBuscador);
            this.Controls.Add(this.DatepickerFechaEvento);
            this.Controls.Add(this.TextboxEvento);
            this.Controls.Add(this.FlatButtonEliminar);
            this.Controls.Add(this.FlatButtonEditar);
            this.Controls.Add(this.FlatButtonAñadir);
            this.Controls.Add(this.AgendaDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgendaInterfaz";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.AgendaInterfaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgendaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid AgendaDataGridView;
        private Bunifu.Framework.UI.BunifuFlatButton FlatButtonAñadir;
        private Bunifu.Framework.UI.BunifuFlatButton FlatButtonEditar;
        private Bunifu.Framework.UI.BunifuFlatButton FlatButtonEliminar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxEvento;
        private AgendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private AgendaDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private Bunifu.Framework.UI.BunifuDatepicker DatepickerFechaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEventoDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MaterialTextboxBuscador;
    }
}

