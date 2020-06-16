using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simple_std_project.Logical_layer;
namespace simple_std_project
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            combo_gender.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

       // show all btn

        private void btn_show_all_Click(object sender, EventArgs e)
        {
            std_class obj = new std_class();
            dataGridView1.DataSource = obj.getAllStd();

            dataGridView1.Columns[0].HeaderText = "التسلسل";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "اسم الاب";
            dataGridView1.Columns[3].HeaderText = "اسم الجد";
            dataGridView1.Columns[4].HeaderText = "رقم الهاتف";
            dataGridView1.Columns[5].HeaderText = "عنوان البريد الالكتروني";
            dataGridView1.Columns[6].HeaderText = "الجنس";

        }

        // add btn
        private void btn_add_std_Click(object sender, EventArgs e)
        {
            std_class obj = new std_class();
           
            obj.inserting_std(txt_fname.Text,txt_lname.Text,txt_grandname.Text,combo_gender.Text,txt_phone.Text,txt_email.Text);
           dataGridView1.DataSource = obj.getAllStd();

          
            dataGridView1.Columns[0].HeaderText = "التسلسل";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "اسم الاب";
            dataGridView1.Columns[3].HeaderText = "اسم الجد";
            dataGridView1.Columns[4].HeaderText = "رقم الهاتف";
            dataGridView1.Columns[5].HeaderText = "عنوان البريد الالكتروني";
            dataGridView1.Columns[6].HeaderText = "الجنس";
        }

        
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            

        }

        private void dataGridView1_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        // del btn
        private void btn_delete_Click(object sender, EventArgs e)
        {
            std_class obj = new std_class();
            if (MessageBox.Show("هل تريد حذف الاسم؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                  obj.DELETE_STD(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                 MessageBox.Show(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
               // dataGridView1.Refresh();
               dataGridView1.DataSource = obj.getAllStd(); 

                MessageBox.Show("تمت عملية الحذف");
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_lname.Clear();
            txt_grandname.Clear();
            txt_email.Clear();
            txt_phone.Clear();
            combo_gender.SelectedIndex =-1;
            txt_search.Clear();
            dataGridView1.DataSource=null;
            
        }

        // search btn
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            std_class obj = new std_class();
            dataGridView1.DataSource = obj.getAllMatchedStd(txt_search.Text.ToString());
            dataGridView1.Columns[0].HeaderText = "التسلسل";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "اسم الاب";
            dataGridView1.Columns[3].HeaderText = "اسم الجد";
            dataGridView1.Columns[4].HeaderText = "رقم الهاتف";
            dataGridView1.Columns[5].HeaderText = "عنوان البريد الالكتروني";
            dataGridView1.Columns[6].HeaderText = "الجنس";
        }

        private void btn_update_std_Click(object sender, EventArgs e)
        {

        }

        private void combo_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
