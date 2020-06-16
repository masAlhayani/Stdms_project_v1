namespace simple_std_project
{
    partial class frm_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_grandname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.combo_gender = new System.Windows.Forms.ComboBox();
            this.btn_add_std = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update_std = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_show_all = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1600, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الطالب";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_fname
            // 
            this.txt_fname.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.Location = new System.Drawing.Point(1275, 180);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_fname.Size = new System.Drawing.Size(258, 44);
            this.txt_fname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1630, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(117, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الأب";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.Location = new System.Drawing.Point(1275, 260);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_lname.Size = new System.Drawing.Size(258, 44);
            this.txt_lname.TabIndex = 3;
            this.txt_lname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1634, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(113, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "اسم الجد";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_grandname
            // 
            this.txt_grandname.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grandname.Location = new System.Drawing.Point(1275, 342);
            this.txt_grandname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_grandname.Name = "txt_grandname";
            this.txt_grandname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_grandname.Size = new System.Drawing.Size(258, 44);
            this.txt_grandname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1660, 411);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(88, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "الجنس";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1611, 483);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(140, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "رقم الهاتف";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phone.Location = new System.Drawing.Point(1275, 491);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_phone.Size = new System.Drawing.Size(258, 44);
            this.txt_phone.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1552, 578);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "البريد الالكتروني";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(1066, 583);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(466, 44);
            this.txt_email.TabIndex = 10;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // combo_gender
            // 
            this.combo_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_gender.FormattingEnabled = true;
            this.combo_gender.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.combo_gender.Location = new System.Drawing.Point(1276, 417);
            this.combo_gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_gender.Name = "combo_gender";
            this.combo_gender.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.combo_gender.Size = new System.Drawing.Size(256, 37);
            this.combo_gender.TabIndex = 11;
            this.combo_gender.SelectedIndexChanged += new System.EventHandler(this.combo_gender_SelectedIndexChanged);
            // 
            // btn_add_std
            // 
            this.btn_add_std.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_add_std.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_std.Location = new System.Drawing.Point(1186, 14);
            this.btn_add_std.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add_std.Name = "btn_add_std";
            this.btn_add_std.Size = new System.Drawing.Size(232, 46);
            this.btn_add_std.TabIndex = 12;
            this.btn_add_std.Text = "إضافة";
            this.btn_add_std.UseVisualStyleBackColor = false;
            this.btn_add_std.Click += new System.EventHandler(this.btn_add_std_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(900, 15);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(232, 46);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "تنظيف الشاشة";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(327, 15);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(232, 46);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update_std
            // 
            this.btn_update_std.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_update_std.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_std.Location = new System.Drawing.Point(614, 15);
            this.btn_update_std.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_update_std.Name = "btn_update_std";
            this.btn_update_std.Size = new System.Drawing.Size(232, 46);
            this.btn_update_std.TabIndex = 15;
            this.btn_update_std.Text = "تحديث";
            this.btn_update_std.UseVisualStyleBackColor = false;
            this.btn_update_std.Click += new System.EventHandler(this.btn_update_std_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(1185, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = "بحث";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_search.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_search.Location = new System.Drawing.Point(327, 122);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(762, 44);
            this.txt_search.TabIndex = 18;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_show_all
            // 
            this.btn_show_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_show_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_show_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_all.Location = new System.Drawing.Point(1473, 14);
            this.btn_show_all.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_show_all.Name = "btn_show_all";
            this.btn_show_all.Size = new System.Drawing.Size(232, 48);
            this.btn_show_all.TabIndex = 19;
            this.btn_show_all.Text = "عرض الكل";
            this.btn_show_all.UseVisualStyleBackColor = false;
            this.btn_show_all.Click += new System.EventHandler(this.btn_show_all_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(18, 180);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 360);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::simple_std_project.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(1100, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::simple_std_project.Properties.Resources.student_management;
            this.pictureBox2.Location = new System.Drawing.Point(18, 15);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 155);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(18, 692);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(542, 37);
            this.label8.TabIndex = 22;
            this.label8.Text = "Mas - School Management System";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::simple_std_project.Properties.Resources.back_ground2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1770, 754);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_show_all);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_update_std);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_std);
            this.Controls.Add(this.combo_gender);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_grandname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "الواجهة الرئيسية";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_grandname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox combo_gender;
        private System.Windows.Forms.Button btn_add_std;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update_std;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_show_all;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
    }
}

