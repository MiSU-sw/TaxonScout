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
    public partial class Form1 : Form
    {
        public BindingSource bs = new BindingSource();
        String AssignedValue = "";
        private List<String> dummyList = new List<String>();
        public List<String> parametersList = new List<String>();

        public Form1()
        {   // subscribe this Form to the KeyUp and KeyDown keyboard events
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp   += new KeyEventHandler(Form1_KeyUp  );

            String dummy1 = "";         // create empty dummy list to initialize
            dummyList.Add(dummy1);      // comboboxes in order to not have
            bs.DataSource = dummyList;  // void/null datasources

            InitializeComponent();      // init
        }

        private void Form1_Load(object sender, EventArgs e)
        {   // KeyPreview set to true is needed for keyboard events
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {   // when pressing a key, handle it with the following code:
            switch (e.KeyCode)
            {
                case Keys.Q:         checkBox1.Checked = true;   break;
                case Keys.W:         checkBox2.Checked = true;   break;
                case Keys.E:         checkBox3.Checked = true;   break;
                case Keys.R:         checkBox4.Checked = true;   break;
                case Keys.T:         checkBox5.Checked = true;   break;
                case Keys.Y:         checkBox6.Checked = true;   break;
                case Keys.U:         checkBox7.Checked = true;   break;
                case Keys.I:         checkBox8.Checked = true;   break;
                case Keys.O:         checkBox9.Checked = true;   break;
                case Keys.P:        checkBox10.Checked = true;   break;
                case Keys.A:        checkBox11.Checked = true;   break;
                case Keys.S:        checkBox12.Checked = true;   break;
                case Keys.D:        checkBox13.Checked = true;   break;
                case Keys.F:        checkBox14.Checked = true;   break;
                case Keys.G:        checkBox15.Checked = true;   break;
                case Keys.H:        checkBox16.Checked = true;   break;
                case Keys.J:        checkBox17.Checked = true;   break;
                case Keys.K:        checkBox18.Checked = true;   break;
                case Keys.L:        checkBox19.Checked = true;   break;
                case Keys.Z:        checkBox20.Checked = true;   break;
                case Keys.X:        checkBox21.Checked = true;   break;
                case Keys.C:        checkBox22.Checked = true;   break;
                case Keys.V:        checkBox23.Checked = true;   break;
                case Keys.B:        checkBox24.Checked = true;   break;
                case Keys.N:        checkBox25.Checked = true;   break;
                case Keys.M:        checkBox26.Checked = true;   break;
                case Keys.D1:       checkBox27.Checked = true;   break;
                case Keys.D2:       checkBox28.Checked = true;   break;
                case Keys.D3:       checkBox29.Checked = true;   break;
                case Keys.D4:       checkBox30.Checked = true;   break;
                case Keys.D5:       checkBox31.Checked = true;   break;
                case Keys.D6:       checkBox32.Checked = true;   break;
                case Keys.D7:       checkBox33.Checked = true;   break;
                case Keys.D8:       checkBox34.Checked = true;   break;
                case Keys.D9:       checkBox35.Checked = true;   break;
                case Keys.D0:       checkBox36.Checked = true;   break;
                case Keys.NumPad7:  checkBox37.Checked = true;   break;
                case Keys.NumPad8:  checkBox38.Checked = true;   break;
                case Keys.NumPad9:  checkBox39.Checked = true;   break;
                case Keys.NumPad4:  checkBox40.Checked = true;   break;
                case Keys.NumPad5:  checkBox41.Checked = true;   break;
                case Keys.NumPad6:  checkBox42.Checked = true;   break;
                case Keys.NumPad1:  checkBox43.Checked = true;   break;
                case Keys.NumPad2:  checkBox44.Checked = true;   break;
                case Keys.NumPad3:  checkBox45.Checked = true;   break;
                case Keys.NumPad0:  checkBox46.Checked = true;   break;
                    
                default:  /* do nothing */  break;
            }
            
            e.Handled = false;
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {   // when releasing a key, handle it with the following code:
            switch (e.KeyCode)
            {
                case Keys.Q:         numericUpDown1.Value += 1;  checkBox1.Checked = false; break;
                case Keys.W:         numericUpDown2.Value += 1;  checkBox2.Checked = false; break;
                case Keys.E:         numericUpDown3.Value += 1;  checkBox3.Checked = false; break;
                case Keys.R:         numericUpDown4.Value += 1;  checkBox4.Checked = false; break;
                case Keys.T:         numericUpDown5.Value += 1;  checkBox5.Checked = false; break;
                case Keys.Y:         numericUpDown6.Value += 1;  checkBox6.Checked = false; break;
                case Keys.U:         numericUpDown7.Value += 1;  checkBox7.Checked = false; break;
                case Keys.I:         numericUpDown8.Value += 1;  checkBox8.Checked = false; break;
                case Keys.O:         numericUpDown9.Value += 1;  checkBox9.Checked = false; break;
                case Keys.P:        numericUpDown10.Value += 1; checkBox10.Checked = false; break;
                case Keys.A:        numericUpDown11.Value += 1; checkBox11.Checked = false; break;
                case Keys.S:        numericUpDown12.Value += 1; checkBox12.Checked = false; break;
                case Keys.D:        numericUpDown13.Value += 1; checkBox13.Checked = false; break;
                case Keys.F:        numericUpDown14.Value += 1; checkBox14.Checked = false; break;
                case Keys.G:        numericUpDown15.Value += 1; checkBox15.Checked = false; break;
                case Keys.H:        numericUpDown16.Value += 1; checkBox16.Checked = false; break;
                case Keys.J:        numericUpDown17.Value += 1; checkBox17.Checked = false; break;
                case Keys.K:        numericUpDown18.Value += 1; checkBox18.Checked = false; break;
                case Keys.L:        numericUpDown19.Value += 1; checkBox19.Checked = false; break;
                case Keys.Z:        numericUpDown20.Value += 1; checkBox20.Checked = false; break;
                case Keys.X:        numericUpDown21.Value += 1; checkBox21.Checked = false; break;
                case Keys.C:        numericUpDown22.Value += 1; checkBox22.Checked = false; break;
                case Keys.V:        numericUpDown23.Value += 1; checkBox23.Checked = false; break;
                case Keys.B:        numericUpDown24.Value += 1; checkBox24.Checked = false; break;
                case Keys.N:        numericUpDown25.Value += 1; checkBox25.Checked = false; break;
                case Keys.M:        numericUpDown26.Value += 1; checkBox26.Checked = false; break;
                case Keys.D1:       numericUpDown27.Value += 1; checkBox27.Checked = false; break;
                case Keys.D2:       numericUpDown28.Value += 1; checkBox28.Checked = false; break;
                case Keys.D3:       numericUpDown29.Value += 1; checkBox29.Checked = false; break;
                case Keys.D4:       numericUpDown30.Value += 1; checkBox30.Checked = false; break;
                case Keys.D5:       numericUpDown31.Value += 1; checkBox31.Checked = false; break;
                case Keys.D6:       numericUpDown32.Value += 1; checkBox32.Checked = false; break;
                case Keys.D7:       numericUpDown33.Value += 1; checkBox33.Checked = false; break;
                case Keys.D8:       numericUpDown34.Value += 1; checkBox34.Checked = false; break;
                case Keys.D9:       numericUpDown35.Value += 1; checkBox35.Checked = false; break;
                case Keys.D0:       numericUpDown36.Value += 1; checkBox36.Checked = false; break;
                case Keys.NumPad7:  numericUpDown37.Value += 1; checkBox37.Checked = false; break;
                case Keys.NumPad8:  numericUpDown38.Value += 1; checkBox38.Checked = false; break;
                case Keys.NumPad9:  numericUpDown39.Value += 1; checkBox39.Checked = false; break;
                case Keys.NumPad4:  numericUpDown40.Value += 1; checkBox40.Checked = false; break;
                case Keys.NumPad5:  numericUpDown41.Value += 1; checkBox41.Checked = false; break;
                case Keys.NumPad6:  numericUpDown42.Value += 1; checkBox42.Checked = false; break;
                case Keys.NumPad1:  numericUpDown43.Value += 1; checkBox43.Checked = false; break;
                case Keys.NumPad2:  numericUpDown44.Value += 1; checkBox44.Checked = false; break;
                case Keys.NumPad3:  numericUpDown45.Value += 1; checkBox45.Checked = false; break;
                case Keys.NumPad0:  numericUpDown46.Value += 1; checkBox46.Checked = false; break;
                    
                default:  /* do nothing */  break;
            }

            
            e.Handled = false;
        }

        private void CalculateTotal()
        {
            decimal sum = 0;
            sum = numericUpDown1.Value  +
                  numericUpDown2.Value  +
                  numericUpDown3.Value  +
                  numericUpDown4.Value  +
                  numericUpDown5.Value  +
                  numericUpDown6.Value  +
                  numericUpDown7.Value  +
                  numericUpDown8.Value  +
                  numericUpDown9.Value  +
                  numericUpDown10.Value +
                  numericUpDown11.Value +
                  numericUpDown12.Value +
                  numericUpDown13.Value +
                  numericUpDown14.Value +
                  numericUpDown15.Value +
                  numericUpDown16.Value +
                  numericUpDown17.Value +
                  numericUpDown18.Value +
                  numericUpDown19.Value +
                  numericUpDown20.Value +
                  numericUpDown21.Value +
                  numericUpDown22.Value +
                  numericUpDown23.Value +
                  numericUpDown24.Value +
                  numericUpDown25.Value +
                  numericUpDown26.Value +
                  numericUpDown27.Value +
                  numericUpDown28.Value +
                  numericUpDown29.Value +
                  numericUpDown30.Value +
                  numericUpDown31.Value +
                  numericUpDown32.Value +
                  numericUpDown33.Value +
                  numericUpDown34.Value +
                  numericUpDown35.Value +
                  numericUpDown36.Value +
                  numericUpDown37.Value +
                  numericUpDown38.Value +
                  numericUpDown39.Value +
                  numericUpDown40.Value +
                  numericUpDown41.Value +
                  numericUpDown42.Value +
                  numericUpDown43.Value +
                  numericUpDown44.Value +
                  numericUpDown45.Value +
                  numericUpDown46.Value;

            textBox47.Text = sum.ToString();    // write calculated value in textbox
        }

        public void setString(TextBox tb, String s)
        {   // this is used to set the value of a string to a specific textbox
            tb.Text = s;
        }

        public void setBSource(BindingSource BS)
        {   // this is used to save the binding source
            bs.DataSource = BS;
        }

        private void buttonKeyBindings_Click(object sender, EventArgs e)
        {   // launch the form that handles all the key bindings
            Form2 frm = new Form2();
            frm.comboBox1.DataSource  = new BindingSource(bs, "");  // Q
            frm.comboBox2.DataSource  = new BindingSource(bs, "");  // W
            frm.comboBox3.DataSource  = new BindingSource(bs, "");  // E
            frm.comboBox4.DataSource  = new BindingSource(bs, "");  // R
            frm.comboBox5.DataSource  = new BindingSource(bs, "");  // T
            frm.comboBox6.DataSource  = new BindingSource(bs, "");  // Y
            frm.comboBox7.DataSource  = new BindingSource(bs, "");  // U
            frm.comboBox8.DataSource  = new BindingSource(bs, "");  // I
            frm.comboBox9.DataSource  = new BindingSource(bs, "");  // O
            frm.comboBox10.DataSource = new BindingSource(bs, "");  // P
            frm.comboBox11.DataSource = new BindingSource(bs, "");  // A
            frm.comboBox12.DataSource = new BindingSource(bs, "");  // S
            frm.comboBox13.DataSource = new BindingSource(bs, "");  // D
            frm.comboBox14.DataSource = new BindingSource(bs, "");  // F
            frm.comboBox15.DataSource = new BindingSource(bs, "");  // G
            frm.comboBox16.DataSource = new BindingSource(bs, "");  // H
            frm.comboBox17.DataSource = new BindingSource(bs, "");  // J
            frm.comboBox18.DataSource = new BindingSource(bs, "");  // K
            frm.comboBox19.DataSource = new BindingSource(bs, "");  // L
            frm.comboBox20.DataSource = new BindingSource(bs, "");  // Z
            frm.comboBox21.DataSource = new BindingSource(bs, "");  // X
            frm.comboBox22.DataSource = new BindingSource(bs, "");  // C
            frm.comboBox23.DataSource = new BindingSource(bs, "");  // V
            frm.comboBox24.DataSource = new BindingSource(bs, "");  // B
            frm.comboBox25.DataSource = new BindingSource(bs, "");  // N
            frm.comboBox26.DataSource = new BindingSource(bs, "");  // M
            frm.comboBox27.DataSource = new BindingSource(bs, "");  // D1
            frm.comboBox28.DataSource = new BindingSource(bs, "");  // D2
            frm.comboBox29.DataSource = new BindingSource(bs, "");  // D3
            frm.comboBox30.DataSource = new BindingSource(bs, "");  // D4
            frm.comboBox31.DataSource = new BindingSource(bs, "");  // D5
            frm.comboBox32.DataSource = new BindingSource(bs, "");  // D6
            frm.comboBox33.DataSource = new BindingSource(bs, "");  // D7
            frm.comboBox34.DataSource = new BindingSource(bs, "");  // D8
            frm.comboBox35.DataSource = new BindingSource(bs, "");  // D9
            frm.comboBox36.DataSource = new BindingSource(bs, "");  // D0
            frm.comboBox37.DataSource = new BindingSource(bs, "");  // KeyPad7
            frm.comboBox38.DataSource = new BindingSource(bs, "");  // KeyPad8
            frm.comboBox39.DataSource = new BindingSource(bs, "");  // KeyPad9
            frm.comboBox40.DataSource = new BindingSource(bs, "");  // KeyPad4
            frm.comboBox41.DataSource = new BindingSource(bs, "");  // KeyPad5
            frm.comboBox42.DataSource = new BindingSource(bs, "");  // KeyPad6
            frm.comboBox43.DataSource = new BindingSource(bs, "");  // KeyPad1
            frm.comboBox44.DataSource = new BindingSource(bs, "");  // KeyPad2
            frm.comboBox45.DataSource = new BindingSource(bs, "");  // KeyPad3
            frm.comboBox46.DataSource = new BindingSource(bs, "");  // KeyPad0
            
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void buttonSampleParams_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();

            frm.Show(this); // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {   // File -> Exit
            Application.Exit();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {   // Q "button"
            numericUpDown1.Value += 1;  // increments by 1
            checkBox1.Checked = false;  // resets the value to not pressed
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {   // W "button"
            numericUpDown2.Value += 1;  // increments by 1
            checkBox2.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {   // E "button"
            numericUpDown3.Value += 1;  // increments by 1
            checkBox3.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {   // R "button"
            numericUpDown4.Value += 1;  // increments by 1
            checkBox4.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {   // T "button"
            numericUpDown5.Value += 1;  // increments by 1
            checkBox5.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {   // Y "button"
            numericUpDown6.Value += 1;  // increments by 1
            checkBox6.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox7_Click(object sender, EventArgs e)
        {   // U "button"
            numericUpDown7.Value += 1;  // increments by 1
            checkBox7.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox8_Click(object sender, EventArgs e)
        {   // I "button"
            numericUpDown8.Value += 1;  // increments by 1
            checkBox8.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox9_Click(object sender, EventArgs e)
        {   // O "button"
            numericUpDown9.Value += 1;  // increments by 1
            checkBox9.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox10_Click(object sender, EventArgs e)
        {   // P "button"
            numericUpDown10.Value += 1;  // increments by 1
            checkBox10.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox11_Click(object sender, EventArgs e)
        {   // A "button"
            numericUpDown11.Value += 1;  // increments by 1
            checkBox11.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox12_Click(object sender, EventArgs e)
        {   // S "button"
            numericUpDown12.Value += 1;  // increments by 1
            checkBox12.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox13_Click(object sender, EventArgs e)
        {   // D "button"
            numericUpDown13.Value += 1;  // increments by 1
            checkBox13.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox14_Click(object sender, EventArgs e)
        {   // F "button"
            numericUpDown14.Value += 1;  // increments by 1
            checkBox14.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox15_Click(object sender, EventArgs e)
        {   // G "button"
            numericUpDown15.Value += 1;  // increments by 1
            checkBox15.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox16_Click(object sender, EventArgs e)
        {   // H "button"
            numericUpDown16.Value += 1;  // increments by 1
            checkBox16.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox17_Click(object sender, EventArgs e)
        {   // J "button"
            numericUpDown17.Value += 1;  // increments by 1
            checkBox17.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox18_Click(object sender, EventArgs e)
        {   // K "button"
            numericUpDown18.Value += 1;  // increments by 1
            checkBox18.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox19_Click(object sender, EventArgs e)
        {   // L "button"
            numericUpDown19.Value += 1;  // increments by 1
            checkBox19.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox20_Click(object sender, EventArgs e)
        {   // Z "button"
            numericUpDown20.Value += 1;  // increments by 1
            checkBox20.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox21_Click(object sender, EventArgs e)
        {   // X "button"
            numericUpDown21.Value += 1;  // increments by 1
            checkBox21.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox22_Click(object sender, EventArgs e)
        {   // C "button"
            numericUpDown22.Value += 1;  // increments by 1
            checkBox22.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox23_Click(object sender, EventArgs e)
        {   // V "button"
            numericUpDown23.Value += 1;  // increments by 1
            checkBox23.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox24_Click(object sender, EventArgs e)
        {   // B "button"
            numericUpDown24.Value += 1;  // increments by 1
            checkBox24.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox25_Click(object sender, EventArgs e)
        {   // N "button"
            numericUpDown25.Value += 1;  // increments by 1
            checkBox25.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox26_Click(object sender, EventArgs e)
        {   // M "button"
            numericUpDown26.Value += 1;  // increments by 1
            checkBox26.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox27_Click(object sender, EventArgs e)
        {   // D1 "button"
            numericUpDown27.Value += 1;  // increments by 1
            checkBox27.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox28_Click(object sender, EventArgs e)
        {   // D2 "button"
            numericUpDown28.Value += 1;  // increments by 1
            checkBox28.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox29_Click(object sender, EventArgs e)
        {   // D3 "button"
            numericUpDown29.Value += 1;  // increments by 1
            checkBox29.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox30_Click(object sender, EventArgs e)
        {   // D4 "button"
            numericUpDown30.Value += 1;  // increments by 1
            checkBox30.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox31_Click(object sender, EventArgs e)
        {   // D5 "button"
            numericUpDown31.Value += 1;  // increments by 1
            checkBox31.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox32_Click(object sender, EventArgs e)
        {   // D6 "button"
            numericUpDown32.Value += 1;  // increments by 1
            checkBox32.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox33_Click(object sender, EventArgs e)
        {   // D7 "button"
            numericUpDown33.Value += 1;  // increments by 1
            checkBox33.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox34_Click(object sender, EventArgs e)
        {   // D8 "button"
            numericUpDown34.Value += 1;  // increments by 1
            checkBox34.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox35_Click(object sender, EventArgs e)
        {   // D9 "button"
            numericUpDown35.Value += 1;  // increments by 1
            checkBox35.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox36_Click(object sender, EventArgs e)
        {   // D0 "button"
            numericUpDown36.Value += 1;  // increments by 1
            checkBox36.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox37_Click(object sender, EventArgs e)
        {   // Num7 "button"
            numericUpDown37.Value += 1;  // increments by 1
            checkBox37.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox38_Click(object sender, EventArgs e)
        {   // Num8 "button"
            numericUpDown38.Value += 1;  // increments by 1
            checkBox26.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox39_Click(object sender, EventArgs e)
        {   // Num9 "button"
            numericUpDown39.Value += 1;  // increments by 1
            checkBox39.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox40_Click(object sender, EventArgs e)
        {   // Num4 "button"
            numericUpDown40.Value += 1;  // increments by 1
            checkBox40.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox41_Click(object sender, EventArgs e)
        {   // Num5 "button"
            numericUpDown41.Value += 1;  // increments by 1
            checkBox41.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox42_Click(object sender, EventArgs e)
        {   // Num6 "button"
            numericUpDown42.Value += 1;  // increments by 1
            checkBox42.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox43_Click(object sender, EventArgs e)
        {   // Num1 "button"
            numericUpDown43.Value += 1;  // increments by 1
            checkBox43.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox44_Click(object sender, EventArgs e)
        {   // Num2 "button"
            numericUpDown44.Value += 1;  // increments by 1
            checkBox44.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox45_Click(object sender, EventArgs e)
        {   // Num3 "button"
            numericUpDown45.Value += 1;  // increments by 1
            checkBox45.Checked = false;  // resets the value to not pressed            
        }

        private void checkBox46_Click(object sender, EventArgs e)
        {   // Num0 "button"
            numericUpDown46.Value += 1;  // increments by 1
            checkBox46.Checked = false;  // resets the value to not pressed            
        }

        private void button1_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Q]
            AssignedValue = groupBox1.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox1);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button2_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [W]
            AssignedValue = groupBox2.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox2);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button3_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [E]
            AssignedValue = groupBox3.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox3);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button4_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [R]
            AssignedValue = groupBox4.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox4);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button5_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [T]
            AssignedValue = groupBox5.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox5);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button6_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Y]
            AssignedValue = groupBox6.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox6);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button7_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [U]
            AssignedValue = groupBox7.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox7);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button8_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [I]
            AssignedValue = groupBox8.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox8);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button9_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [O]
            AssignedValue = groupBox9.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox9);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button10_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [P]
            AssignedValue = groupBox10.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox10);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button11_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [A]
            AssignedValue = groupBox11.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox11);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button12_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [S]
            AssignedValue = groupBox12.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox12);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button13_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D]
            AssignedValue = groupBox13.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox13);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button14_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [F]
            AssignedValue = groupBox14.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox14);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button15_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [G]
            AssignedValue = groupBox15.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox15);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button16_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [H]
            AssignedValue = groupBox16.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox16);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button17_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [J]
            AssignedValue = groupBox17.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox17);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button18_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [K]
            AssignedValue = groupBox18.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox18);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button19_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [L]
            AssignedValue = groupBox19.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox19);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button20_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Z]
            AssignedValue = groupBox20.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox20);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button21_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [X]
            AssignedValue = groupBox21.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox21);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button22_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [C]
            AssignedValue = groupBox22.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox22);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button23_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [V]
            AssignedValue = groupBox23.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox23);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button24_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [B]
            AssignedValue = groupBox24.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox24);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button25_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [N]
            AssignedValue = groupBox25.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox25);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button26_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [M]
            AssignedValue = groupBox26.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox26);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button27_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D1]
            AssignedValue = groupBox27.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox27);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button28_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D2]
            AssignedValue = groupBox28.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox28);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button29_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D3]
            AssignedValue = groupBox29.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox29);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button30_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D4]
            AssignedValue = groupBox30.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox30);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button31_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D5]
            AssignedValue = groupBox31.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox31);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button32_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D6]
            AssignedValue = groupBox32.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox32);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button33_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D7]
            AssignedValue = groupBox26.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox33);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button34_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D8]
            AssignedValue = groupBox34.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox34);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button35_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D9]
            AssignedValue = groupBox35.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox35);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button36_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [D0]
            AssignedValue = groupBox36.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox36);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button37_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num7]
            AssignedValue = groupBox37.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox37);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button38_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num8]
            AssignedValue = groupBox38.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox38);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button39_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num9]
            AssignedValue = groupBox39.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox39);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button40_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num4]
            AssignedValue = groupBox40.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox40);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button41_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num5]
            AssignedValue = groupBox41.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox41);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button42_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num6]
            AssignedValue = groupBox42.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox42);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button43_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num1]
            AssignedValue = groupBox43.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox43);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button44_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num2]
            AssignedValue = groupBox44.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox44);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button45_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num3]
            AssignedValue = groupBox45.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox45);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void button46_Click(object sender, EventArgs e)
        {   // launch the form that handles a single key binding [Num0]
            AssignedValue = groupBox46.Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox46);   // key is sent as a parameter. easy, huh?
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner. Let him know who's the boss
        }

        private void bindAlgaeToKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonKeyBindings.PerformClick();
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.RestoreDirectory = (false);
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "*.txt";
            saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // add every textbox and count value to a list
                List<String> exportList = new List<String>();
                exportList.Clear();
                if (checkBox47.Checked)
                {
                    exportList.Add("==================================================");
                    exportList.AddRange(parametersList);
                    exportList.Add("==================================================");
                    exportList.Add("");
                }
                
                if ( numericUpDown1.Value != 0) exportList.Add( textBox1.Text + "\t" + numericUpDown1.Value);  // Q
                if ( numericUpDown2.Value != 0) exportList.Add( textBox2.Text + "\t" + numericUpDown2.Value);  // W
                if ( numericUpDown3.Value != 0) exportList.Add( textBox3.Text + "\t" + numericUpDown3.Value);  // E
                if ( numericUpDown4.Value != 0) exportList.Add( textBox4.Text + "\t" + numericUpDown4.Value);  // R
                if ( numericUpDown5.Value != 0) exportList.Add( textBox5.Text + "\t" + numericUpDown5.Value);  // T
                if ( numericUpDown6.Value != 0) exportList.Add( textBox6.Text + "\t" + numericUpDown6.Value);  // Y
                if ( numericUpDown7.Value != 0) exportList.Add( textBox7.Text + "\t" + numericUpDown7.Value);  // U
                if ( numericUpDown8.Value != 0) exportList.Add( textBox8.Text + "\t" + numericUpDown8.Value);  // I
                if ( numericUpDown9.Value != 0) exportList.Add( textBox9.Text + "\t" + numericUpDown9.Value);  // O
                if (numericUpDown10.Value != 0) exportList.Add(textBox10.Text + "\t" + numericUpDown10.Value); // P
                if (numericUpDown11.Value != 0) exportList.Add(textBox11.Text + "\t" + numericUpDown11.Value); // A
                if (numericUpDown12.Value != 0) exportList.Add(textBox12.Text + "\t" + numericUpDown12.Value); // S
                if (numericUpDown13.Value != 0) exportList.Add(textBox13.Text + "\t" + numericUpDown13.Value); // D
                if (numericUpDown14.Value != 0) exportList.Add(textBox14.Text + "\t" + numericUpDown14.Value); // F
                if (numericUpDown15.Value != 0) exportList.Add(textBox15.Text + "\t" + numericUpDown15.Value); // G
                if (numericUpDown16.Value != 0) exportList.Add(textBox16.Text + "\t" + numericUpDown16.Value); // H
                if (numericUpDown17.Value != 0) exportList.Add(textBox17.Text + "\t" + numericUpDown17.Value); // J
                if (numericUpDown18.Value != 0) exportList.Add(textBox18.Text + "\t" + numericUpDown18.Value); // K
                if (numericUpDown19.Value != 0) exportList.Add(textBox19.Text + "\t" + numericUpDown19.Value); // L
                if (numericUpDown20.Value != 0) exportList.Add(textBox20.Text + "\t" + numericUpDown20.Value); // Z
                if (numericUpDown21.Value != 0) exportList.Add(textBox21.Text + "\t" + numericUpDown21.Value); // X
                if (numericUpDown22.Value != 0) exportList.Add(textBox22.Text + "\t" + numericUpDown22.Value); // C
                if (numericUpDown23.Value != 0) exportList.Add(textBox23.Text + "\t" + numericUpDown23.Value); // V
                if (numericUpDown24.Value != 0) exportList.Add(textBox24.Text + "\t" + numericUpDown24.Value); // B
                if (numericUpDown25.Value != 0) exportList.Add(textBox25.Text + "\t" + numericUpDown25.Value); // N
                if (numericUpDown26.Value != 0) exportList.Add(textBox26.Text + "\t" + numericUpDown26.Value); // M
                if (numericUpDown27.Value != 0) exportList.Add(textBox27.Text + "\t" + numericUpDown27.Value); // D1
                if (numericUpDown28.Value != 0) exportList.Add(textBox28.Text + "\t" + numericUpDown28.Value); // D2
                if (numericUpDown29.Value != 0) exportList.Add(textBox29.Text + "\t" + numericUpDown29.Value); // D3
                if (numericUpDown30.Value != 0) exportList.Add(textBox30.Text + "\t" + numericUpDown30.Value); // D4
                if (numericUpDown31.Value != 0) exportList.Add(textBox31.Text + "\t" + numericUpDown31.Value); // D5
                if (numericUpDown32.Value != 0) exportList.Add(textBox32.Text + "\t" + numericUpDown32.Value); // D6
                if (numericUpDown33.Value != 0) exportList.Add(textBox33.Text + "\t" + numericUpDown33.Value); // D7
                if (numericUpDown34.Value != 0) exportList.Add(textBox34.Text + "\t" + numericUpDown34.Value); // D8
                if (numericUpDown35.Value != 0) exportList.Add(textBox35.Text + "\t" + numericUpDown35.Value); // D9
                if (numericUpDown36.Value != 0) exportList.Add(textBox36.Text + "\t" + numericUpDown36.Value); // D0
                if (numericUpDown37.Value != 0) exportList.Add(textBox37.Text + "\t" + numericUpDown37.Value); // KeyPad7
                if (numericUpDown38.Value != 0) exportList.Add(textBox38.Text + "\t" + numericUpDown38.Value); // KeyPad8
                if (numericUpDown39.Value != 0) exportList.Add(textBox39.Text + "\t" + numericUpDown39.Value); // KeyPad9
                if (numericUpDown40.Value != 0) exportList.Add(textBox40.Text + "\t" + numericUpDown40.Value); // KeyPad4
                if (numericUpDown41.Value != 0) exportList.Add(textBox41.Text + "\t" + numericUpDown41.Value); // KeyPad5
                if (numericUpDown42.Value != 0) exportList.Add(textBox42.Text + "\t" + numericUpDown42.Value); // KeyPad6
                if (numericUpDown43.Value != 0) exportList.Add(textBox43.Text + "\t" + numericUpDown43.Value); // KeyPad1
                if (numericUpDown44.Value != 0) exportList.Add(textBox44.Text + "\t" + numericUpDown44.Value); // KeyPad2
                if (numericUpDown45.Value != 0) exportList.Add(textBox45.Text + "\t" + numericUpDown45.Value); // KeyPad3
                if (numericUpDown46.Value != 0) exportList.Add(textBox46.Text + "\t" + numericUpDown46.Value); // KeyPad0
                
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    foreach (string line in exportList)
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSaveData.PerformClick();
        }

        private void sampleParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSampleParams.PerformClick();
        }

        private void resetAllCountersToZeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value  = 0;
            numericUpDown2.Value  = 0;
            numericUpDown3.Value  = 0;
            numericUpDown4.Value  = 0;
            numericUpDown5.Value  = 0;
            numericUpDown6.Value  = 0;
            numericUpDown7.Value  = 0;
            numericUpDown8.Value  = 0;
            numericUpDown9.Value  = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
            numericUpDown28.Value = 0;
            numericUpDown29.Value = 0;
            numericUpDown30.Value = 0;
            numericUpDown31.Value = 0;
            numericUpDown32.Value = 0;
            numericUpDown33.Value = 0;
            numericUpDown34.Value = 0;
            numericUpDown35.Value = 0;
            numericUpDown36.Value = 0;
            numericUpDown37.Value = 0;
            numericUpDown38.Value = 0;
            numericUpDown39.Value = 0;
            numericUpDown40.Value = 0;
            numericUpDown41.Value = 0;
            numericUpDown42.Value = 0;
            numericUpDown43.Value = 0;
            numericUpDown44.Value = 0;
            numericUpDown45.Value = 0;
            numericUpDown46.Value = 0;

            CalculateTotal(); // recalculate total
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown11_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown13_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown14_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown15_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown16_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown17_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown18_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown19_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown20_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown21_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown22_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown24_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown25_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown26_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown27_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown28_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown29_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown30_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown31_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown32_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown33_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown34_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown35_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown36_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown37_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown38_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown39_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown40_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown41_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown42_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown43_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown44_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown45_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void numericUpDown46_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        }

        private void newCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
            textBox39.Text = "";
            textBox40.Text = "";
            textBox41.Text = "";
            textBox42.Text = "";
            textBox43.Text = "";
            textBox44.Text = "";
            textBox45.Text = "";
            textBox46.Text = "";

            resetAllCountersToZeroToolStripMenuItem.PerformClick();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;
            }
        }
    }
}
