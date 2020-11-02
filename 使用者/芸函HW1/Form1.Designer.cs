namespace 芸函HW1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.labpwd = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnmemberlist = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(32, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 220);
            this.label1.TabIndex = 0;
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labname.Location = new System.Drawing.Point(209, 48);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(94, 21);
            this.labname.TabIndex = 1;
            this.labname.Text = "使用者名稱:";
            // 
            // labpwd
            // 
            this.labpwd.AutoSize = true;
            this.labpwd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labpwd.Location = new System.Drawing.Point(209, 121);
            this.labpwd.Name = "labpwd";
            this.labpwd.Size = new System.Drawing.Size(46, 21);
            this.labpwd.TabIndex = 2;
            this.labpwd.Text = "密碼:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(213, 83);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(207, 22);
            this.txtname.TabIndex = 3;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(213, 160);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(207, 22);
            this.txtpwd.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "建立帳號";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(494, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(278, 155);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnmemberlist
            // 
            this.btnmemberlist.Location = new System.Drawing.Point(203, 265);
            this.btnmemberlist.Name = "btnmemberlist";
            this.btnmemberlist.Size = new System.Drawing.Size(271, 33);
            this.btnmemberlist.TabIndex = 9;
            this.btnmemberlist.Text = "GetmemberList";
            this.btnmemberlist.UseVisualStyleBackColor = true;
            this.btnmemberlist.Click += new System.EventHandler(this.btnmemberlist_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(203, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(271, 37);
            this.button4.TabIndex = 24;
            this.button4.Text = "清空視窗";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnmemberlist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labpwd);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "登入";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labpwd;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnmemberlist;
        private System.Windows.Forms.Button button4;
    }
}

