﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontEditor
{
    public partial class frmNewFont : Form
    {
        public frmNewFont()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Close();
        }

        public String FontName
        {
            get { return txtName.Text; }
        }

        public new ushort FontHeight
        {
            get { return Convert.ToUInt16(numHeight.Value); }
        }
    }
}
