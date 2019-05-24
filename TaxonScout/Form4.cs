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
    public partial class Form4 : Form
    {
        private List<String> parametersList = new List<String>();

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.dateTimePicker1.Value = dt;
            this.dateTimePicker2.Value = dt;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {   // Save button; send the data to parent form;
            Form1 parent = (Form1)this.Owner;

            parametersList.Clear();

            if (textBox1.Text.Length > 0) parametersList.Add(textBox1.Text);
            if (textBox2.Text.Length > 0) parametersList.Add(textBox2.Text);
            if (textBox3.Text.Length > 0) parametersList.Add(textBox3.Text);
            if (textBox4.Text.Length > 0) parametersList.Add(textBox4.Text);
            if (textBox5.Text.Length > 0) parametersList.Add(textBox5.Text);
            if (textBox6.Text.Length > 0) parametersList.Add(textBox6.Text);
            if (textBox7.Text.Length > 0) parametersList.Add(textBox7.Text);
            if (textBox8.Text.Length > 0) parametersList.Add(textBox8.Text);
            if (textBox9.Text.Length > 0) parametersList.Add(textBox9.Text);

            parent.parametersList = this.parametersList;
            parent.checkBoxAddSampleParamsToFile.Checked = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   // Cancel button
            this.Close();
        }
        
        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            textBox3.Text = dateTimePicker1.Value.ToString("dd-MM-yyyy");
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            textBox8.Text = dateTimePicker2.Value.ToString("dd-MM-yyyy");
        }
    }
}

