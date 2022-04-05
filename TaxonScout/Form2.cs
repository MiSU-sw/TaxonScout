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
    public partial class Form2 : Form       // Form2 is opened when selecting Edit > Assign Taxa to Keys or when clicking on Key Assignments from the main window (Form1)
    {
        // list which will be populated and used as datasource for all the comboboxes;
        private List<listElement> importedList = new List<listElement>();
        // here we save the file name template we are importing;
        private static string filename = "./import.txt";

        private static readonly int numberOfKeys  = 46;

        public Label[]      labelArray    = new Label   [numberOfKeys  + 1];
        public ComboBox[]   comboBoxArray = new ComboBox[numberOfKeys  + 1];

        private Label labelStatus = new Label();
        private TextBox textBox1 = new TextBox();

        private Button button1 = new Button();
        private Button button2 = new Button();
        private Button button3 = new Button();
        private Button button4 = new Button();
        private Button button5 = new Button();
        private Button button6 = new Button();

        private GroupBox groupBox1 = new GroupBox();
        private GroupBox groupBox2 = new GroupBox();
        private GroupBox groupBox3 = new GroupBox();

        private OpenFileDialog openFileDialog1 = new OpenFileDialog();

        private static readonly int columnoffset = 10;
        private static readonly int rowOffset = 28;

        private static readonly int widthOfKey = 200;
        private static readonly int heightOfKey = 30;

        public List<Point> keyPoints = new List<Point>()
        {                                               // index    key
            new Point(0,0), // index 0 is unused
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 0),     //  1       1
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 1),     //  2       2
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 2),     //  3       3
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 3),     //  4       4
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 4),     //  5       5
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 5),     //  6       6
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 6),     //  7       7
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 7),     //  8       8
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 8),     //  9       9
            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 9),     // 10       0

            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 0),     // 11       Q
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 1),     // 12       W
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 2),     // 13       E
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 3),     // 14       R
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 4),     // 15       T
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 5),     // 16       Y
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 6),     // 17       U
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 7),     // 18       I
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 8),     // 19       O
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 9),     // 20       P

            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 0),     // 21       A
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 1),     // 22       S
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 2),     // 23       D
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 3),     // 24       F
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 4),     // 25       G
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 5),     // 26       H
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 6),     // 27       J
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 7),     // 28       K
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 8),     // 29       L
                                                            
            new Point( columnoffset + widthOfKey *  3,  rowOffset + heightOfKey * 0),     // 30       Z
            new Point( columnoffset + widthOfKey *  3,  rowOffset + heightOfKey * 1),     // 31       X
            new Point( columnoffset + widthOfKey *  3,  rowOffset + heightOfKey * 2),     // 32       C
            new Point( columnoffset + widthOfKey *  3,  rowOffset + heightOfKey * 3),     // 33       V
            new Point( columnoffset + widthOfKey *  3,  rowOffset + heightOfKey * 4),     // 34       B
            new Point( columnoffset + widthOfKey *  3,  rowOffset + heightOfKey * 5),     // 35       N
            new Point( columnoffset + widthOfKey *  3,  rowOffset + heightOfKey * 6),     // 36       M

            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 0),     // 37       Numpad 7
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 0),     // 38       Numpad 8
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 0),     // 39       Numpad 9

            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 1),     // 40       Numpad 4
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 1),     // 41       Numpad 5
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 1),     // 42       Numpad 6

            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 2),     // 43       Numpad 1
            new Point( columnoffset + widthOfKey *  1,  rowOffset + heightOfKey * 2),     // 44       Numpad 2
            new Point( columnoffset + widthOfKey *  2,  rowOffset + heightOfKey * 2),     // 45       Numpad 3

            new Point( columnoffset + widthOfKey *  0,  rowOffset + heightOfKey * 3),     // 46       Numpad 0

            new Point( 42           ,  30 + 82 * 4),     // 47       Controls groupBox 305, 144
            new Point( 42           ,  30 + 82 * 4),     // 48       Statistics groupBox 305, 144
                                  
            new Point( 55           ,  25 + 82 * 6),     // 49       Group 1 Total Count Label 55, 517, 65, 13
            new Point(130           ,  25 + 82 * 6),     // 50       Group 1 Total Count Textbox 130, 514
            new Point( 55           ,  25 + 82 * 7),     // 51       Group 2 Total Count Label 55, 517, 65, 13
            new Point(130           ,  25 + 82 * 7),     // 52       Group 2 Total Count Textbox 130, 514
            new Point( 55           ,  25 + 82 * 8),     // 53       Group 3 Total Count Label 55, 517, 65, 13
            new Point(130           ,  25 + 82 * 8),     // 54       Group 3 Total Count Textbox 130, 514
            new Point( 55           ,  25 + 82 * 9),     // 55       Group 4 Total Count Label 55, 517, 65, 13
            new Point(130           ,  25 + 82 * 9),     // 56       Group 4 Total Count Textbox 130, 514
                                  
            new Point(130           ,  25 + 82 * 9),     // 57       Button Save Data
            new Point(130           ,  25 + 82 * 9),     // 58       Sample parameters

        }; // keyPoints

        public List<String> keyList = new List<String>()
            { " ", // index 0 is unused
              "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "D0",
              "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P",
              "A", "S", "D", "F", "G", "H", "J", "K", "L",
              "Z", "X", "C", "V", "B", "N", "M",
              "N7", "N8", "N9", "N4", "N5", "N6", "N1", "N2", "N3", "N0"
            }; // keyList

        public Form2()
        {
            int i;
            for (i = 1; i <= numberOfKeys; i++)
            {
                // 
                // labelArray
                generateLabels(i);

                // 
                // comboBoxArray
                generateComboboxes(i);
            }

            generateForm2Objects();

            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.AutoSize = true;
            //this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(860, 590);
            this.AcceptButton = this.button2;
            this.CancelButton = this.button4;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);

            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);

            // set icon to a pretty algae
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            
            this.Name = "Form2";
            this.Text = "Key Assignments";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

            InitializeComponent();      // init
        }

        private void generateForm2Objects()
        {
            // textBox1
            this.textBox1.Location = new Point(6, 19);
            this.textBox1.Size = new Size(458, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = true;

            // button1
            this.button1.Location = new System.Drawing.Point(467, 17);
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Visible = true;

            // button2
            this.button2.Location = new System.Drawing.Point(493, 17);
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Import from file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.Visible = true;

            // button3
            this.button3.DialogResult = DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(648, 435);
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save Assignments";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Visible = true;

            // button4
            this.button4.DialogResult = DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(720, 29);
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.Visible = true;

            // button5
            this.button5.Location = new System.Drawing.Point(649, 465);
            this.button5.Size = new System.Drawing.Size(155, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Auto-distribute Taxa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.Visible = true;

            // button6
            this.button6.Location = new System.Drawing.Point(649, 495);
            this.button6.Size = new System.Drawing.Size(155, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Export list to file";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.Visible = true;

            // groupBox1
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Size = new System.Drawing.Size(600, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import predefined taxa list";
            this.groupBox1.Visible = true;
            this.Controls.Add(groupBox1);

            // groupBox2
            this.groupBox2.Location = new System.Drawing.Point(12, 68);
            this.groupBox2.Size = new System.Drawing.Size(800, 330);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alphanumeric Keyboard";
            int j;
            for (j = 1; j <= numberOfKeys - 10; j++)
            {
                this.groupBox2.Controls.Add(this.labelArray[j]);
                this.groupBox2.Controls.Add(this.comboBoxArray[j]);
            }
            this.groupBox2.Visible = true;
            this.Controls.Add(groupBox2);

            // groupBox3
            this.groupBox3.Location = new System.Drawing.Point(12, 410);
            this.groupBox3.Size = new System.Drawing.Size(610, 158);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NumPad";
            for (; j <= numberOfKeys; j++)
            {
                this.groupBox3.Controls.Add(this.labelArray[j]);
                this.groupBox3.Controls.Add(this.comboBoxArray[j]);
            }
            this.groupBox3.Visible = true;
            this.Controls.Add(groupBox3);

            // openFileDialog1
            this.openFileDialog1.FileName = filename;

            // labelStatus
            this.labelStatus.Location = new System.Drawing.Point(648, 35);
            this.labelStatus.Size = new System.Drawing.Size(180, 32);
            this.labelStatus.TabStop = false;
            this.labelStatus.Text = "Ready for import!";
            this.labelStatus.Visible = true;
            this.Controls.Add(labelStatus);


        }

        private void generateLabels(int i)
        {
            this.labelArray[i] = new Label();
            this.labelArray[i].AutoSize = true;
            this.labelArray[i].Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.labelArray[i].Location = keyPoints[i];
            this.labelArray[i].MaximumSize = new Size(39, 16);
            this.labelArray[i].MinimumSize = new Size(19, 16);
            this.labelArray[i].Size = new Size(19, 16);
            this.labelArray[i].TabIndex = 0;
            this.labelArray[i].Text = keyList[i];
            this.labelArray[i].TextAlign = ContentAlignment.MiddleCenter;
        }

        private void generateComboboxes(int i)
        {
            this.comboBoxArray[i] = new ComboBox();
            this.comboBoxArray[i].DropDownStyle = ComboBoxStyle.DropDown;
            this.comboBoxArray[i].FormattingEnabled = true;
            this.comboBoxArray[i].Location = new Point(labelArray[i].Location.X + 27, labelArray[i].Location.Y - 2);
            this.comboBoxArray[i].Size = new Size(155, 21);
            this.comboBoxArray[i].TabIndex = 0;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.filename;

            Form1 parent = (Form1)this.Owner;

            int i;
            for (i = 1; i <= numberOfKeys; i++)
            {
                comboBoxArray[i].Text = parent.textBoxArray[i].Text;
            }
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

        private void updateCBdataSources(BindingSource bs)
        {   // create different contexts of binding source for each combobox;
            // it's useful to prevent updating to all comboboxes that share the
            // same datasource when selecting an item in one combobox;
            int i;
            for (i = 1; i <= numberOfKeys; i++)
            {
                comboBoxArray[i].DataSource = new BindingSource(bs, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
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

                // importedList.Sort((x, y) => x.Taxon.CompareTo(y.Taxon));    // sort list alphabetically
                // remove duplicates and sort
                listCleanup(importedList);

                // assign list to binding source
                bs.DataSource = importedList;
                updateCBdataSources(bs);    // call update of comboboxes datasources;

                Form1 parent = (Form1)this.Owner;
                parent.setBSource(bs);  // pass along to Form1 the list (as a binding source);

                //MessageBox.Show("Import complete!");
                this.labelStatus.Text = "Import complete!";
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: Could not read file from disk. " + ex.Message);
                this.labelStatus.Text = "Error! Could not read file from disk!";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {   // Save button; send the data to parent form;

            Form1 parent = (Form1)this.Owner;
            var bs = new BindingSource();

            int i;
            for (i = 1; i <= numberOfKeys; i++)
            {
                // set each textbox from the parent with the combobox value
                parent.setString(parent.textBoxArray[i], comboBoxArray[i].Text);

                // for each combobox add its value to the list
                listElement listElement1 = new listElement(comboBoxArray[i].Text);
                importedList.Add(listElement1);
            }

            // remove duplicates. list will be already sorted
            listCleanup(importedList);
            
            bs.DataSource = importedList;
            updateCBdataSources(bs);    // call update of comboboxes datasources;

            parent.setBSource(bs);  // pass along to Form1 the list (as a binding source);

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {   // Cancel button

            this.Close();
        }


        private void button5_Click(object sender, EventArgs e)
        {   // auto-distribute taxons button; fill comboboxes starting
            // from the beginning of the list

            Form1 parent = (Form1)this.Owner;
            List<String> myList = new List<String>();
            int j = 0;
            foreach (var line in parent.bs)
            {
                myList.Add(line.ToString());
                j++;
            }

            if (j == 1) //empty list?
            {
                MessageBox.Show("Error: the taxon list is empty.");
            }
            else
            {
                int i;
                for (i = 1; i < j; i++)
                {
                    comboBoxArray[i].Text = myList[i];
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {   // export current taxon list to file

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "*.txt";
            saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<String> exportList = new List<String>();
                exportList.Clear();
                
                for (int i = 1; i <= numberOfKeys; i++)
                {
                    // if (!String.IsNullOrEmpty(comboBoxArray[i].Text)) 
                        exportList.Add(comboBoxArray[i].Text);
                }

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (string line in exportList)
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }

        private void listCleanup(List<listElement> list)
        {
            // Duplicates will be noticed after a sort O(nLogn)
            list.Sort((x, y) => x.Taxon.CompareTo(y.Taxon));

            // Store the current and last items. Current item declaration is not really needed, and probably optimized by the compiler, but in case it's not...
            listElement lastItem = new listElement("");
            listElement currItem = new listElement("");

            int size = list.Count;

            // Store the index pointing to the last item we want to keep in the list
            int last = size - 1;

            // Travel the items from last to first O(n)
            for (int i = last; i >= 0; --i)
            {
                currItem = list[i];

                // If this item was the same as the previous one, we don't want it
                if (currItem.Taxon.Equals(lastItem.Taxon))
                {
                    // Overwrite last in current place. It is a swap but we don't need the last
                    list[i] = list[last];

                    // Reduce the last index, we don't want that one anymore
                    last--;
                }

                // A new item, we store it and continue
                else
                    lastItem = currItem;
            }

            // We now have an unsorted list with the duplicates at the end.

            // Remove the last items just once
            list.RemoveRange(last + 1, size - last - 1);

            // Sort again O(n logn)
            list.Sort((x, y) => x.Taxon.CompareTo(y.Taxon));
        }
    }
}
