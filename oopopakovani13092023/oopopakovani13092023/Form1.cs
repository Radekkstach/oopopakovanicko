using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopopakovani13092023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamestnanec radek = new Zamestnanec("ing", "radek stach", 20000, dateTimePicker1.Value);
            label1.Text = radek.ToString();
        }
    }
}
