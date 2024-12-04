namespace QuanlySV
{
    partial class Khoa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.txtmakhoa = new System.Windows.Forms.TextBox();
            this.txttenkhoa = new System.Windows.Forms.TextBox();
            this.lbltenkhoa = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btntrove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 232);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Location = new System.Drawing.Point(148, 73);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(49, 13);
            this.lblmakhoa.TabIndex = 1;
            this.lblmakhoa.Text = "Mã khoa";
            // 
            // txtmakhoa
            // 
            this.txtmakhoa.Location = new System.Drawing.Point(223, 70);
            this.txtmakhoa.Name = "txtmakhoa";
            this.txtmakhoa.Size = new System.Drawing.Size(180, 20);
            this.txtmakhoa.TabIndex = 2;
            // 
            // txttenkhoa
            // 
            this.txttenkhoa.Location = new System.Drawing.Point(223, 108);
            this.txttenkhoa.Name = "txttenkhoa";
            this.txttenkhoa.Size = new System.Drawing.Size(180, 20);
            this.txttenkhoa.TabIndex = 3;
            // 
            // lbltenkhoa
            // 
            this.lbltenkhoa.AutoSize = true;
            this.lbltenkhoa.Location = new System.Drawing.Point(148, 111);
            this.lbltenkhoa.Name = "lbltenkhoa";
            this.lbltenkhoa.Size = new System.Drawing.Size(53, 13);
            this.lbltenkhoa.TabIndex = 4;
            this.lbltenkhoa.Text = "Tên khoa";
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(452, 162);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 28);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(452, 196);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 28);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(452, 230);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 28);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(452, 264);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 28);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(452, 298);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 28);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.Location = new System.Drawing.Point(452, 332);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(75, 28);
            this.btntimkiem.TabIndex = 10;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.button6_Click);
            // 
            // btntrove
            // 
            this.btntrove.Location = new System.Drawing.Point(452, 366);
            this.btntrove.Name = "btntrove";
            this.btntrove.Size = new System.Drawing.Size(75, 28);
            this.btntrove.TabIndex = 11;
            this.btntrove.Text = "Trở về";
            this.btntrove.UseVisualStyleBackColor = true;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntrove);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.lbltenkhoa);
            this.Controls.Add(this.txttenkhoa);
            this.Controls.Add(this.txtmakhoa);
            this.Controls.Add(this.lblmakhoa);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblmakhoa;
        private System.Windows.Forms.TextBox txtmakhoa;
        private System.Windows.Forms.TextBox txttenkhoa;
        private System.Windows.Forms.Label lbltenkhoa;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Button btntrove;
    }
}