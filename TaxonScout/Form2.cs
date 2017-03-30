using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxonScout
{
    public partial class Form2 : Form
    {
        // list declaration. will be populated and used as datasource for all the comboboxes;
        private List<listElement> importedList = new List<listElement>();
        private static string filename = "./import.txt";    // here we save the file name we are importing;

        public Form2()
        {
            InitializeComponent();      // init
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.filename;

            Form1 parent = (Form1)this.Owner;
            
            // get selected taxons from parent form;
            comboBox1.Text  =  parent.textBox1.Text;   // Q
            comboBox2.Text  =  parent.textBox2.Text;   // W
            comboBox3.Text  =  parent.textBox3.Text;   // E
            comboBox4.Text  =  parent.textBox4.Text;   // R
            comboBox5.Text  =  parent.textBox5.Text;   // T
            comboBox6.Text  =  parent.textBox6.Text;   // Y
            comboBox7.Text  =  parent.textBox7.Text;   // U
            comboBox8.Text  =  parent.textBox8.Text;   // I
            comboBox9.Text  =  parent.textBox9.Text;   // O
            comboBox10.Text = parent.textBox10.Text;   // P
            comboBox11.Text = parent.textBox11.Text;   // A
            comboBox12.Text = parent.textBox12.Text;   // S
            comboBox13.Text = parent.textBox13.Text;   // D
            comboBox14.Text = parent.textBox14.Text;   // F
            comboBox15.Text = parent.textBox15.Text;   // G
            comboBox16.Text = parent.textBox16.Text;   // H
            comboBox17.Text = parent.textBox17.Text;   // J
            comboBox18.Text = parent.textBox18.Text;   // K
            comboBox19.Text = parent.textBox19.Text;   // L
            comboBox20.Text = parent.textBox20.Text;   // Z
            comboBox21.Text = parent.textBox21.Text;   // X
            comboBox22.Text = parent.textBox22.Text;   // C
            comboBox23.Text = parent.textBox23.Text;   // V
            comboBox24.Text = parent.textBox24.Text;   // B
            comboBox25.Text = parent.textBox25.Text;   // N
            comboBox26.Text = parent.textBox26.Text;   // M
            comboBox27.Text = parent.textBox27.Text;   // D1
            comboBox28.Text = parent.textBox28.Text;   // D2
            comboBox29.Text = parent.textBox29.Text;   // D3
            comboBox30.Text = parent.textBox30.Text;   // D4
            comboBox31.Text = parent.textBox31.Text;   // D5
            comboBox32.Text = parent.textBox32.Text;   // D6
            comboBox33.Text = parent.textBox33.Text;   // D7
            comboBox34.Text = parent.textBox34.Text;   // D8
            comboBox35.Text = parent.textBox35.Text;   // D9
            comboBox36.Text = parent.textBox36.Text;   // D0
            comboBox37.Text = parent.textBox37.Text;   // KeyPad7
            comboBox38.Text = parent.textBox38.Text;   // KeyPad8
            comboBox39.Text = parent.textBox39.Text;   // KeyPad9
            comboBox40.Text = parent.textBox40.Text;   // KeyPad4
            comboBox41.Text = parent.textBox41.Text;   // KeyPad5
            comboBox42.Text = parent.textBox42.Text;   // KeyPad6
            comboBox43.Text = parent.textBox43.Text;   // KeyPad1
            comboBox44.Text = parent.textBox44.Text;   // KeyPad2
            comboBox45.Text = parent.textBox45.Text;   // KeyPad3
            comboBox46.Text = parent.textBox46.Text;   // KeyPad0


        }

        class listElement : INotifyPropertyChanged
        {
            private string taxon_;
            public string Taxon
            {
                get { return taxon_; }
                set
                {
                    taxon_ = value;
                    NotifyPropertyChanged("Taxon");
                }
            }

            public listElement(string taxon)
            {
                this.Taxon = taxon;
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void NotifyPropertyChanged(string info)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(info));
                }
            }

            public override string ToString()
            {
                return taxon_;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   // import button;
            try
            {
                var bs = new BindingSource();
                string[] lines = System.IO.File.ReadAllLines(textBox1.Text);    // read all lines;

                importedList.Clear();
                listElement blankListElement = new listElement("");
                importedList.Add(blankListElement);

                foreach (string line in lines)
                {   // go through each line and add it to the list;
                    listElement listElement1 = new listElement(line);
                    importedList.Add(listElement1);
                }

                importedList.Sort((x, y) => x.Taxon.CompareTo(y.Taxon));    // sort list alphabetically
                bs.DataSource = importedList;
                updateCBdataSources(bs);    // call update of comboboxes datasources;

                Form1 parent = (Form1)this.Owner;
                parent.setBSource(bs);  // pass along to Form1 the list (as a binding source);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. " + ex.Message);
            }
        }

        private void updateCBdataSources(BindingSource bs)
        {   // create different contexts of binding source for each combobox;
            // it's useful to prevent updating to all comboboxes that share the
            // same datasource when selecting an item in one combobox;
            comboBox1.DataSource  = new BindingSource(bs, "");   // Q
            comboBox2.DataSource  = new BindingSource(bs, "");   // W
            comboBox3.DataSource  = new BindingSource(bs, "");   // E
            comboBox4.DataSource  = new BindingSource(bs, "");   // R
            comboBox5.DataSource  = new BindingSource(bs, "");   // T
            comboBox6.DataSource  = new BindingSource(bs, "");   // Y
            comboBox7.DataSource  = new BindingSource(bs, "");   // U
            comboBox8.DataSource  = new BindingSource(bs, "");   // I
            comboBox9.DataSource  = new BindingSource(bs, "");   // O
            comboBox10.DataSource = new BindingSource(bs, "");   // P
            comboBox11.DataSource = new BindingSource(bs, "");   // A
            comboBox12.DataSource = new BindingSource(bs, "");   // S
            comboBox13.DataSource = new BindingSource(bs, "");   // D
            comboBox14.DataSource = new BindingSource(bs, "");   // F
            comboBox15.DataSource = new BindingSource(bs, "");   // G
            comboBox16.DataSource = new BindingSource(bs, "");   // H
            comboBox17.DataSource = new BindingSource(bs, "");   // J
            comboBox18.DataSource = new BindingSource(bs, "");   // K
            comboBox19.DataSource = new BindingSource(bs, "");   // L
            comboBox20.DataSource = new BindingSource(bs, "");   // Z
            comboBox21.DataSource = new BindingSource(bs, "");   // X
            comboBox22.DataSource = new BindingSource(bs, "");   // C
            comboBox23.DataSource = new BindingSource(bs, "");   // V
            comboBox24.DataSource = new BindingSource(bs, "");   // B
            comboBox25.DataSource = new BindingSource(bs, "");   // N
            comboBox26.DataSource = new BindingSource(bs, "");   // M
            comboBox27.DataSource = new BindingSource(bs, "");   // D1
            comboBox28.DataSource = new BindingSource(bs, "");   // D2
            comboBox29.DataSource = new BindingSource(bs, "");   // D3
            comboBox30.DataSource = new BindingSource(bs, "");   // D4
            comboBox31.DataSource = new BindingSource(bs, "");   // D5
            comboBox32.DataSource = new BindingSource(bs, "");   // D6
            comboBox33.DataSource = new BindingSource(bs, "");   // D7
            comboBox34.DataSource = new BindingSource(bs, "");   // D8
            comboBox35.DataSource = new BindingSource(bs, "");   // D9
            comboBox36.DataSource = new BindingSource(bs, "");   // D0
            comboBox37.DataSource = new BindingSource(bs, "");   // KeyPad7
            comboBox38.DataSource = new BindingSource(bs, "");   // KeyPad8
            comboBox39.DataSource = new BindingSource(bs, "");   // KeyPad9
            comboBox40.DataSource = new BindingSource(bs, "");   // KeyPad4
            comboBox41.DataSource = new BindingSource(bs, "");   // KeyPad5
            comboBox42.DataSource = new BindingSource(bs, "");   // KeyPad6
            comboBox43.DataSource = new BindingSource(bs, "");   // KeyPad1
            comboBox44.DataSource = new BindingSource(bs, "");   // KeyPad2
            comboBox45.DataSource = new BindingSource(bs, "");   // KeyPad3
            comboBox46.DataSource = new BindingSource(bs, "");   // KeyPad0


        }

        private void button2_Click(object sender, EventArgs e)
        {   // Save button; send the data to parent form;
            Form1 parent = (Form1)this.Owner;

            parent.setString(parent.textBox1,  comboBox1.Text );  // Q
            parent.setString(parent.textBox2,  comboBox2.Text );  // W
            parent.setString(parent.textBox3,  comboBox3.Text );  // E 
            parent.setString(parent.textBox4,  comboBox4.Text );  // R
            parent.setString(parent.textBox5,  comboBox5.Text );  // T
            parent.setString(parent.textBox6,  comboBox6.Text );  // Y
            parent.setString(parent.textBox7,  comboBox7.Text );  // U
            parent.setString(parent.textBox8,  comboBox8.Text );  // I
            parent.setString(parent.textBox9,  comboBox9.Text );  // O
            parent.setString(parent.textBox10, comboBox10.Text);  // P
            parent.setString(parent.textBox11, comboBox11.Text);  // A
            parent.setString(parent.textBox12, comboBox12.Text);  // S
            parent.setString(parent.textBox13, comboBox13.Text);  // D
            parent.setString(parent.textBox14, comboBox14.Text);  // F
            parent.setString(parent.textBox15, comboBox15.Text);  // G
            parent.setString(parent.textBox16, comboBox16.Text);  // H
            parent.setString(parent.textBox17, comboBox17.Text);  // J
            parent.setString(parent.textBox18, comboBox18.Text);  // K
            parent.setString(parent.textBox19, comboBox19.Text);  // L
            parent.setString(parent.textBox20, comboBox20.Text);  // Z
            parent.setString(parent.textBox21, comboBox21.Text);  // X
            parent.setString(parent.textBox22, comboBox22.Text);  // C
            parent.setString(parent.textBox23, comboBox23.Text);  // V
            parent.setString(parent.textBox24, comboBox24.Text);  // B
            parent.setString(parent.textBox25, comboBox25.Text);  // N
            parent.setString(parent.textBox26, comboBox26.Text);  // M
            parent.setString(parent.textBox27, comboBox27.Text);  // D1
            parent.setString(parent.textBox28, comboBox28.Text);  // D2
            parent.setString(parent.textBox29, comboBox29.Text);  // D3
            parent.setString(parent.textBox30, comboBox30.Text);  // D4
            parent.setString(parent.textBox31, comboBox31.Text);  // D5
            parent.setString(parent.textBox32, comboBox32.Text);  // D6
            parent.setString(parent.textBox33, comboBox33.Text);  // D7
            parent.setString(parent.textBox34, comboBox34.Text);  // D8
            parent.setString(parent.textBox35, comboBox35.Text);  // D9
            parent.setString(parent.textBox36, comboBox36.Text);  // D0
            parent.setString(parent.textBox37, comboBox37.Text);  // KeyPad7
            parent.setString(parent.textBox38, comboBox38.Text);  // KeyPad8
            parent.setString(parent.textBox39, comboBox39.Text);  // KeyPad9
            parent.setString(parent.textBox40, comboBox40.Text);  // KeyPad4
            parent.setString(parent.textBox41, comboBox41.Text);  // KeyPad5
            parent.setString(parent.textBox42, comboBox42.Text);  // KeyPad6
            parent.setString(parent.textBox43, comboBox43.Text);  // KeyPad1
            parent.setString(parent.textBox44, comboBox44.Text);  // KeyPad2
            parent.setString(parent.textBox45, comboBox45.Text);  // KeyPad3
            parent.setString(parent.textBox46, comboBox46.Text);  // KeyPad0


            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {   // Cancel button
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                filename = textBox1.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {   // auto-distribute taxons button; fill comboboxes starting
            // from the beginning of the list
            Form1 parent = (Form1)this.Owner;
            List<String> myList = new List<String>();
            int i = 0;
            foreach (var line in parent.bs)
            {
                myList.Add(line.ToString());
                i++;
            }

            if (i >  1)  comboBox1.Text = myList[ 1];
            if (i >  2)  comboBox2.Text = myList[ 2];
            if (i >  3)  comboBox3.Text = myList[ 3];
            if (i >  4)  comboBox4.Text = myList[ 4];
            if (i >  5)  comboBox5.Text = myList[ 5];
            if (i >  6)  comboBox6.Text = myList[ 6];
            if (i >  7)  comboBox7.Text = myList[ 7];
            if (i >  8)  comboBox8.Text = myList[ 8];
            if (i >  9)  comboBox9.Text = myList[ 9];
            if (i > 10) comboBox10.Text = myList[10];
            if (i > 11) comboBox11.Text = myList[11];
            if (i > 12) comboBox12.Text = myList[12];
            if (i > 13) comboBox13.Text = myList[13];
            if (i > 14) comboBox14.Text = myList[14];
            if (i > 15) comboBox15.Text = myList[15];
            if (i > 16) comboBox16.Text = myList[16];
            if (i > 17) comboBox17.Text = myList[17];
            if (i > 18) comboBox18.Text = myList[18];
            if (i > 19) comboBox19.Text = myList[19];
            if (i > 20) comboBox20.Text = myList[20];
            if (i > 21) comboBox21.Text = myList[21];
            if (i > 22) comboBox22.Text = myList[22];
            if (i > 23) comboBox23.Text = myList[23];
            if (i > 24) comboBox24.Text = myList[24];
            if (i > 25) comboBox25.Text = myList[25];
            if (i > 26) comboBox26.Text = myList[26];
            if (i > 27) comboBox27.Text = myList[27];
            if (i > 28) comboBox28.Text = myList[28];
            if (i > 29) comboBox29.Text = myList[29];
            if (i > 30) comboBox30.Text = myList[30];
            if (i > 31) comboBox31.Text = myList[31];
            if (i > 32) comboBox32.Text = myList[32];
            if (i > 33) comboBox33.Text = myList[33];
            if (i > 34) comboBox34.Text = myList[34];
            if (i > 35) comboBox35.Text = myList[35];
            if (i > 36) comboBox36.Text = myList[36];
            if (i > 37) comboBox37.Text = myList[37];
            if (i > 38) comboBox38.Text = myList[38];
            if (i > 39) comboBox39.Text = myList[39];
            if (i > 40) comboBox40.Text = myList[40];
            if (i > 41) comboBox41.Text = myList[41];
            if (i > 42) comboBox42.Text = myList[42];
            if (i > 43) comboBox43.Text = myList[43];
            if (i > 44) comboBox44.Text = myList[44];
            if (i > 45) comboBox45.Text = myList[45];
            if (i > 46) comboBox46.Text = myList[46];


        }

        /*  This code section is useful for a possible feature in the future, one that
         *  exports to a file the entire Taxon list Binding data source.
         
        private void someKindOfButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (var line in bs)
                    {
                        file.WriteLine(line);
                    }
                }
            }
        } 

         */

    }
}
