using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxonScout
{
    public partial class Form3 : Form
    {
        private String Key;
        TextBox tb;

        public Form3(String assignedKey, TextBox TB)
        {
            Key = assignedKey;      // string to know which Key we are modifying
            tb = TB;
            InitializeComponent();  // init
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Form1 parent = (Form1)this.Owner;
            comboBox1.Text = tb.Text;  // gets the string to be modified
            groupBox1.Text = Key;   // sets the key
        }

        private void button1_Click(object sender, EventArgs e)
        {   // Save button
            Form1 parent = (Form1)this.Owner;
            parent.setString(tb, comboBox1.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   // Cancel button
            this.Close();
        }
    }
}
