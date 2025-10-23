using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool passwordvisible = true;

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox4.UseSystemPasswordChar = false;
            textBox5.UseSystemPasswordChar = false;
            btnpassword.Text = "👁️";
            button4.Text = "👁️";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            if (textBox1.TextLength > 10)
            {
                DialogResult result = MessageBox.Show("نام کاربر حداکثر 10 حرف باشد، قصد دارید آن پاک کنید؟", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                    textBox1.Clear();
                else if (result == DialogResult.No)
                    error = true;
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox4.Focus();
            }
        }

        private void textBox4_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox5.Focus();
            }
        }

        private void textBox5_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox6.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            if (textBox4.TextLength > 8)
            {
                DialogResult result3 = MessageBox.Show("گذرواژه حداکثر ۸ حرف باشد", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (result3 == DialogResult.Yes)
                    textBox4.Clear();
                else if (result3 == DialogResult.No)
                    error = true;
            }
        }

        private void btnpassword_Click(object sender, EventArgs e)
        {
            passwordvisible = !passwordvisible;
            textBox4.UseSystemPasswordChar = !passwordvisible;
            btnpassword.Text = passwordvisible ? "👁️" : "🙈";


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            passwordvisible = !passwordvisible;
            textBox5.UseSystemPasswordChar = !passwordvisible;
            button4.Text = passwordvisible ? "👁️" : "🙈";


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bool error = false;
            if (textBox3.TextLength > 5)
            {
                DialogResult result2 = MessageBox.Show("نام کاربری حداکثر ۵ حرف باشد", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (result2 == DialogResult.Yes)
                    textBox3.Clear();
                else if (result2 == DialogResult.No)
                    error = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            bool error = false;

            if (textBox1.TextLength > 10)
            {
                DialogResult result = MessageBox.Show("نام کاربر حداکثر 10 حرف باشد، قصد دارید آن پاک کنید؟", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                    textBox1.Clear();
                else if (result == DialogResult.No)
                    error = true;
            }
            if (textBox3.TextLength > 5)
            {
                DialogResult result2 = MessageBox.Show("نام کاربری حداکثر ۵ حرف باشد", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (result2 == DialogResult.Yes)
                    textBox3.Clear();
                else if (result2 == DialogResult.No)
                    error = true;
            }
            if (textBox4.TextLength > 8)
            {
                DialogResult result3 = MessageBox.Show("گذرواژه حداکثر ۸ حرف باشد", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (result3 == DialogResult.Yes)
                    textBox4.Clear();
                else if (result3 == DialogResult.No)
                    error = true;
            }
            if (textBox5.TextLength > 0)
            {
                if (textBox4.Text != textBox5.Text)
                {
                    DialogResult result4 = MessageBox.Show("تکرار گذرواژه با گذرواژه یکسان نیستند", "خطا", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                    if (result4 == DialogResult.Yes)
                        textBox5.Clear();
                    else if (result4 == DialogResult.No)
                        error = true;
                }
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("لطفا نام کاربر را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show("لطفا نام کاربری را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;
            }
             if (textBox4.Text == "")
            {
                MessageBox.Show("لطفا گذرواژه را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;
            }
             if (textBox5.Text == "")
            {
                MessageBox.Show("لطفا تکرار گذرواژه را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;
            }
            if (textBox6.Text == "")
            {
                MessageBox.Show("لطفا نشانی را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;
            }
            if(!error)
                MessageBox.Show("ثبت نام با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = "C:\\Users\\Asus\\Desktop\\pic";
            openFileDialog1.Filter = "Image Files(*.jpg;*.png)|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = openFileDialog1.FileName;


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void button7_Click(object sender, EventArgs e)
        {
        
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font =fontDialog1.Font;
                this.ForeColor = fontDialog1.Color;
            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
   
