using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace myproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtname.Text))//داله تتحقق اذا النص فارغ 
            {
                MessageBox.Show("الرجاء إدخال اسم");
                return;//يرجع ينفذ الكود
            }
            if (string.IsNullOrWhiteSpace(txtdtb.Text))
            {
                MessageBox.Show("الرجاء إدخال تاريخ الميلاد");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtphone.Text))
            {
                MessageBox.Show("الرجاء إدخال رقم الهاتف");
                return;
            }
            if (!rdmale.Checked && !rdfemale.Checked)
            {
                MessageBox.Show("الرجاء اختيار الجنس");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtye.Text))
            {
                MessageBox.Show("الرجاء إدخال عام التخرج");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtdeg.Text))
            {
                MessageBox.Show("الرجاء إدخال المعدل");
                return;
            }
            if (pict.Image == null)
            {
                MessageBox.Show("الرجاء إدخال صورة الطالب");
                return;
            }
            if (combco.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اختيار التخصص");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtloc.Text))
            {
                MessageBox.Show("الرجاء إدخال مكان السكن");
                return;
            }
            //-------------------------------

            int numrow = view.Rows.Add();//يضيف لي صف جديد في القايمه الي سميتها فيو
           
           
                view.Rows[numrow].Cells["col1"].Value = txtname.Text; // يعبي العمود col2
                txtname.Clear();// إعادة تعيين الحقل بعد الإضافة 

            //----------------------------------------

            

             
                view.Rows[numrow].Cells["col2"].Value = txtdtb.Text; // يعبي العمود col2
                txtdtb.Clear();

            //---------------------------
           
            
                
                view.Rows[numrow].Cells["col3"].Value = txtphone.Text; // يعبي العمود col2
                txtphone.Clear();

        
            //--------------------------------

            if (rdmale.Checked == true)
            {
                view.Rows[numrow].Cells["col4"].Value = "ذكر";
                rdmale.Checked = false;
            }
            else if (rdfemale.Checked == true)
            { view.Rows[numrow].Cells["col4"].Value = " انثئ";
                rdfemale.Checked = false;
            }
           



            //----------------

            


                view.Rows[numrow].Cells["col5"].Value = txtye.Text;
                txtye.Clear();


            //--------------------

            view.Rows[numrow].Cells["cold"].Value = txtdeg.Text;
                txtdeg.Clear();

            //--------------------

            if (pict.Image != null)
            {


                view.Rows[numrow].Cells["col6"].Value = pict.Image;


            }
          
            //---------------------------------
            if (combco.SelectedItem != null)
            {

                view.Rows[numrow].Cells["col8"].Value = combco.SelectedItem.ToString();

                // تفريغ الكمبو بوكس بعد الإرسال
                combco.SelectedIndex = -1;
            }
          
            //-----------------------
           


                view.Rows[numrow].Cells["col9"].Value = txtloc.Text;
                txtloc.Clear();

          
            //---------------------
            if(ch1.Checked==true&& ch2.Checked==false)
            {
                view.Rows[numrow].Cells["col10"].Value = "اللغة الانجليزية";
                ch1.Checked = false;

            }
            if (ch1.Checked == false && ch2.Checked == true)
            {
                view.Rows[numrow].Cells["col10"].Value = "الحاسوب ";
               
                ch2.Checked = false;

            }
            if (ch1.Checked == false && ch2.Checked == false)
            {
                view.Rows[numrow].Cells["col10"].Value = "لا مهارة ";


            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btpic_Click(object sender, EventArgs e)
        {

            OpenFileDialog op = new OpenFileDialog();//هذا ينشئ كائن جديد من نوعopenfil .
                                                     //هي نافذة تظهر للمستخدم عشان يختار ملف من الجهاز
                                                     //(زي الصور أو ملفات نصية...).
            op.Filter = "Image Files|*.jpg;*.png;*.bmp";//هذا السطر يحدد أنواع الملفات اللي تظهر
                                                        // للمستخدم داخل نافذة التحديد.
                                                        //bmp ممنوع الملفات


            if (op.ShowDialog() == DialogResult.OK)//هذا السطر يفتح نافذة اختيار الملف.

            {
                pict.Image = Image.FromFile(op.FileName);//إذا المستخدم اختار صورة، يتم تحميل
                                                         //الصورة من المسار اللي اختاره
                                                         //(dlg.FileName) باستخدام Image.FromFile(...).
            }

        }


    }
}
    
