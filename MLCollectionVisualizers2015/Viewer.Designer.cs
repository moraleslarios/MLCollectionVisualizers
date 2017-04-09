namespace MLCollectionVisualizers2015
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.tabFiltros = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.tabFiltros.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDatos);
            this.tabControl1.Controls.Add(this.tabFiltros);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 431);
            this.tabControl1.TabIndex = 2;
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.gridDatos);
            this.tabDatos.Location = new System.Drawing.Point(4, 22);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatos.Size = new System.Drawing.Size(748, 405);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "Data";
            this.tabDatos.UseVisualStyleBackColor = true;
            // 
            // gridDatos
            // 
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatos.Location = new System.Drawing.Point(3, 3);
            this.gridDatos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 22);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.Size = new System.Drawing.Size(742, 399);
            this.gridDatos.TabIndex = 1;
            // 
            // tabFiltros
            // 
            this.tabFiltros.Controls.Add(this.linkLabel2);
            this.tabFiltros.Controls.Add(this.linkLabel1);
            this.tabFiltros.Controls.Add(this.button1);
            this.tabFiltros.Controls.Add(this.richTextBox1);
            this.tabFiltros.Location = new System.Drawing.Point(4, 22);
            this.tabFiltros.Name = "tabFiltros";
            this.tabFiltros.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiltros.Size = new System.Drawing.Size(748, 405);
            this.tabFiltros.TabIndex = 1;
            this.tabFiltros.Text = "Filters";
            this.tabFiltros.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1044, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "DataColumn.Expression";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 331);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(742, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(742, 399);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtRegistros,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1,
            this.txtTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtRegistros
            // 
            this.txtRegistros.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtRegistros.Name = "txtRegistros";
            this.txtRegistros.Size = new System.Drawing.Size(76, 17);
            this.txtRegistros.Text = "txtRegistros";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel2.Text = "Rows";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(136, 17);
            this.toolStripStatusLabel1.Text = "                                           ";
            // 
            // txtTime
            // 
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(94, 17);
            this.txtTime.Text = "                             ";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel2.Location = new System.Drawing.Point(3, 318);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(61, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Filter Info";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Viewer";
            this.Text = "Pakkko - Collection Viewer";
            this.tabControl1.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.tabFiltros.ResumeLayout(false);
            this.tabFiltros.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.TabPage tabFiltros;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtRegistros;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtTime;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}