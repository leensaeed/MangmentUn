namespace MangmentUn.PL
{
    partial class SUB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Data = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.comboTerm = new System.Windows.Forms.ComboBox();
            this.comboDept = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Degree = new System.Windows.Forms.TextBox();
            this.Te = new System.Windows.Forms.Label();
            this.priceSell = new System.Windows.Forms.Label();
            this.stdPhone = new System.Windows.Forms.Label();
            this.dataS = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BottomBar = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Data.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataS)).BeginInit();
            this.panel1.SuspendLayout();
            this.BottomBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data
            // 
            this.Data.Controls.Add(this.panel2);
            this.Data.Controls.Add(this.dataS);
            this.Data.Controls.Add(this.panel1);
            this.Data.Controls.Add(this.BottomBar);
            this.Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data.Location = new System.Drawing.Point(0, 0);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(807, 533);
            this.Data.TabIndex = 37;
            this.Data.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.Data.DoubleClick += new System.EventHandler(this.Data_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboYear);
            this.panel2.Controls.Add(this.comboTerm);
            this.panel2.Controls.Add(this.comboDept);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.SName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.Degree);
            this.panel2.Controls.Add(this.Te);
            this.panel2.Controls.Add(this.priceSell);
            this.panel2.Controls.Add(this.stdPhone);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 342);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 146);
            this.panel2.TabIndex = 55;
            // 
            // comboYear
            // 
            this.comboYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboYear.Location = new System.Drawing.Point(512, 45);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(131, 36);
            this.comboYear.TabIndex = 61;
            // 
            // comboTerm
            // 
            this.comboTerm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboTerm.FormattingEnabled = true;
            this.comboTerm.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboTerm.Location = new System.Drawing.Point(512, -1);
            this.comboTerm.Name = "comboTerm";
            this.comboTerm.Size = new System.Drawing.Size(131, 36);
            this.comboTerm.TabIndex = 60;
            // 
            // comboDept
            // 
            this.comboDept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboDept.FormattingEnabled = true;
            this.comboDept.Location = new System.Drawing.Point(512, 94);
            this.comboDept.Name = "comboDept";
            this.comboDept.Size = new System.Drawing.Size(131, 36);
            this.comboDept.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(343, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 26);
            this.label3.TabIndex = 58;
            this.label3.Text = "Department";
            // 
            // SName
            // 
            this.SName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SName.Location = new System.Drawing.Point(132, 25);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(131, 36);
            this.SName.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(343, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "Year";
            // 
            // Degree
            // 
            this.Degree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Degree.Location = new System.Drawing.Point(132, 76);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(131, 36);
            this.Degree.TabIndex = 55;
            // 
            // Te
            // 
            this.Te.AutoSize = true;
            this.Te.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Te.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Te.Location = new System.Drawing.Point(343, 3);
            this.Te.Name = "Te";
            this.Te.Size = new System.Drawing.Size(53, 26);
            this.Te.TabIndex = 54;
            this.Te.Text = "Term";
            // 
            // priceSell
            // 
            this.priceSell.AutoSize = true;
            this.priceSell.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceSell.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.priceSell.Location = new System.Drawing.Point(45, 80);
            this.priceSell.Name = "priceSell";
            this.priceSell.Size = new System.Drawing.Size(65, 26);
            this.priceSell.TabIndex = 53;
            this.priceSell.Text = "Degree";
            // 
            // stdPhone
            // 
            this.stdPhone.AutoSize = true;
            this.stdPhone.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdPhone.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.stdPhone.Location = new System.Drawing.Point(45, 29);
            this.stdPhone.Name = "stdPhone";
            this.stdPhone.Size = new System.Drawing.Size(66, 26);
            this.stdPhone.TabIndex = 52;
            this.stdPhone.Text = "SName";
            // 
            // dataS
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataS.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataS.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataS.Location = new System.Drawing.Point(0, 46);
            this.dataS.Name = "dataS";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataS.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dataS.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataS.Size = new System.Drawing.Size(807, 442);
            this.dataS.TabIndex = 54;
            this.dataS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataS_CellClick);
            this.dataS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataS_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 46);
            this.panel1.TabIndex = 53;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 28);
            this.linkLabel1.TabIndex = 56;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "<back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // BottomBar
            // 
            this.BottomBar.BackColor = System.Drawing.Color.Black;
            this.BottomBar.Controls.Add(this.Delete);
            this.BottomBar.Controls.Add(this.Edit);
            this.BottomBar.Controls.Add(this.Add);
            this.BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomBar.Location = new System.Drawing.Point(0, 488);
            this.BottomBar.Name = "BottomBar";
            this.BottomBar.Size = new System.Drawing.Size(807, 45);
            this.BottomBar.TabIndex = 51;
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Delete.Location = new System.Drawing.Point(483, 0);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(160, 48);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Edit.FlatAppearance.BorderSize = 0;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Edit.Location = new System.Drawing.Point(332, -3);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(160, 48);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add.BackColor = System.Drawing.Color.Black;
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Add.FlatAppearance.BorderSize = 0;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.Add.Location = new System.Drawing.Point(150, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(160, 48);
            this.Add.TabIndex = 0;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 533);
            this.Controls.Add(this.Data);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.SUB_Activated);
            this.Load += new System.EventHandler(this.SUB_Load);
            this.Data.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BottomBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Data;
        private System.Windows.Forms.Panel BottomBar;
        public System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        public System.Windows.Forms.ComboBox comboYear;
        public System.Windows.Forms.ComboBox comboTerm;
        public System.Windows.Forms.ComboBox comboDept;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Degree;
        private System.Windows.Forms.Label Te;
        private System.Windows.Forms.Label priceSell;
        private System.Windows.Forms.Label stdPhone;
    }
}