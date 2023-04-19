using oopEventForm.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace oopEventForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            Operations op = new Operations(int.Parse(sayi1txt.Text), int.Parse(sayi2txt.Text));
            if (addradioButton.Checked == true)
            {
                sonuclbl.Text = op.AddOperation().ToString(); 
            }
            else if (substractradioButton.Checked == true)
            {
                sonuclbl.Text = op.SubstractOperation().ToString();
            }
            else
            {
                sonuclbl.Text = "Lütfen işlem seçiniz";
            }
        }
    }
    
    
}
