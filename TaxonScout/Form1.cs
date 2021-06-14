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
using System.Drawing.Drawing2D;

namespace TaxonScout
{
    public partial class Form1 : Form
    {
        MenuStrip menuStrip1 = new MenuStrip();
        private ToolStripMenuItem fileToolStripMenuItem                   = new ToolStripMenuItem();
        private ToolStripMenuItem saveAsToolStripMenuItem                 = new ToolStripMenuItem();
        private ToolStripMenuItem toolStripMenuItem1                      = new ToolStripMenuItem();
        private ToolStripMenuItem editToolStripMenuItem                   = new ToolStripMenuItem();
        private ToolStripMenuItem bindTaxonToKeysToolStripMenuItem        = new ToolStripMenuItem();
        private ToolStripMenuItem optionsToolStripMenuItem                = new ToolStripMenuItem();
        private ToolStripMenuItem resetAllCountersToZeroToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem helpToolStripMenuItem                   = new ToolStripMenuItem();
        private ToolStripMenuItem aboutToolStripMenuItem                  = new ToolStripMenuItem();
        private ToolStripMenuItem newCountToolStripMenuItem               = new ToolStripMenuItem();
        private ToolStripMenuItem sampleParametersToolStripMenuItem       = new ToolStripMenuItem();

        private ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();
        private ToolStripSeparator toolStripSeparator2 = new ToolStripSeparator();


        public BindingSource bs = new BindingSource();
        String AssignedValue = "";
        private GroupBoxMOD groupBoxCtrls;
        private GroupBoxMOD groupBoxStatistics;
        private GroupBoxMOD groupBoxHistory;
        private Button      buttonKeyBindings;
        private Button      buttonSampleParams;
        private Button      buttonSaveData;
        private Button      FgColorButton;
        private Button      BkColorButton;
        public  CheckBox    checkBoxAddSampleParamsToFile;
        private Label       labelGroup1;
        private TextBox     textBoxGroup1;
        private Label       labelGroup2;
        private TextBox     textBoxGroup2;
        private Label       labelGroup3;
        private TextBox     textBoxGroup3;
        private Label       labelGroup4;
        private TextBox     textBoxGroup4;
        private Label       labelTotal;
        private TextBox     textBoxTotal;
        private Label       labelLastKey;
        private TextBox     textBoxLastKey;

        private List<String> dummyList      = new List<String>();
        public  List<String> parametersList = new List<String>();

        private static readonly int numberOfKeys = 46;

        public List<String> keyList = new List<String>()
            { " ", // index 0 is unused
              "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
              "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P",
              "A", "S", "D", "F", "G", "H", "J", "K", "L",
              "Z", "X", "C", "V", "B", "N", "M",
              "NumPad7", "NumPad8", "NumPad9", "NumPad4", "NumPad5", "NumPad6", "NumPad1", "NumPad2", "NumPad3", "NumPad0"
            }; // keyList

        const int column1offset =  4;
        const int column2offset = 14;
        const int column3offset = 24;
        const int column4offset = 34;

        const int rowOffset = 25;

        const int widthOfKey = 126;
        const int heightOfKey = 82;

        public List<Point> keyPoints = new List<Point>()
        {                                               // index    key
            new Point(0,0), // index 0 is unused
            new Point(column1offset + widthOfKey *  0,  rowOffset + heightOfKey * 0),     //  1       1
            new Point(column1offset + widthOfKey *  1,  rowOffset + heightOfKey * 0),     //  2       2
            new Point(column1offset + widthOfKey *  2,  rowOffset + heightOfKey * 0),     //  3       3
            new Point(column1offset + widthOfKey *  3,  rowOffset + heightOfKey * 0),     //  4       4
            new Point(column1offset + widthOfKey *  4,  rowOffset + heightOfKey * 0),     //  5       5
            new Point(column1offset + widthOfKey *  5,  rowOffset + heightOfKey * 0),     //  6       6
            new Point(column1offset + widthOfKey *  6,  rowOffset + heightOfKey * 0),     //  7       7
            new Point(column1offset + widthOfKey *  7,  rowOffset + heightOfKey * 0),     //  8       8
            new Point(column1offset + widthOfKey *  8,  rowOffset + heightOfKey * 0),     //  9       9
            new Point(column1offset + widthOfKey *  9,  rowOffset + heightOfKey * 0),     // 10       0

            new Point(column2offset + widthOfKey *  0,  rowOffset + heightOfKey * 1),     // 11       Q
            new Point(column2offset + widthOfKey *  1,  rowOffset + heightOfKey * 1),     // 12       W
            new Point(column2offset + widthOfKey *  2,  rowOffset + heightOfKey * 1),     // 13       E
            new Point(column2offset + widthOfKey *  3,  rowOffset + heightOfKey * 1),     // 14       R
            new Point(column2offset + widthOfKey *  4,  rowOffset + heightOfKey * 1),     // 15       T
            new Point(column2offset + widthOfKey *  5,  rowOffset + heightOfKey * 1),     // 16       Y
            new Point(column2offset + widthOfKey *  6,  rowOffset + heightOfKey * 1),     // 17       U
            new Point(column2offset + widthOfKey *  7,  rowOffset + heightOfKey * 1),     // 18       I
            new Point(column2offset + widthOfKey *  8,  rowOffset + heightOfKey * 1),     // 19       O
            new Point(column2offset + widthOfKey *  9,  rowOffset + heightOfKey * 1),     // 20       P

            new Point(column3offset + widthOfKey *  0,  rowOffset + heightOfKey * 2),     // 21       A
            new Point(column3offset + widthOfKey *  1,  rowOffset + heightOfKey * 2),     // 22       S
            new Point(column3offset + widthOfKey *  2,  rowOffset + heightOfKey * 2),     // 23       D
            new Point(column3offset + widthOfKey *  3,  rowOffset + heightOfKey * 2),     // 24       F
            new Point(column3offset + widthOfKey *  4,  rowOffset + heightOfKey * 2),     // 25       G
            new Point(column3offset + widthOfKey *  5,  rowOffset + heightOfKey * 2),     // 26       H
            new Point(column3offset + widthOfKey *  6,  rowOffset + heightOfKey * 2),     // 27       J
            new Point(column3offset + widthOfKey *  7,  rowOffset + heightOfKey * 2),     // 28       K
            new Point(column3offset + widthOfKey *  8,  rowOffset + heightOfKey * 2),     // 29       L
                                                            
            new Point(column4offset + widthOfKey *  0,  rowOffset + heightOfKey * 3),     // 30       Z
            new Point(column4offset + widthOfKey *  1,  rowOffset + heightOfKey * 3),     // 31       X
            new Point(column4offset + widthOfKey *  2,  rowOffset + heightOfKey * 3),     // 32       C
            new Point(column4offset + widthOfKey *  3,  rowOffset + heightOfKey * 3),     // 33       V
            new Point(column4offset + widthOfKey *  4,  rowOffset + heightOfKey * 3),     // 34       B
            new Point(column4offset + widthOfKey *  5,  rowOffset + heightOfKey * 3),     // 35       N
            new Point(column4offset + widthOfKey *  6,  rowOffset + heightOfKey * 3),     // 36       M

            new Point(column4offset + widthOfKey *  7,  rowOffset + heightOfKey * 3),     // 37       Numpad 7
            new Point(column4offset + widthOfKey *  8,  rowOffset + heightOfKey * 3),     // 38       Numpad 8
            new Point(column4offset + widthOfKey *  9,  rowOffset + heightOfKey * 3),     // 39       Numpad 9

            new Point(column4offset + widthOfKey *  7,  rowOffset + heightOfKey * 4),     // 40       Numpad 4
            new Point(column4offset + widthOfKey *  8,  rowOffset + heightOfKey * 4),     // 41       Numpad 5
            new Point(column4offset + widthOfKey *  9,  rowOffset + heightOfKey * 4),     // 42       Numpad 6

            new Point(column4offset + widthOfKey *  7,  rowOffset + heightOfKey * 5),     // 43       Numpad 1
            new Point(column4offset + widthOfKey *  8,  rowOffset + heightOfKey * 5),     // 44       Numpad 2
            new Point(column4offset + widthOfKey *  9,  rowOffset + heightOfKey * 5),     // 45       Numpad 3

            new Point(column4offset + widthOfKey *  7,  rowOffset + heightOfKey * 6),     // 46       Numpad 0

            new Point( 42          ,  30 + heightOfKey * 4),     // 47       Controls groupBox 305, 144
            new Point( 42          ,  30 + heightOfKey * 4),     // 48       Statistics groupBox 305, 144

            new Point( 55          ,  rowOffset + heightOfKey * 6),     // 49       Group 1 Total Count Label 55, 517, 65, 13
            new Point(130          ,  rowOffset + heightOfKey * 6),     // 50       Group 1 Total Count Textbox 130, 514
            new Point( 55          ,  rowOffset + heightOfKey * 7),     // 51       Group 2 Total Count Label 55, 517, 65, 13
            new Point(130          ,  rowOffset + heightOfKey * 7),     // 52       Group 2 Total Count Textbox 130, 514
            new Point( 55          ,  rowOffset + heightOfKey * 8),     // 53       Group 3 Total Count Label 55, 517, 65, 13
            new Point(130          ,  rowOffset + heightOfKey * 8),     // 54       Group 3 Total Count Textbox 130, 514
            new Point( 55          ,  rowOffset + heightOfKey * 9),     // 55       Group 4 Total Count Label 55, 517, 65, 13
            new Point(130          ,  rowOffset + heightOfKey * 9),     // 56       Group 4 Total Count Textbox 130, 514

            new Point(130          ,  rowOffset + heightOfKey * 9),     // 57       Button Save Data
            new Point(130          ,  rowOffset + heightOfKey * 9),     // 58       Sample parameters

        }; // keyPoints

        // these arrays are only for key-assigned Controls
        private GroupBoxMOD[]   groupBox_kb  = new GroupBoxMOD  [numberOfKeys + 1];
        private TextBox[]       textBox_kb   = new TextBox      [numberOfKeys + 1];
        private CheckBox[]      checkBox_kb  = new CheckBox     [numberOfKeys + 1];
        private Button[]        button_kb    = new Button       [numberOfKeys + 1];
        private Label[]         label_kb     = new Label        [numberOfKeys + 1];
        private NumericUpDown[] numericUD_kb = new NumericUpDown[numberOfKeys + 1];

        const int groupBoxCount =           49;
        const int selectTaxonButtonCount =  46;
        const int checkBoxCount =           47;
        const int numericUpDownCount =      46;
        const int textBoxCount =            48;
        const int labelCount =              48;

        // these arrays are for all Controls on this Form
        GroupBoxMOD[]         GroupBoxArray = new GroupBoxMOD   [groupBoxCount + 1];
        Button[]           selectTaxonArray = new Button        [selectTaxonButtonCount + 1];
        CheckBox[]            checkBoxArray = new CheckBox      [checkBoxCount + 1];
        NumericUpDown[]  numericUpDownArray = new NumericUpDown [numericUpDownCount + 1];
        public TextBox[]       textBoxArray = new TextBox       [textBoxCount + 1];
        Label[]                  labelArray = new Label         [labelCount + 1];

        ListBox historyListBox = new ListBox();


        public Form1()
        {
            // set window title
            this.Text = "TaxonScout";

            // set window dimensions
            this.Size = new Size(1322, 650);
            this.AutoScroll = true;

            // start centered on screen
            this.CenterToScreen();

            // subscribe this Form to the KeyUp and KeyDown keyboard events
            this.Load += new EventHandler(this.Form1_Load);
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);

            String dummy1 = "";         // create empty dummy list to initialize
            dummyList.Add(dummy1);      // comboboxes in order to not have
            bs.DataSource = dummyList;  // void/null datasources

            int i;

            // programmatically generate key-assigned objects
            for (i = 1; i <= 46; i++)
            {
                // groupBox
                generateGroupboxes(i);

                // button
                generateButtons(i);

                // checkBox
                generateCheckboxes(i);

                // textBox
                generateTextboxes(i);

                // label
                generateLabels(i);

                // numericUpDown
                generateNumericupdowns(i);
            }

            // this Form's other objects
            generateForm1Objects(i);

            // this Form's tool strip menu
            generateToolStripMenu();


            InitializeComponent();
        } // Form1

        private void generateGroupboxes(int i)
        {
            groupBox_kb[i] = new GroupBoxMOD();
            GroupBoxArray[i] = groupBox_kb[i];
            groupBox_kb[i].Location = keyPoints[i];
            groupBox_kb[i].Text = keyList[i];
            groupBox_kb[i].Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

            groupBox_kb[i].Controls.Add(button_kb[i] = new Button());
            groupBox_kb[i].Controls.Add(checkBox_kb[i] = new CheckBox());
            groupBox_kb[i].Controls.Add(textBox_kb[i] = new TextBox());
            groupBox_kb[i].Controls.Add(label_kb[i] = new Label());
            groupBox_kb[i].Controls.Add(numericUD_kb[i] = new NumericUpDown());

            selectTaxonArray[i] = button_kb[i];
            checkBoxArray[i] = checkBox_kb[i];
            textBoxArray[i] = textBox_kb[i];
            labelArray[i] = label_kb[i];
            numericUpDownArray[i] = numericUD_kb[i];

            groupBox_kb[i].Size = new Size(125, heightOfKey);
            groupBox_kb[i].TabIndex = 8 + i * 6;
            groupBox_kb[i].TabStop = false;

            this.Controls.Add(groupBox_kb[i]);
        }

        private void generateButtons(int i)
        {
            button_kb[i].Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            button_kb[i].Location = new Point(8, 18);
            button_kb[i].Size = new Size(79, 20);
            button_kb[i].TabIndex = 10 + i * 6;
            button_kb[i].Text = "Select Taxon";
            button_kb[i].Name = i.ToString();
            button_kb[i].UseVisualStyleBackColor = true;
            button_kb[i].Click += new System.EventHandler(this.button_Click);
        }

        private void generateCheckboxes(int i)
        {
            checkBox_kb[i].Appearance = System.Windows.Forms.Appearance.Button;
            checkBox_kb[i].AutoSize = true;
            checkBox_kb[i].Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            checkBox_kb[i].Location = new Point(96, 18);
            checkBox_kb[i].MaximumSize = new Size(25, 20);
            checkBox_kb[i].MinimumSize = new Size(25, 20);
            checkBox_kb[i].Size = new Size(25, 20);
            checkBox_kb[i].TabIndex = 11 + i * 6;
            switch (i)
            {
                case 37:
                    {
                        checkBox_kb[i].Text = "7";
                    }; break;
                case 38:
                    {
                        checkBox_kb[i].Text = "8";
                    }; break;
                case 39:
                    {
                        checkBox_kb[i].Text = "9";
                    }; break;
                case 40:
                    {
                        checkBox_kb[i].Text = "4";
                    }; break;
                case 41:
                    {
                        checkBox_kb[i].Text = "5";
                    }; break;
                case 42:
                    {
                        checkBox_kb[i].Text = "6";
                    }; break;
                case 43:
                    {
                        checkBox_kb[i].Text = "1";
                    }; break;
                case 44:
                    {
                        checkBox_kb[i].Text = "2";
                    }; break;
                case 45:
                    {
                        checkBox_kb[i].Text = "3";
                    }; break;
                case 46:
                    {
                        checkBox_kb[i].Text = "0";
                    }; break;

                default:
                    {
                        checkBox_kb[i].Text = keyList[i];
                    }; break;
            }
            checkBox_kb[i].TextAlign = ContentAlignment.MiddleCenter;
            checkBox_kb[i].UseVisualStyleBackColor = true;
            checkBox_kb[i].Click += new System.EventHandler(this.checkBox_Click);
        }

        private void generateTextboxes(int i)
        {
            textBox_kb[i].Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            textBox_kb[i].Location = new Point(0, 39);
            textBox_kb[i].ReadOnly = true;
            textBox_kb[i].Size = new Size(129, 18);
            textBox_kb[i].TabIndex = 12 + i * 6;
        }

        private void generateLabels(int i)
        {
            label_kb[i].AutoSize = true;
            label_kb[i].Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            label_kb[i].Location = new Point(8, 60);
            label_kb[i].Size = new Size(38, 13);
            label_kb[i].TabIndex = 13 + i * 6;
            label_kb[i].Text = "Count:";
        }


        private void generateNumericupdowns(int i)
        {
            numericUD_kb[i].Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            numericUD_kb[i].Location = new Point(51, 58);
            numericUD_kb[i].Size = new Size(70, 20);
            numericUD_kb[i].TabIndex = 14 + i * 6;
            numericUD_kb[i].TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numericUD_kb[i].ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            numericUD_kb[i].Maximum = 999999999999;
        }

        private void generateForm1Objects(int i)
        {
            // 
            // buttonKeyBindings
            // 
            this.buttonKeyBindings = new System.Windows.Forms.Button();
            this.buttonKeyBindings.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.buttonKeyBindings.Location = new Point(8, 26);
            this.buttonKeyBindings.Name = "buttonKeyBindings";
            this.buttonKeyBindings.Size = new Size(106, 23);
            this.buttonKeyBindings.TabIndex = 1;
            this.buttonKeyBindings.Text = "Key Assignments";
            this.buttonKeyBindings.UseVisualStyleBackColor = true;
            this.buttonKeyBindings.Click += new System.EventHandler(this.buttonKeyBindings_Click);
            // 
            // buttonSampleParams
            // 
            this.buttonSampleParams = new System.Windows.Forms.Button();
            this.buttonSampleParams.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.buttonSampleParams.Location = new Point(8, 55);
            this.buttonSampleParams.Name = "buttonSampleParams";
            this.buttonSampleParams.Size = new Size(106, 23);
            this.buttonSampleParams.TabIndex = 2;
            this.buttonSampleParams.Text = "Sample Parameters";
            this.buttonSampleParams.UseVisualStyleBackColor = true;
            this.buttonSampleParams.Click += new System.EventHandler(this.buttonSampleParams_Click);
            // 
            // checkBoxAddSampleParamsToFile
            // 
            this.checkBoxAddSampleParamsToFile = new System.Windows.Forms.CheckBox();
            this.checkBoxAddSampleParamsToFile.AutoSize = true;
            this.checkBoxAddSampleParamsToFile.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAddSampleParamsToFile.Location = new Point(10, 85);
            this.checkBoxAddSampleParamsToFile.Name = "checkBoxAddSampleParamsToFile";
            this.checkBoxAddSampleParamsToFile.Size = new Size(170, 17);
            this.checkBoxAddSampleParamsToFile.TabIndex = 3;
            this.checkBoxAddSampleParamsToFile.Text = "Add Sample Parameters to File";
            this.checkBoxAddSampleParamsToFile.UseVisualStyleBackColor = true;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.buttonSaveData.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveData.Location = new Point(8, 109);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new Size(106, 23);
            this.buttonSaveData.TabIndex = 4;
            this.buttonSaveData.Text = "Save Data";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new EventHandler(this.buttonSaveData_Click);
            // 
            // BkColorButton
            // 
            this.BkColorButton = new System.Windows.Forms.Button();
            this.BkColorButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.BkColorButton.Location = new Point(8, 138);
            this.BkColorButton.Name = "BkColorButton";
            this.BkColorButton.Size = new Size(106, 23);
            this.BkColorButton.TabIndex = 4;
            this.BkColorButton.Text = "Background Color";
            this.BkColorButton.UseVisualStyleBackColor = true;
            this.BkColorButton.Click += new EventHandler(this.BkColorButton_Click);
            // 
            // FgColorButton
            // 
            this.FgColorButton = new System.Windows.Forms.Button();
            this.FgColorButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.FgColorButton.Location = new Point(8, 167);
            this.FgColorButton.Name = "FgColorButton";
            this.FgColorButton.Size = new Size(106, 23);
            this.FgColorButton.TabIndex = 5;
            this.FgColorButton.Text = "Foreground Color";
            this.FgColorButton.UseVisualStyleBackColor = true;
            this.FgColorButton.Click += new EventHandler(this.FgColorButton_Click);
            //
            // Controls groupBox
            //
            this.groupBoxCtrls = new GroupBoxMOD();
            this.GroupBoxArray[i++] = this.groupBoxCtrls;
            this.groupBoxCtrls.Controls.Add(this.buttonKeyBindings);
            this.groupBoxCtrls.Controls.Add(this.buttonSampleParams);
            this.groupBoxCtrls.Controls.Add(this.checkBoxAddSampleParamsToFile);
            this.groupBoxCtrls.Controls.Add(this.buttonSaveData);
            this.groupBoxCtrls.Controls.Add(this.FgColorButton);
            this.groupBoxCtrls.Controls.Add(this.BkColorButton);
            this.groupBoxCtrls.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCtrls.Location = new Point(8, 359);
            this.groupBoxCtrls.Name = "groupBoxCtrls";
            this.groupBoxCtrls.Size = new Size(182, 204);
            this.groupBoxCtrls.TabIndex = 0;
            this.groupBoxCtrls.TabStop = false;
            this.groupBoxCtrls.Text = "Controls";
            this.Controls.Add(this.groupBoxCtrls);

            // 
            // labelGroup1
            // 
            this.labelGroup1 = new System.Windows.Forms.Label();
            this.labelGroup1.AutoSize = true;
            this.labelGroup1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup1.Location = new Point(6, 31);
            this.labelGroup1.Name = "labelGroup1";
            this.labelGroup1.Size = new Size(65, 13);
            this.labelGroup1.TabIndex = 0;
            this.labelGroup1.Text = "Group 1 Count:";
            // 
            // textBoxGroup1
            // 
            this.textBoxGroup1 = new System.Windows.Forms.TextBox();
            this.textBoxGroup1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroup1.Location = new Point(99, 28);
            this.textBoxGroup1.Name = "textBoxGroup1";
            this.textBoxGroup1.Size = new Size(70, 20);
            this.textBoxGroup1.TabIndex = 6;
            this.textBoxGroup1.Text = "0";
            this.textBoxGroup1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelGroup2
            // 
            this.labelGroup2 = new System.Windows.Forms.Label();
            this.labelGroup2.AutoSize = true;
            this.labelGroup2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup2.Location = new Point(6, 57);
            this.labelGroup2.Name = "labelGroup2";
            this.labelGroup2.Size = new Size(90, 13);
            this.labelGroup2.TabIndex = 0;
            this.labelGroup2.Text = "Group 2 Count:";
            // 
            // textBoxGroup2
            // 
            this.textBoxGroup2 = new System.Windows.Forms.TextBox();
            this.textBoxGroup2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroup2.Location = new Point(99, 54);
            this.textBoxGroup2.Name = "textBoxGroup2";
            this.textBoxGroup2.Size = new Size(70, 20);
            this.textBoxGroup2.TabIndex = 6;
            this.textBoxGroup2.Text = "0";
            this.textBoxGroup2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelGroup3
            // 
            this.labelGroup3 = new System.Windows.Forms.Label();
            this.labelGroup3.AutoSize = true;
            this.labelGroup3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup3.Location = new Point(6, 83);
            this.labelGroup3.Name = "labelGroup3";
            this.labelGroup3.Size = new Size(65, 13);
            this.labelGroup3.TabIndex = 0;
            this.labelGroup3.Text = "Group 3 Count:";
            // 
            // textBoxGroup3
            // 
            this.textBoxGroup3 = new System.Windows.Forms.TextBox();
            this.textBoxGroup3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroup3.Location = new Point(99, 80);
            this.textBoxGroup3.Name = "textBoxGroup3";
            this.textBoxGroup3.Size = new Size(70, 20);
            this.textBoxGroup3.TabIndex = 6;
            this.textBoxGroup3.Text = "0";
            this.textBoxGroup3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelGroup4
            // 
            this.labelGroup4 = new System.Windows.Forms.Label();
            this.labelGroup4.AutoSize = true;
            this.labelGroup4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.labelGroup4.Location = new Point(6, 109);
            this.labelGroup4.Name = "labelGroup4";
            this.labelGroup4.Size = new Size(65, 13);
            this.labelGroup4.TabIndex = 0;
            this.labelGroup4.Text = "Group 4 Count:";
            // 
            // textBoxGroup4
            // 
            this.textBoxGroup4 = new System.Windows.Forms.TextBox();
            this.textBoxGroup4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGroup4.Location = new Point(99, 106);
            this.textBoxGroup4.Name = "textBoxGroup4";
            this.textBoxGroup4.Size = new Size(70, 20);
            this.textBoxGroup4.TabIndex = 6;
            this.textBoxGroup4.Text = "0";
            this.textBoxGroup4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotal
            // 
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new Point(6, 135);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new Size(65, 13);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total Count:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxTotal.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new Point(99, 132);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new Size(70, 20);
            this.textBoxTotal.TabIndex = 6;
            this.textBoxTotal.Text = "0";
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelLastKey
            // 
            this.labelLastKey = new System.Windows.Forms.Label();
            this.labelLastKey.AutoSize = true;
            this.labelLastKey.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.labelLastKey.Location = new Point(6, 161);
            this.labelLastKey.Name = "labelLastKey";
            this.labelLastKey.Size = new Size(90, 13);
            this.labelLastKey.TabIndex = 63;
            this.labelLastKey.Text = "Last key pressed:";
            // 
            // textBoxLastKey
            // 
            this.textBoxLastKey = new System.Windows.Forms.TextBox();
            this.textBoxLastKey.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastKey.Location = new Point(99, 158);
            this.textBoxLastKey.Name = "textBoxLastKey";
            this.textBoxLastKey.Size = new Size(70, 20);
            this.textBoxLastKey.TabIndex = 62;
            this.textBoxLastKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // Statistics groupBox
            //
            this.groupBoxStatistics = new GroupBoxMOD();
            this.GroupBoxArray[i++] = groupBoxStatistics;
            this.groupBoxStatistics.Controls.Add(this.labelGroup1);
            this.groupBoxStatistics.Controls.Add(this.textBoxGroup1);
            this.groupBoxStatistics.Controls.Add(this.labelGroup2);
            this.groupBoxStatistics.Controls.Add(this.textBoxGroup2);
            this.groupBoxStatistics.Controls.Add(this.labelGroup3);
            this.groupBoxStatistics.Controls.Add(this.textBoxGroup3);
            this.groupBoxStatistics.Controls.Add(this.labelGroup4);
            this.groupBoxStatistics.Controls.Add(this.textBoxGroup4);
            this.groupBoxStatistics.Controls.Add(this.labelTotal);
            this.groupBoxStatistics.Controls.Add(this.textBoxTotal);
            this.groupBoxStatistics.Controls.Add(this.labelLastKey);
            this.groupBoxStatistics.Controls.Add(this.textBoxLastKey);
            this.groupBoxStatistics.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            // Ctrls groupbox position + size + offset = 226
            this.groupBoxStatistics.Location = new Point(groupBoxCtrls.Location.X + groupBoxCtrls.Size.Width + 7, 359);
            this.groupBoxStatistics.Name = "groupBoxStats";
            this.groupBoxStatistics.Size = new Size(175, 204);
            this.groupBoxStatistics.TabIndex = 0;
            this.groupBoxStatistics.TabStop = false;
            this.groupBoxStatistics.Text = "Statistics";
            this.Controls.Add(this.groupBoxStatistics);

            // 
            // historyListBox
            // 
            this.historyListBox.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.historyListBox.Location = new Point(8, 25);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new Size(140, 180);
            this.historyListBox.TabIndex = 62;
            this.historyListBox.ScrollAlwaysVisible = true;
            //
            // History groupBox
            //
            this.groupBoxHistory = new GroupBoxMOD();
            this.GroupBoxArray[i++] = groupBoxHistory;
            this.groupBoxHistory.Controls.Add(this.historyListBox);
            this.groupBoxHistory.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            //                                              Stats groupbox position +                size           + offset
            this.groupBoxHistory.Location = new Point(groupBoxStatistics.Location.X + groupBoxStatistics.Size.Width + 7, 359);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new Size(157, 204);
            this.groupBoxHistory.TabIndex = 0;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "Key press history";
            this.Controls.Add(this.groupBoxHistory);
        }

        private void generateToolStripMenu()
        {
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCountToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCountToolStripMenuItem
            // 
            this.newCountToolStripMenuItem.Name = "newCountToolStripMenuItem";
            this.newCountToolStripMenuItem.Size = new Size(134, 22);
            this.newCountToolStripMenuItem.Text = "New Count";
            this.newCountToolStripMenuItem.Click += new System.EventHandler(this.newCountToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new Size(131, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new Size(134, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new Size(131, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new Size(134, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindTaxonToKeysToolStripMenuItem,
            this.sampleParametersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // bindTaxonToKeysToolStripMenuItem
            // 
            this.bindTaxonToKeysToolStripMenuItem.Name = "bindTaxonToKeysToolStripMenuItem";
            this.bindTaxonToKeysToolStripMenuItem.Size = new Size(177, 22);
            this.bindTaxonToKeysToolStripMenuItem.Text = "Assign Taxa to Keys";
            this.bindTaxonToKeysToolStripMenuItem.Click += new System.EventHandler(this.bindTaxonToKeysToolStripMenuItem_Click);
            // 
            // sampleParametersToolStripMenuItem
            // 
            this.sampleParametersToolStripMenuItem.Name = "sampleParametersToolStripMenuItem";
            this.sampleParametersToolStripMenuItem.Size = new Size(177, 22);
            this.sampleParametersToolStripMenuItem.Text = "Sample Parameters";
            this.sampleParametersToolStripMenuItem.Click += new System.EventHandler(this.sampleParametersToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllCountersToZeroToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // resetAllCountersToZeroToolStripMenuItem
            // 
            this.resetAllCountersToZeroToolStripMenuItem.Name = "resetAllCountersToZeroToolStripMenuItem";
            this.resetAllCountersToZeroToolStripMenuItem.Size = new Size(205, 22);
            this.resetAllCountersToZeroToolStripMenuItem.Text = "Reset all counters to zero";
            this.resetAllCountersToZeroToolStripMenuItem.Click += new System.EventHandler(this.resetAllCountersToZeroToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(1316, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";

            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
        }
 

        private int findIndex(List<String> theList, String textToFind)
        {
            int i = 0;

            foreach (String str in theList)
            {
                if (String.Compare(textToFind, str) == 0)
                {
                    return i;
                }
                i++;
            }

            return -1;
        } // findIndex

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotal(); // recalculate total
        } // numericUpDown_ValueChanged

        private void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            int index = findIndex(keyList, cb.Text);
            if (index < 0) return;
            
            numericUD_kb[index].Value += 1;  // increments by 1
            checkBox_kb[index].Checked = false;  // resets the value to not pressed
            textBoxLastKey.Text = keyList[index];    // remember last key pressed
            historyListBox.Items.Insert(0, keyList[index]);   // add to history

        } // checkBox_Click

        private void button_Click(object sender, EventArgs e)
        {
            Button bb = sender as Button;
            Int32.TryParse(bb.Name, out int i);

            AssignedValue = groupBox_kb[i].Text;  // the specific Key you wish to bind to a taxon
            Form3 frm = new Form3(AssignedValue, textBox_kb[i]);   // key is sent as a parameter
            frm.comboBox1.DataSource = new BindingSource(bs, "");
            frm.Show(this);     // the "this" is a pointer to the owner

        } // button_Click

        private void Form1_Load(object sender, EventArgs e)
        {
            // KeyPreview set to true is needed for keyboard events
            this.KeyPreview = true;

            // set icon to a pretty algae
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));

            /*
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text|*.txt";
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(sfd.FileName);
                MessageBox.Show(Path.GetFullPath(sfd.FileName));
                MessageBox.Show(Path.GetFileName(sfd.FileName));
            }
            */
            //MessageBox.Show(System.Windows.Forms.Application.StartupPath.ToString());
            //MessageBox.Show(System.IO.Path.GetDirectoryName(Application.ExecutablePath).ToString());

        } // Form1_Load

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // when pressing a key, handle it with the following code:
            int index = 0;

            switch (e.KeyCode)
            {
                case Keys.D1:      index =  1; break;
                case Keys.D2:      index =  2; break;
                case Keys.D3:      index =  3; break;
                case Keys.D4:      index =  4; break;
                case Keys.D5:      index =  5; break;
                case Keys.D6:      index =  6; break;
                case Keys.D7:      index =  7; break;
                case Keys.D8:      index =  8; break;
                case Keys.D9:      index =  9; break;
                case Keys.D0:      index = 10; break;
                case Keys.Q:       index = 11; break;
                case Keys.W:       index = 12; break;
                case Keys.E:       index = 13; break;
                case Keys.R:       index = 14; break;
                case Keys.T:       index = 15; break;
                case Keys.Y:       index = 16; break;
                case Keys.U:       index = 17; break;
                case Keys.I:       index = 18; break;
                case Keys.O:       index = 19; break;
                case Keys.P:       index = 20; break;
                case Keys.A:       index = 21; break;
                case Keys.S:       index = 22; break;
                case Keys.D:       index = 23; break;
                case Keys.F:       index = 24; break;
                case Keys.G:       index = 25; break;
                case Keys.H:       index = 26; break;
                case Keys.J:       index = 27; break;
                case Keys.K:       index = 28; break;
                case Keys.L:       index = 29; break;
                case Keys.Z:       index = 30; break;
                case Keys.X:       index = 31; break;
                case Keys.C:       index = 32; break;
                case Keys.V:       index = 33; break;
                case Keys.B:       index = 34; break;
                case Keys.N:       index = 35; break;
                case Keys.M:       index = 36; break;
                case Keys.NumPad7: index = 37; break;
                case Keys.NumPad8: index = 38; break;
                case Keys.NumPad9: index = 39; break;
                case Keys.NumPad4: index = 40; break;
                case Keys.NumPad5: index = 41; break;
                case Keys.NumPad6: index = 42; break;
                case Keys.NumPad1: index = 43; break;
                case Keys.NumPad2: index = 44; break;
                case Keys.NumPad3: index = 45; break;
                case Keys.NumPad0: index = 46; break;

                default:  /* do nothing */  break;
            }

            if (index > 0 && index <= numberOfKeys)
            {
                checkBoxArray[index].Checked = true;    // mark the corresponding checkbox as checked
            }

            e.Handled = false;
        } // Form1_KeyDown

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // when releasing a key, handle it with the following code:
            int index = 0;

            switch (e.KeyCode)
            {
                case Keys.D1:      index =  1; break;
                case Keys.D2:      index =  2; break;
                case Keys.D3:      index =  3; break;
                case Keys.D4:      index =  4; break;
                case Keys.D5:      index =  5; break;
                case Keys.D6:      index =  6; break;
                case Keys.D7:      index =  7; break;
                case Keys.D8:      index =  8; break;
                case Keys.D9:      index =  9; break;
                case Keys.D0:      index = 10; break;
                case Keys.Q:       index = 11; break;
                case Keys.W:       index = 12; break;
                case Keys.E:       index = 13; break;
                case Keys.R:       index = 14; break;
                case Keys.T:       index = 15; break;
                case Keys.Y:       index = 16; break;
                case Keys.U:       index = 17; break;
                case Keys.I:       index = 18; break;
                case Keys.O:       index = 19; break;
                case Keys.P:       index = 20; break;
                case Keys.A:       index = 21; break;
                case Keys.S:       index = 22; break;
                case Keys.D:       index = 23; break;
                case Keys.F:       index = 24; break;
                case Keys.G:       index = 25; break;
                case Keys.H:       index = 26; break;
                case Keys.J:       index = 27; break;
                case Keys.K:       index = 28; break;
                case Keys.L:       index = 29; break;
                case Keys.Z:       index = 30; break;
                case Keys.X:       index = 31; break;
                case Keys.C:       index = 32; break;
                case Keys.V:       index = 33; break;
                case Keys.B:       index = 34; break;
                case Keys.N:       index = 35; break;
                case Keys.M:       index = 36; break;
                case Keys.NumPad7: index = 37; break;
                case Keys.NumPad8: index = 38; break;
                case Keys.NumPad9: index = 39; break;
                case Keys.NumPad4: index = 40; break;
                case Keys.NumPad5: index = 41; break;
                case Keys.NumPad6: index = 42; break;
                case Keys.NumPad1: index = 43; break;
                case Keys.NumPad2: index = 44; break;
                case Keys.NumPad3: index = 45; break;
                case Keys.NumPad0: index = 46; break;

                default:  /* do nothing */  break;
            }

            if (index > 0 && index <= numberOfKeys)
            {
                if (numericUpDownArray[index].Value + 1 > numericUpDownArray[index].Maximum)
                {  // prevent exception                    
                    MessageBox.Show("You have reached the maximum value for key " + keyList[index]);
                    numericUpDownArray[index].Value--;
                }

                numericUpDownArray[index].Value += 1;               // increment count
                checkBoxArray[index].Checked = false;               // clear the corresponding checkbox
                textBoxLastKey.Text = keyList[index];    // remember last key pressed
                historyListBox.Items.Insert(0, keyList[index]);   // add to history
            }

            e.Handled = false;
        } // Form1_KeyUp

        private void CalculateTotal()
        {
            decimal sum = 0;
            int i;
            for (i = 1; i <= numberOfKeys; i++)
            {
                sum += numericUD_kb[i].Value;
            }

            textBoxTotal.Text = sum.ToString();    // write calculated value in textbox
        } // CalculateTotal

        public void setString(TextBox tb, String s)
        {   // this is used to set the value of a string to a specific textbox
            tb.Text = s;
        } // setString

        public void setBSource(BindingSource BS)
        {
            bs.DataSource = BS;
        } // setBSource

        private void buttonKeyBindings_Click(object sender, EventArgs e)
        {   // launch the form that handles all the key bindings
            Form2 frm = new Form2();

            int i;
            for (i = 1; i <= numberOfKeys; i++)
            {
                frm.comboBoxArray[i].DataSource = new BindingSource(bs, "");
            }

            frm.Show(this);
        } // buttonKeyBindings_Click

        private void buttonSampleParams_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();

            frm.Show(this);
        } // buttonSampleParams_Click
        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            // Prompt user to save his data
            {
                var confirmResult = MessageBox.Show("Are you sure you want to exit?",
                                    "Confirm Exit",
                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    //let it exit
                }
                else
                {
                    e.Cancel = true;
                }
            }

            if (e.CloseReason == CloseReason.WindowsShutDown)
            // Autosave and clear up ressources
            {
                performSaveToFile(
                                  System.Windows.Forms.Application.StartupPath.ToString() +
                                  "backup_" + DateTime.Now.ToString("yyyyMMdd_HH-mm-ss") + ".txt"
                                 );
            }
        } // Form1_FormClosing

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {   // File -> Exit
            var confirmResult = MessageBox.Show("Are you sure you want to exit?",
                                    "Confirm Exit",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Nothing to do
            }
        } // toolStripMenuItem1_Click


        private void bindTaxonToKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonKeyBindings.PerformClick();
        } // bindTaxonToKeysToolStripMenuItem_Click

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.RestoreDirectory = (false);
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "*.txt";
            saveFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                performSaveToFile(saveFileDialog1.FileName);
            }
        } // buttonSaveData_Click

        private void performSaveToFile(String path_filename)
        {
            // add every textbox and count value to a list
            List<String> exportList = new List<String>();
            exportList.Clear();
            if (checkBoxAddSampleParamsToFile.Checked)
            {
                exportList.Add("==================================================");
                exportList.AddRange(parametersList);
                exportList.Add("==================================================");
                exportList.Add("");
            }

            for (int i = 1; i <= numberOfKeys; i++)
            {
                if (numericUD_kb[i].Value != 0) exportList.Add(textBox_kb[i].Text + "\t" + numericUD_kb[i].Value);
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path_filename))
            {
                foreach (string line in exportList)
                {
                    file.WriteLine(line);
                }
            }
        } // performSaveToFile
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           buttonSaveData.PerformClick();
        } // saveAsToolStripMenuItem_Click

        private void sampleParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
           buttonSampleParams.PerformClick();
        } // sampleParametersToolStripMenuItem_Click

        private void resetAllCountersToZeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to clear all the counters?",
                                     "Confirm Reset",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                for (int i = 1; i <= numberOfKeys; i++)
                {
                    numericUD_kb[i].Value = 0;
                }

                CalculateTotal(); // recalculate total
            }
            else
            {
                // Nothing to do
            }
        } // resetAllCountersToZeroToolStripMenuItem_Click

        private void newCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to start a new count?\nYour current data will be lost!",
                                     "Confirm New Count",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                for (int i = 1; i <= numberOfKeys; i++)
                {
                    textBox_kb[i].Text = "";
                    numericUD_kb[i].Value = 0;
                }

                CalculateTotal(); // recalculate total
            }
            else
            {
                // Nothing to do
            }
        } // newCountToolStripMenuItem_Click
        private void FgColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            Color tempcolor = buttonSaveData.ForeColor; // get currently used color from any button
            if (cd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 1; i <= groupBoxCount; i++)
                {
                    GroupBoxArray[i].BorderColor = cd.Color;
                    GroupBoxArray[i].ForeColor = cd.Color;
                    if (i < checkBoxCount) checkBoxArray[i].ForeColor = tempcolor;
                    if (i < selectTaxonButtonCount) selectTaxonArray[i].ForeColor = tempcolor;
                }

                checkBoxAddSampleParamsToFile.ForeColor = cd.Color;
                buttonKeyBindings.ForeColor = tempcolor;
                buttonSampleParams.ForeColor = tempcolor;
                buttonSaveData.ForeColor = tempcolor;
                BkColorButton.ForeColor = tempcolor;
                FgColorButton.ForeColor = tempcolor;

                GroupBoxMOD.RedrawGroupBoxDisplay(this);
            }
        } // FgColorButton_Click

        private void BkColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = cd.Color;
            }
        } // ColorButton_Click

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.Show(this);
        } // aboutToolStripMenuItem_Click


        /// <summary>
        /// Modified GroupBox with editable border colour
        /// </summary>
        class GroupBoxMOD : GroupBox
        {
            private Color borderColor;
            private Color borderColorLight;
            private Int32 borderRadius;

            /// <summary>Colour of the border</summary>
            public Color BorderColor
            {
                get { return this.borderColor; }
                set { this.borderColor = value; }
            }

            /// <summary>Colour of second border for decoration purposes.</summary>
            public Color BorderColorLight
            {
                get { return borderColorLight; }
                set { borderColorLight = value; }
            }

            public Int32 BorderRadius
            {
                get { return borderRadius; }
                set { borderRadius = value; }
            }
            

            public GroupBoxMOD()
            {
                // default colours
                this.borderColor = SystemColors.ControlDarkDark;
                this.borderColorLight = SystemColors.ControlLightLight;
                this.borderRadius = 3;

                this.DoubleBuffered = true; // prevent flickering
                this.ResizeRedraw = true;   // prevent pixel errors when window moves/resizes
            } // GroupBoxMOD


            protected override void OnPaint(PaintEventArgs e)
            {
                // don't modify if visual styles are disabled   (in this case the default border has a good visibility)
                if (Application.RenderWithVisualStyles == false)
                {
                    base.OnPaint(e);
                    return;
                }

                Size textSize = TextRenderer.MeasureText(this.Text, this.Font);

                // dark border (main)
                Rectangle borderRect = new Rectangle(
                    0,
                    textSize.Height / 2 - 1,
                    this.ClientRectangle.Width - 1,
                    this.ClientRectangle.Height - (textSize.Height / 2) - 1
                    );

                // light border (decoration)
                Rectangle borderRect2 = new Rectangle(
                    1,
                    borderRect.Y + 1,
                    borderRect.Width - 2,
                    borderRect.Height
                    );

                // create path
                GraphicsPath gPathDark = CreatePath(borderRect, borderRadius);
                GraphicsPath gPathLight = CreatePath(borderRect2, borderRadius-1);

                // draw border
                e.Graphics.FillPath(new SolidBrush(this.BackColor), gPathDark);  // background
                e.Graphics.DrawPath(new Pen(this.borderColorLight), gPathLight); // light line
                e.Graphics.DrawPath(new Pen(this.borderColor), gPathDark);       // dark line


                // draw text
                RectangleF textRect = e.ClipRectangle;
                textRect.X += 6;
                textRect.Width = textSize.Width;
                textRect.Width += 5;  // be shure to draw the last letter
                textRect.Height = textSize.Height;
                e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);

                // NOTE:
                // To avoid flickering and pixel errors
                // enable the flags "this.DoubleBuffered" and "this.ResizeRedraw" in the constructor of this class.

            } // OnPaint()
            

            /// <summary>
            /// Create "box" with round corners
            /// </summary>
            private GraphicsPath CreatePath(Rectangle borderRectangle, Int32 radius)
            {
                return CreatePath(borderRectangle.X, borderRectangle.Y, borderRectangle.Width, borderRectangle.Height, radius);
            } // CreatePath


            /// <summary>
            /// Create "box" with round corners
            /// </summary>
            private GraphicsPath CreatePath(Int32 x, Int32 y, Int32 width, Int32 height, Int32 radius)
            {
                // originally published by:  deep.ashar
                // source:  http://social.msdn.microsoft.com/forums/en-US/winforms/thread/cfd34dd1-b6e5-4b56-9901-0dc3d2ca5788
                // modified by Beauty

                Boolean RoundTopLeft = true;
                Boolean RoundTopRight = true;
                Boolean RoundBottomRight = true;
                Boolean RoundBottomLeft = true;

                Int32 xw = x + width;
                Int32 yh = y + height;
                Int32 xwr = xw - radius;
                Int32 yhr = yh - radius;
                Int32 xr = x + radius;
                Int32 yr = y + radius;
                Int32 r2 = radius * 2;
                Int32 xwr2 = xw - r2;
                Int32 yhr2 = yh - r2;

                GraphicsPath p = new GraphicsPath();
                p.StartFigure();

                //Top Left Corner

                if (RoundTopLeft)
                {
                    p.AddArc(x, y, r2, r2, 180, 90);
                }
                else
                {
                    p.AddLine(x, yr, x, y);
                    p.AddLine(x, y, xr, y);

                }

                //Top Edge
                p.AddLine(xr, y, xwr, y);

                //Top Right Corner

                if (RoundTopRight)
                {
                    p.AddArc(xwr2, y, r2, r2, 270, 90);
                }
                else
                {
                    p.AddLine(xwr, y, xw, y);
                    p.AddLine(xw, y, xw, yr);
                }


                //Right Edge
                p.AddLine(xw, yr, xw, yhr);

                //Bottom Right Corner

                if (RoundBottomRight)
                {
                    p.AddArc(xwr2, yhr2, r2, r2, 0, 90);
                }
                else
                {
                    p.AddLine(xw, yhr, xw, yh);
                    p.AddLine(xw, yh, xwr, yh);
                }


                //Bottom Edge
                p.AddLine(xwr, yh, xr, yh);

                //Bottom Left Corner           

                if (RoundBottomLeft)
                {
                    p.AddArc(x, yhr2, r2, r2, 90, 90);
                }
                else
                {
                    p.AddLine(xr, yh, x, yh);
                    p.AddLine(x, yh, x, yhr);
                }

                //Left Edge
                p.AddLine(x, yhr, x, yr);

                p.CloseFigure();
                return p;

            } // CreatePath()
            

            /// <summary>
            /// Manual refresh of modified GroupBox controls (to avoid pixel faults). <br/>
            /// This should be called when main window was activated, moved or resized. <br/>
            /// For this create callback method by the events Form.Activated, Form.Resize and Form.Move 
            /// which calls this method.
            /// If you have more than 1 panel (or other controls), which contains the GroupBoxMOD,
            /// then call this method for each panel. 
            /// </summary>
            /// <param name="controlWithGroupboxes">Control, which contains GroupBoxMOD controls</param>
            public static void RedrawGroupBoxDisplay(Control controlWithGroupboxes)
            {
                foreach (Control control in controlWithGroupboxes.Controls)
                    if (control.GetType() == typeof(GroupBoxMOD))
                        ((GroupBoxMOD)control).Invalidate();
            } // RedrawGroupBoxDisplay


        } // GroupBoxMOD class
    } // Form1 class
} // namespace
