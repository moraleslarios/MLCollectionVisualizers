using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Diagnostics;


namespace MLCollectionVisualizers2017
{
    public partial class Viewer : Form
    {
        private DataTable Datos;

        private Stopwatch reloj;

        public Viewer(DataTable datos)
        {
            InitializeComponent();

            this.reloj = new Stopwatch();
            this.reloj.Start();
            this.Datos = datos;
            

            AplicaEstiloFilasDataGridView(ref this.gridDatos);
            AplicaComportamientoDataGridView(ref this.gridDatos);
            this.gridDatos.DataSource = this.Datos.DefaultView;

            this.txtRegistros.Text = this.Datos.DefaultView.Count.ToString("#,###,###,###,##0");
            this.txtTime.Text = this.reloj.ElapsedMilliseconds.ToString("#,###,###,###,##0.00######") + "  Miliseconds";

            this.reloj.Stop();
        }



        #region formato de grid

        public void AplicaEstiloFilasDataGridView(ref DataGridView dtView)
        {

            DataGridViewCellStyle estiloCabecera = new DataGridViewCellStyle();
            //estiloCabecera.BackColor = Color.LightGray;
            estiloCabecera.BackColor = Color.Gainsboro;
            estiloCabecera.ForeColor = Color.Black;
            estiloCabecera.Font = new Font("Verdana", 8, FontStyle.Bold);
            dtView.ColumnHeadersDefaultCellStyle = estiloCabecera;

            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.StandardTab = true;

            DataGridViewCellStyle estiloAlternativas = new DataGridViewCellStyle();
            estiloAlternativas.BackColor = Color.White;
            estiloAlternativas.ForeColor = Color.Black;
            estiloAlternativas.Font = new Font("Verdana", 8);

            DataGridViewCellStyle estiloDefaults = new DataGridViewCellStyle();

            //estiloDefaults.BackColor = Color.FromArgb(206, 222, 255);
            estiloDefaults.BackColor = Color.Gainsboro;
            estiloDefaults.ForeColor = Color.Black;
            estiloDefaults.Font = new Font("Verdana", 8);

            dtView.AlternatingRowsDefaultCellStyle = estiloAlternativas;
            dtView.RowsDefaultCellStyle = estiloDefaults;
            dtView.Refresh();
        }

        public void AplicaComportamientoDataGridView(ref DataGridView dtView)
        {
            dtView.AllowUserToAddRows = false;
            dtView.AllowUserToDeleteRows = false;
            dtView.AllowUserToOrderColumns = false;
            dtView.AllowUserToResizeRows = true;
            dtView.AllowUserToResizeColumns = true;
            dtView.AllowUserToOrderColumns = true;
            //dtView.

            dtView.AutoResizeColumns();
            dtView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtView.ReadOnly = true;
            //queremos que el tabulador seleccione la fila entera
            dtView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtView.Refresh();
        }


        #endregion


        public Color Colors { get; set; }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Black;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://msdn.microsoft.com/en-us/library/system.data.datacolumn.expression.aspx");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Datos.DefaultView.RowFilter = this.richTextBox1.Text;
                this.gridDatos.Refresh();
                this.txtRegistros.Text = this.Datos.DefaultView.Count.ToString("#,###,###,###,##0");
                this.tabControl1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                this.richTextBox1.ForeColor = Color.Red;
                MessageBox.Show("Incorrect Syntax");
            }
        }

    }




}
