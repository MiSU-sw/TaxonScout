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
    public partial class Form3 : Form       // Form3 is opened when clicking on a "Select Taxon" button from the main window (Form1)
    {
        // list which will be populated and used as datasource for all the comboboxes;
        private List<listElement> importedList = new List<listElement>();

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

            //var bs = new BindingSource();


            //bs = parent.bs.DataSource;

            // add the value to the list
            listElement listElement1 = new listElement(comboBox1.Text);
            importedList.Add(listElement1);

            // clean up duplicates
            listCleanup(importedList);

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {   // Cancel button
            this.Close();
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

    }
}
