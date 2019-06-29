using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Demo
{
    public partial class Form1 : Form
    {
        [DllImport("DemoDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int a, int b);
        //  CharSet = CharSet.Unicode, SetLastError = true
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label1.Text = add(a,b).ToString() ;
            //hello_world();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //TextBox objTextBox = (TextBox)sender;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
