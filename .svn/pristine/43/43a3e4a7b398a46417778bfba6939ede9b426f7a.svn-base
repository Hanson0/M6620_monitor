using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Production.AllForms
{
    public partial class TraySnConfirm : Form
    {
        private string traySn;

        public string TraySn
        {
            get
            {
                return traySn;
            }

            set
            {
                traySn = value;
            }
        }


        public TraySnConfirm()
        {
            InitializeComponent();
        }



        private void button_exportCasingInfo_Click(object sender, EventArgs e)
        {
            if (txtTraySn.TextLength != 8)
            {
                MessageBox.Show("请输入8位完整箱号");
                return;
            }

            //1XXXXXXX，第一位“1”代表小箱，后面7位代表小箱的数量次序，从0000001开始
            Regex regex = new Regex(@"^[1]{1}\d{7}$");
            if (!regex.IsMatch(txtTraySn.Text))
            {
                MessageBox.Show("请输入正确的箱号");
                return;
            }

            traySn = txtTraySn.Text;

            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
