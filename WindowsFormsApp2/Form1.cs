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
    public partial class Form1 : Form
    {
        public static List<User> userList = new List<User>();

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(userList.Count==0)
            {
                MessageBox.Show("등록된 사용자가 없습니다.");
            }
            for(int i=0; i<userList.Count; i++)
            {
                if (userList[i].getId() == textBox1.Text)
                {
                    if (userList[i].getPassword() == textBox2.Text)
                    {
                        Form3 form3 = new Form3(userList[i]);
                        form3.ShowDialog();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 일치하지 않습니다.");
                        return;
                    }
                }
            }
        }
    }
}
