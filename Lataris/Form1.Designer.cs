
namespace Lataris
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
            this.tombolkonek = new System.Windows.Forms.Button();
            this.labelstatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tombolexecute3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.edit_query3 = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.tombolexecute2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_query2 = new System.Windows.Forms.TextBox();
            this.tombolexecute1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edit_query1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // tombolkonek
            // 
            this.tombolkonek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tombolkonek.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tombolkonek.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tombolkonek.Location = new System.Drawing.Point(12, 12);
            this.tombolkonek.Name = "tombolkonek";
            this.tombolkonek.Size = new System.Drawing.Size(96, 29);
            this.tombolkonek.TabIndex = 0;
            this.tombolkonek.Text = "Connect DB";
            this.tombolkonek.UseVisualStyleBackColor = true;
            this.tombolkonek.Click += new System.EventHandler(this.tombolkonek_Click);
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(114, 20);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(128, 13);
            this.labelstatus.TabIndex = 1;
            this.labelstatus.Text = "Status : Tidak Terhubung";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.tombolexecute3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edit_query3);
            this.groupBox1.Controls.Add(this.dataGrid1);
            this.groupBox1.Controls.Add(this.tombolexecute2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edit_query2);
            this.groupBox1.Controls.Add(this.tombolexecute1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edit_query1);
            this.groupBox1.Location = new System.Drawing.Point(11, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 223);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(361, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(192, 83);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            // 
            // tombolexecute3
            // 
            this.tombolexecute3.Enabled = false;
            this.tombolexecute3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tombolexecute3.Location = new System.Drawing.Point(479, 65);
            this.tombolexecute3.Name = "tombolexecute3";
            this.tombolexecute3.Size = new System.Drawing.Size(75, 23);
            this.tombolexecute3.TabIndex = 13;
            this.tombolexecute3.Text = "Execute";
            this.tombolexecute3.UseVisualStyleBackColor = true;
            this.tombolexecute3.Click += new System.EventHandler(this.tombolexecute3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Query Delete";
            // 
            // edit_query3
            // 
            this.edit_query3.Location = new System.Drawing.Point(80, 67);
            this.edit_query3.Name = "edit_query3";
            this.edit_query3.Size = new System.Drawing.Size(393, 20);
            this.edit_query3.TabIndex = 11;
            this.edit_query3.Text = "delete from pegawai where username = \'user1\'";
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.Lavender;
            this.dataGrid1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.CaptionVisible = false;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.FlatMode = true;
            this.dataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.LinkColor = System.Drawing.Color.Teal;
            this.dataGrid1.Location = new System.Drawing.Point(80, 123);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGrid1.Size = new System.Drawing.Size(276, 83);
            this.dataGrid1.TabIndex = 10;
            // 
            // tombolexecute2
            // 
            this.tombolexecute2.Enabled = false;
            this.tombolexecute2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tombolexecute2.Location = new System.Drawing.Point(479, 95);
            this.tombolexecute2.Name = "tombolexecute2";
            this.tombolexecute2.Size = new System.Drawing.Size(75, 23);
            this.tombolexecute2.TabIndex = 9;
            this.tombolexecute2.Text = "Execute";
            this.tombolexecute2.UseVisualStyleBackColor = true;
            this.tombolexecute2.Click += new System.EventHandler(this.tombolexecute2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Query Select ";
            // 
            // edit_query2
            // 
            this.edit_query2.Location = new System.Drawing.Point(80, 97);
            this.edit_query2.Name = "edit_query2";
            this.edit_query2.Size = new System.Drawing.Size(393, 20);
            this.edit_query2.TabIndex = 7;
            this.edit_query2.Text = "Select * from pegawai";
            // 
            // tombolexecute1
            // 
            this.tombolexecute1.Enabled = false;
            this.tombolexecute1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tombolexecute1.Location = new System.Drawing.Point(479, 36);
            this.tombolexecute1.Name = "tombolexecute1";
            this.tombolexecute1.Size = new System.Drawing.Size(75, 23);
            this.tombolexecute1.TabIndex = 6;
            this.tombolexecute1.Text = "Execute";
            this.tombolexecute1.UseVisualStyleBackColor = true;
            this.tombolexecute1.Click += new System.EventHandler(this.tombolexecute1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Query Insert";
            // 
            // edit_query1
            // 
            this.edit_query1.Location = new System.Drawing.Point(80, 38);
            this.edit_query1.Name = "edit_query1";
            this.edit_query1.Size = new System.Drawing.Size(393, 20);
            this.edit_query1.TabIndex = 4;
            this.edit_query1.Text = "Insert into pegawai (username,password,level) values (\'user1\',\'12345\',\'admin\')";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(589, 414);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelstatus);
            this.Controls.Add(this.tombolkonek);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sample Koneksi MySQL by Aris";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolkonek;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tombolexecute1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edit_query1;
        private System.Windows.Forms.Button tombolexecute2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edit_query2;
        private System.Windows.Forms.DataGrid dataGrid1;
        private System.Windows.Forms.Button tombolexecute3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edit_query3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

