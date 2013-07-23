using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilesImporter
{
    public partial class DelimiterChooseMenu : UserControl
    {
        public DelimiterChooseMenu()
        {
            InitializeComponent();
        }

        private void txbDelimiterOther_TextChanged(object sender, EventArgs e)
        {
            if (txbDelimiterOther.Text.Length == 0)
            {
                chkDelimiterOther.Checked = false;
                return;
            }

            chkDelimiterOther.Checked = !chkDelimiterOther.Checked;
        }
    }
}
