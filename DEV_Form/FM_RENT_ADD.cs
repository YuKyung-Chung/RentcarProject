﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEV_Form
{
    public partial class FM_RENT_ADD : BaseMDIChildForm
    {
        public FM_RENT_ADD()
        {
            InitializeComponent();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            FM_SearchCar formCar = new FM_SearchCar();
            formCar.ShowDialog();
        }
    }
}
