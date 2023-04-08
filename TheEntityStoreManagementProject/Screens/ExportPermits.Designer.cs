namespace TheEntityStoreManagementProject.Screens
{
    partial class ExportPermits
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.permitdate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxitem = new System.Windows.Forms.ComboBox();
            this.comboBoxsupname = new System.Windows.Forms.ComboBox();
            this.comboBoxstore = new System.Windows.Forms.ComboBox();
            this.txtpernitnum = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnhome = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listExportResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permitidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permitdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listExportResultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.txtquantity);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.permitdate);
            this.groupBox1.Controls.Add(this.comboBoxitem);
            this.groupBox1.Controls.Add(this.comboBoxsupname);
            this.groupBox1.Controls.Add(this.comboBoxstore);
            this.groupBox1.Controls.Add(this.txtpernitnum);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 553);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(240, 406);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(278, 20);
            this.txtquantity.TabIndex = 38;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndelete.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btndelete.Location = new System.Drawing.Point(371, 473);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(195, 40);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "DeleteExportPermit";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnupdate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnupdate.Location = new System.Drawing.Point(164, 473);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(201, 40);
            this.btnupdate.TabIndex = 35;
            this.btnupdate.Text = "UpdateExportPermit";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnadd.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(0, 473);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(158, 40);
            this.btnadd.TabIndex = 34;
            this.btnadd.Text = "ADDExportPermit";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // permitdate
            // 
            this.permitdate.Location = new System.Drawing.Point(240, 296);
            this.permitdate.Name = "permitdate";
            this.permitdate.Size = new System.Drawing.Size(278, 20);
            this.permitdate.TabIndex = 17;
            // 
            // comboBoxitem
            // 
            this.comboBoxitem.FormattingEnabled = true;
            this.comboBoxitem.Location = new System.Drawing.Point(240, 356);
            this.comboBoxitem.Name = "comboBoxitem";
            this.comboBoxitem.Size = new System.Drawing.Size(278, 21);
            this.comboBoxitem.TabIndex = 14;
            // 
            // comboBoxsupname
            // 
            this.comboBoxsupname.FormattingEnabled = true;
            this.comboBoxsupname.Location = new System.Drawing.Point(240, 233);
            this.comboBoxsupname.Name = "comboBoxsupname";
            this.comboBoxsupname.Size = new System.Drawing.Size(278, 21);
            this.comboBoxsupname.TabIndex = 13;
            // 
            // comboBoxstore
            // 
            this.comboBoxstore.FormattingEnabled = true;
            this.comboBoxstore.Location = new System.Drawing.Point(240, 105);
            this.comboBoxstore.Name = "comboBoxstore";
            this.comboBoxstore.Size = new System.Drawing.Size(278, 21);
            this.comboBoxstore.TabIndex = 12;
            // 
            // txtpernitnum
            // 
            this.txtpernitnum.Location = new System.Drawing.Point(240, 171);
            this.txtpernitnum.Name = "txtpernitnum";
            this.txtpernitnum.Size = new System.Drawing.Size(278, 20);
            this.txtpernitnum.TabIndex = 10;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(240, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(278, 20);
            this.txtid.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(37, 399);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "quantity ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(37, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "item_id ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(30, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "permit_date ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(26, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "supplier_name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "permit_number ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "StoreID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "PermitID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnhome);
            this.groupBox2.Controls.Add(this.btndisplay);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(571, -17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 553);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.permitidDataGridViewTextBoxColumn,
            this.storeidDataGridViewTextBoxColumn,
            this.permitnumberDataGridViewTextBoxColumn,
            this.permitdateDataGridViewTextBoxColumn,
            this.supplieridDataGridViewTextBoxColumn,
            this.itemidDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listExportResultBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(14, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(519, 243);
            this.dataGridView1.TabIndex = 27;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Cyan;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(292, 473);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(115, 40);
            this.btnhome.TabIndex = 25;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.Color.Yellow;
            this.btndisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(133, 473);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(115, 40);
            this.btndisplay.TabIndex = 24;
            this.btndisplay.Text = "DisplayAll";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 160);
            this.listBox1.TabIndex = 0;
            // 
            // listExportResultBindingSource
            // 
            this.listExportResultBindingSource.DataSource = typeof(TheEntityStoreManagementProject.ListExport_Result);
            // 
            // permitidDataGridViewTextBoxColumn
            // 
            this.permitidDataGridViewTextBoxColumn.DataPropertyName = "permit_id";
            this.permitidDataGridViewTextBoxColumn.HeaderText = "permit_id";
            this.permitidDataGridViewTextBoxColumn.Name = "permitidDataGridViewTextBoxColumn";
            // 
            // storeidDataGridViewTextBoxColumn
            // 
            this.storeidDataGridViewTextBoxColumn.DataPropertyName = "store_id";
            this.storeidDataGridViewTextBoxColumn.HeaderText = "store_id";
            this.storeidDataGridViewTextBoxColumn.Name = "storeidDataGridViewTextBoxColumn";
            // 
            // permitnumberDataGridViewTextBoxColumn
            // 
            this.permitnumberDataGridViewTextBoxColumn.DataPropertyName = "permit_number";
            this.permitnumberDataGridViewTextBoxColumn.HeaderText = "permit_number";
            this.permitnumberDataGridViewTextBoxColumn.Name = "permitnumberDataGridViewTextBoxColumn";
            // 
            // permitdateDataGridViewTextBoxColumn
            // 
            this.permitdateDataGridViewTextBoxColumn.DataPropertyName = "permit_date";
            this.permitdateDataGridViewTextBoxColumn.HeaderText = "permit_date";
            this.permitdateDataGridViewTextBoxColumn.Name = "permitdateDataGridViewTextBoxColumn";
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "supplier_id";
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // ExportPermits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 537);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ExportPermits";
            this.Text = "ExportPermits";
            this.Load += new System.EventHandler(this.ExportPermits_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listExportResultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DateTimePicker permitdate;
        private System.Windows.Forms.ComboBox comboBoxitem;
        private System.Windows.Forms.ComboBox comboBoxsupname;
        private System.Windows.Forms.ComboBox comboBoxstore;
        private System.Windows.Forms.TextBox txtpernitnum;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permitdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listExportResultBindingSource;
    }
}