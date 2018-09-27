namespace I3Compiti
{
    partial class CompitoGUI
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.materialSingleLineTextFieldDescription = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelShowMore = new System.Windows.Forms.LinkLabel();
            this.materialSingleLineTextFieldTempoRimanente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldDataConsegna = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldMateria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextFieldAuthor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "I3Compiti Helper";
            // 
            // materialSingleLineTextFieldDescription
            // 
            this.materialSingleLineTextFieldDescription.Depth = 0;
            this.materialSingleLineTextFieldDescription.Enabled = false;
            this.materialSingleLineTextFieldDescription.Hint = "";
            this.materialSingleLineTextFieldDescription.Location = new System.Drawing.Point(288, 179);
            this.materialSingleLineTextFieldDescription.MaxLength = 32767;
            this.materialSingleLineTextFieldDescription.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldDescription.Name = "materialSingleLineTextFieldDescription";
            this.materialSingleLineTextFieldDescription.PasswordChar = '\0';
            this.materialSingleLineTextFieldDescription.SelectedText = "";
            this.materialSingleLineTextFieldDescription.SelectionLength = 0;
            this.materialSingleLineTextFieldDescription.SelectionStart = 0;
            this.materialSingleLineTextFieldDescription.Size = new System.Drawing.Size(296, 23);
            this.materialSingleLineTextFieldDescription.TabIndex = 17;
            this.materialSingleLineTextFieldDescription.TabStop = false;
            this.materialSingleLineTextFieldDescription.Text = "Desc";
            this.toolTip1.SetToolTip(this.materialSingleLineTextFieldDescription, "Yolo");
            this.materialSingleLineTextFieldDescription.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelShowMore);
            this.panel1.Controls.Add(this.materialSingleLineTextFieldTempoRimanente);
            this.panel1.Controls.Add(this.materialSingleLineTextFieldDataConsegna);
            this.panel1.Controls.Add(this.materialSingleLineTextFieldDescription);
            this.panel1.Controls.Add(this.materialSingleLineTextFieldMateria);
            this.panel1.Controls.Add(this.materialSingleLineTextFieldAuthor);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 404);
            this.panel1.TabIndex = 10;
            // 
            // linkLabelShowMore
            // 
            this.linkLabelShowMore.AutoSize = true;
            this.linkLabelShowMore.Location = new System.Drawing.Point(529, 205);
            this.linkLabelShowMore.Name = "linkLabelShowMore";
            this.linkLabelShowMore.Size = new System.Drawing.Size(64, 13);
            this.linkLabelShowMore.TabIndex = 20;
            this.linkLabelShowMore.TabStop = true;
            this.linkLabelShowMore.Text = "+show more";
            this.linkLabelShowMore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelShowMore_LinkClicked);
            // 
            // materialSingleLineTextFieldTempoRimanente
            // 
            this.materialSingleLineTextFieldTempoRimanente.Depth = 0;
            this.materialSingleLineTextFieldTempoRimanente.Enabled = false;
            this.materialSingleLineTextFieldTempoRimanente.Hint = "";
            this.materialSingleLineTextFieldTempoRimanente.Location = new System.Drawing.Point(288, 317);
            this.materialSingleLineTextFieldTempoRimanente.MaxLength = 32767;
            this.materialSingleLineTextFieldTempoRimanente.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldTempoRimanente.Name = "materialSingleLineTextFieldTempoRimanente";
            this.materialSingleLineTextFieldTempoRimanente.PasswordChar = '\0';
            this.materialSingleLineTextFieldTempoRimanente.SelectedText = "";
            this.materialSingleLineTextFieldTempoRimanente.SelectionLength = 0;
            this.materialSingleLineTextFieldTempoRimanente.SelectionStart = 0;
            this.materialSingleLineTextFieldTempoRimanente.Size = new System.Drawing.Size(296, 23);
            this.materialSingleLineTextFieldTempoRimanente.TabIndex = 19;
            this.materialSingleLineTextFieldTempoRimanente.TabStop = false;
            this.materialSingleLineTextFieldTempoRimanente.Text = "RemaningTime";
            this.materialSingleLineTextFieldTempoRimanente.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldDataConsegna
            // 
            this.materialSingleLineTextFieldDataConsegna.Depth = 0;
            this.materialSingleLineTextFieldDataConsegna.Enabled = false;
            this.materialSingleLineTextFieldDataConsegna.Hint = "";
            this.materialSingleLineTextFieldDataConsegna.Location = new System.Drawing.Point(288, 246);
            this.materialSingleLineTextFieldDataConsegna.MaxLength = 32767;
            this.materialSingleLineTextFieldDataConsegna.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldDataConsegna.Name = "materialSingleLineTextFieldDataConsegna";
            this.materialSingleLineTextFieldDataConsegna.PasswordChar = '\0';
            this.materialSingleLineTextFieldDataConsegna.SelectedText = "";
            this.materialSingleLineTextFieldDataConsegna.SelectionLength = 0;
            this.materialSingleLineTextFieldDataConsegna.SelectionStart = 0;
            this.materialSingleLineTextFieldDataConsegna.Size = new System.Drawing.Size(296, 23);
            this.materialSingleLineTextFieldDataConsegna.TabIndex = 18;
            this.materialSingleLineTextFieldDataConsegna.TabStop = false;
            this.materialSingleLineTextFieldDataConsegna.Text = "Date";
            this.materialSingleLineTextFieldDataConsegna.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldMateria
            // 
            this.materialSingleLineTextFieldMateria.Depth = 0;
            this.materialSingleLineTextFieldMateria.Enabled = false;
            this.materialSingleLineTextFieldMateria.Hint = "";
            this.materialSingleLineTextFieldMateria.Location = new System.Drawing.Point(288, 108);
            this.materialSingleLineTextFieldMateria.MaxLength = 32767;
            this.materialSingleLineTextFieldMateria.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldMateria.Name = "materialSingleLineTextFieldMateria";
            this.materialSingleLineTextFieldMateria.PasswordChar = '\0';
            this.materialSingleLineTextFieldMateria.SelectedText = "";
            this.materialSingleLineTextFieldMateria.SelectionLength = 0;
            this.materialSingleLineTextFieldMateria.SelectionStart = 0;
            this.materialSingleLineTextFieldMateria.Size = new System.Drawing.Size(296, 23);
            this.materialSingleLineTextFieldMateria.TabIndex = 16;
            this.materialSingleLineTextFieldMateria.TabStop = false;
            this.materialSingleLineTextFieldMateria.Text = "Materia";
            this.materialSingleLineTextFieldMateria.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextFieldAuthor
            // 
            this.materialSingleLineTextFieldAuthor.Depth = 0;
            this.materialSingleLineTextFieldAuthor.Enabled = false;
            this.materialSingleLineTextFieldAuthor.Hint = "";
            this.materialSingleLineTextFieldAuthor.Location = new System.Drawing.Point(288, 37);
            this.materialSingleLineTextFieldAuthor.MaxLength = 32767;
            this.materialSingleLineTextFieldAuthor.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextFieldAuthor.Name = "materialSingleLineTextFieldAuthor";
            this.materialSingleLineTextFieldAuthor.PasswordChar = '\0';
            this.materialSingleLineTextFieldAuthor.SelectedText = "";
            this.materialSingleLineTextFieldAuthor.SelectionLength = 0;
            this.materialSingleLineTextFieldAuthor.SelectionStart = 0;
            this.materialSingleLineTextFieldAuthor.Size = new System.Drawing.Size(296, 23);
            this.materialSingleLineTextFieldAuthor.TabIndex = 15;
            this.materialSingleLineTextFieldAuthor.TabStop = false;
            this.materialSingleLineTextFieldAuthor.Text = "Author";
            this.materialSingleLineTextFieldAuthor.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(75, 321);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(127, 19);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Tempo rimanente";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(93, 250);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(109, 19);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Data consegna";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(114, 179);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(88, 19);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "Descrizione";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(142, 108);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(60, 19);
            this.materialLabel2.TabIndex = 11;
            this.materialLabel2.Text = "Materia";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(148, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Autore";
            // 
            // CompitoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 463);
            this.Controls.Add(this.panel1);
            this.Name = "CompitoGUI";
            this.Text = "CompitoGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CompitoGUI_FormClosing);
            this.Load += new System.EventHandler(this.CompitoGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldTempoRimanente;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldDataConsegna;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldDescription;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldMateria;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextFieldAuthor;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.LinkLabel linkLabelShowMore;
    }
}