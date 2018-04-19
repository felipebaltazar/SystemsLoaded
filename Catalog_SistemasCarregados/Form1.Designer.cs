namespace Catalog_SistemasCarregados
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SystemInfoDataGrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemMinimizar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Systems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastAccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SystemInfoDataGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemInfoDataGrid
            // 
            this.SystemInfoDataGrid.AllowDrop = true;
            this.SystemInfoDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SystemInfoDataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.SystemInfoDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SystemInfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SystemInfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Systems,
            this.LastAccess,
            this.IsActive});
            this.SystemInfoDataGrid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SystemInfoDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.SystemInfoDataGrid.Location = new System.Drawing.Point(2, 2);
            this.SystemInfoDataGrid.Name = "SystemInfoDataGrid";
            this.SystemInfoDataGrid.RowHeadersWidth = 25;
            this.SystemInfoDataGrid.Size = new System.Drawing.Size(852, 509);
            this.SystemInfoDataGrid.TabIndex = 0;
            this.SystemInfoDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewCellEndEdit);
            this.SystemInfoDataGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewCellLeave);
            this.SystemInfoDataGrid.DragDrop += new System.Windows.Forms.DragEventHandler(this.ViewDragDrop);
            this.SystemInfoDataGrid.DragEnter += new System.Windows.Forms.DragEventHandler(this.ViewDragEnter);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemMinimizar,
            this.toolStripMenuItemSair});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // toolStripMenuItemMinimizar
            // 
            this.toolStripMenuItemMinimizar.Image = global::Catalog_SistemasCarregados.Properties.Resources.Minimizar;
            this.toolStripMenuItemMinimizar.Name = "toolStripMenuItemMinimizar";
            this.toolStripMenuItemMinimizar.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemMinimizar.Text = "Minimizar";
            this.toolStripMenuItemMinimizar.Click += new System.EventHandler(this.ToolStripMenuItemMinimizeClick);
            // 
            // toolStripMenuItemSair
            // 
            this.toolStripMenuItemSair.Image = global::Catalog_SistemasCarregados.Properties.Resources.Sair;
            this.toolStripMenuItemSair.Name = "toolStripMenuItemSair";
            this.toolStripMenuItemSair.Size = new System.Drawing.Size(127, 22);
            this.toolStripMenuItemSair.Text = "Sair";
            this.toolStripMenuItemSair.Click += new System.EventHandler(this.ToolStripMenuItemExitClick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Catalog: Sistemas";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconMouseDoubleClick);
            // 
            // Systems
            // 
            this.Systems.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Systems.HeaderText = "Sistemas";
            this.Systems.Name = "Systems";
            // 
            // LastAccess
            // 
            this.LastAccess.HeaderText = "Ultimo Acesso";
            this.LastAccess.Name = "LastAccess";
            this.LastAccess.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Ativo";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(855, 513);
            this.Controls.Add(this.SystemInfoDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog Sistemas Carregados";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.SystemInfoDataGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SystemInfoDataGrid;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemMinimizar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSair;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Systems;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastAccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsActive;
    }
}

