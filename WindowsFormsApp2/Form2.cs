using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using RadioButton = System.Windows.Forms.RadioButton;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<Form1.userList.Count;i++)
            {
                if (Form1.userList[i].getId()==textBox1.Text)
                {
                    MessageBox.Show("이미 존재하는 ID입니다.");
                    return;
                }
            }
            if(textBox2.Text!=textBox3.Text)
            {
                MessageBox.Show("비밀번호가 일치하지 않습니다.");
                return;
            }

            User user = new User();
            user.setId(textBox1.Text);
            user.setPassword(textBox2.Text);

            foreach (Control control in groupBox1.Controls)
            {
                if(control.GetType()==typeof(RadioButton))
                {
                    RadioButton radioButton = (RadioButton)control;
                    if(radioButton.Checked)
                    {
                        user.setRoot(radioButton.Text);
                    }//if(radioButton.Checked)
                }//if(control.GetType()==typeof(RadioButton))
            }//foreach

            if(checkBox1.Checked==true)
            {
                user.addHobbyList(checkBox1.Text);
            }
            if(checkBox2.Checked==true)
            {
                user.addHobbyList(checkBox2.Text);
            }
            if(checkBox3.Checked==true)
            {
                user.addHobbyList(checkBox3.Text);
            }

            Form1.userList.Add(user);
            MessageBox.Show($"{textBox1.Text}님, 환영합니다.");
            Form2.ActiveForm.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
