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
    public partial class Form6 : Form       // Form6 is a setup form for grouping controls associated with certain keys in order to form separately-counted categories.
    {
        public Form6()
        {
            GroupBox groupsel = new GroupBox();
            // form for grouping selection;
            // i think a bunch of checkboxes should do the trick
            // Q [ ] W [ ] E [x] R [ ] ...
            // groups should be able to have names
            // members shouldn't be able to join multiple groups
            InitializeComponent();
        }
    }
}
