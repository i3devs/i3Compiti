namespace I3Compiti
{
    partial class GUI
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeaderAutore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMateria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescrizione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataConsegna = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialCheckBoxTheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialCheckBoxNotify = new MaterialSkin.Controls.MaterialCheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderAutore,
            this.columnHeaderMateria,
            this.columnHeaderDescrizione,
            this.columnHeaderDataConsegna});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(12, 69);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.MultiSelect = false;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(948, 242);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.materialListView1_ColumnWidthChanging);
            this.materialListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.materialListView1_ItemSelectionChanged);
            // 
            // columnHeaderAutore
            // 
            this.columnHeaderAutore.Text = "Autore";
            this.columnHeaderAutore.Width = 159;
            // 
            // columnHeaderMateria
            // 
            this.columnHeaderMateria.Text = "Materia";
            this.columnHeaderMateria.Width = 225;
            // 
            // columnHeaderDescrizione
            // 
            this.columnHeaderDescrizione.Text = "Descrizione";
            this.columnHeaderDescrizione.Width = 246;
            // 
            // columnHeaderDataConsegna
            // 
            this.columnHeaderDataConsegna.Text = "Data Consegna";
            this.columnHeaderDataConsegna.Width = 148;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialCheckBoxTheme);
            this.panel1.Controls.Add(this.materialCheckBoxNotify);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 133);
            this.panel1.TabIndex = 1;
            // 
            // materialCheckBoxTheme
            // 
            this.materialCheckBoxTheme.AutoSize = true;
            this.materialCheckBoxTheme.Depth = 0;
            this.materialCheckBoxTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBoxTheme.Location = new System.Drawing.Point(9, 40);
            this.materialCheckBoxTheme.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxTheme.Name = "materialCheckBoxTheme";
            this.materialCheckBoxTheme.Ripple = true;
            this.materialCheckBoxTheme.Size = new System.Drawing.Size(151, 30);
            this.materialCheckBoxTheme.TabIndex = 1;
            this.materialCheckBoxTheme.Text = "White/Black Theme";
            this.materialCheckBoxTheme.UseVisualStyleBackColor = true;
            // 
            // materialCheckBoxNotify
            // 
            this.materialCheckBoxNotify.AutoSize = true;
            this.materialCheckBoxNotify.Depth = 0;
            this.materialCheckBoxNotify.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialCheckBoxNotify.Location = new System.Drawing.Point(9, 10);
            this.materialCheckBoxNotify.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBoxNotify.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxNotify.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxNotify.Name = "materialCheckBoxNotify";
            this.materialCheckBoxNotify.Ripple = true;
            this.materialCheckBoxNotify.Size = new System.Drawing.Size(148, 30);
            this.materialCheckBoxNotify.TabIndex = 0;
            this.materialCheckBoxNotify.Text = "Notify via Windows";
            this.materialCheckBoxNotify.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Yolo";
            this.notifyIcon1.Visible = true;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialListView1);
            this.Name = "GUI";
            this.Text = "I3Compiti";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeaderAutore;
        private System.Windows.Forms.ColumnHeader columnHeaderMateria;
        private System.Windows.Forms.ColumnHeader columnHeaderDescrizione;
        private System.Windows.Forms.ColumnHeader columnHeaderDataConsegna;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxTheme;
        private MaterialSkin.Controls.MaterialCheckBox materialCheckBoxNotify;
        public MaterialSkin.Controls.MaterialListView materialListView1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

