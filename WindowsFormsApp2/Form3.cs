using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3(User user)
        {
            InitializeComponent();
            textBox1.Text = user.getId();
            textBox2.Text = user.getPassword();
            if(user.getRoot()=="인터넷 사이트")
            {                 
                radioButton1.Checked = true;
            }
            else if(user.getRoot()=="지인을 통해")
            {
                radioButton2.Checked = true;
            }
            else if(user.getRoot()=="기타")
            {
                radioButton3.Checked = true;
            }
            if(user.getHobbyList().Contains("C# 프로그래밍"))
            {
                checkBox1.Checked = true;
            }
            if(user.getHobbyList().Contains("게임"))
            {
                checkBox2.Checked = true;
            }
            if(user.getHobbyList().Contains("음악"))
            {
                checkBox3.Checked = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
