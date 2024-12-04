namespace QuanlySV
{
    partial class Giaovien
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
            this.txtmagv = new System.Windows.Forms.TextBox();
            this.txthotengv = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.lblmagv = new System.Windows.Forms.Label();
            this.lblhotengv = new System.Windows.Forms.Label();
            this.lblsodt = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhotengv = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmagv
            // 
            this.txtmagv.Location = new System.Drawing.Point(182, 50);
            this.txtmagv.Name = "txtmagv";
            this.txtmagv.Size = new System.Drawing.Size(283, 20);
            this.txtmagv.TabIndex = 0;
            // 
            // txthotengv
            // 
            this.txthotengv.Location = new System.Drawing.Point(182, 76);
            this.txthotengv.Name = "txthotengv";
            this.txthotengv.Size = new System.Drawing.Size(283, 20);
            this.txthotengv.TabIndex = 1;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(182, 102);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(283, 20);
            this.txtsdt.TabIndex = 2;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(182, 128);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(283, 20);
            this.txtemail.TabIndex = 3;
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(182, 154);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(283, 20);
            this.txtmakhoa.TabIndex = 4;
            // 
            // lblmagv
            // 
            this.lblmagv.AutoSize = true;
            this.lblmagv.Location = new System.Drawing.Point(91, 53);
            this.lblmagv.Name = "lblmagv";
            this.lblmagv.Size = new System.Drawing.Size(68, 13);
            this.lblmagv.TabIndex = 5;
            this.lblmagv.Text = "Mã giáo viên";
            // 
            // lblhotengv
            // 
            this.lblhotengv.AutoSize = true;
            this.lblhotengv.Location = new System.Drawing.Point(91, 79);
            this.lblhotengv.Name = "lblhotengv";
            this.lblhotengv.Size = new System.Drawing.Size(85, 13);
            this.lblhotengv.TabIndex = 6;
            this.lblhotengv.Text = "Họ tên giáo viên";
            // 
            // lblsodt
            // 
            this.lblsodt.AutoSize = true;
            this.lblsodt.Location = new System.Drawing.Point(91, 105);
            this.lblsodt.Name = "lblsodt";
            this.lblsodt.Size = new System.Drawing.Size(70, 13);
            this.lblsodt.TabIndex = 7;
            this.lblsodt.Text = "Số điện thoại";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(91, 131);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(32, 13);
            this.lblemail.TabIndex = 8;
            this.lblemail.Text = "Email";
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Location = new System.Drawing.Point(91, 157);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(49, 13);
            this.lblmakhoa.TabIndex = 9;
            this.lblmakhoa.Text = "Mã khoa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(482, 195);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(488, 45);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnhotengv
            // 
            this.btnhotengv.Location = new System.Drawing.Point(488, 74);
            this.btnhotengv.Name = "btnhotengv";
            this.btnhotengv.Size = new System.Drawing.Size(75, 23);
            this.btnhotengv.TabIndex = 12;
            this.btnhotengv.Text = "Reset";
            this.btnhotengv.UseVisualStyleBackColor = true;
            this.btnhotengv.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(488, 103);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 13;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(488, 132);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(488, 161);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(488, 190);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 23);
            this.btntimkiem.TabIndex = 16;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(488, 219);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 23);
            this.btntrove.TabIndex = 17;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            this.btntrove.Click += new System.EventHandler(this.btntrove_Click);
            // 
            // Giaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnhotengv);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblmakhoa);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblsodt);
            this.Controls.Add(this.lblhotengv);
            this.Controls.Add(this.lblmagv);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txthotengv);
            this.Controls.Add(this.txtmagv);
            this.Name = "Giaovien";
            this.Text = "Giaovien";
            this.Load += new System.EventHandler(this.Giaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmagv;
        private System.Windows.Forms.TextBox txthotengv;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.Label lblmagv;
        private System.Windows.Forms.Label lblhotengv;
        private System.Windows.Forms.Label lblsodt;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblmakhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhotengv;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btntrove;
    }
}