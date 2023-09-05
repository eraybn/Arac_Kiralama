using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmMüşteriEkleme arc = new frmMüşteriEkleme();
            //arc.Show();
            //this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMüsteriListeleme arc = new frmMüsteriListeleme();
            arc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmArackayit arc = new frmArackayit();
            arc.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAracListeleme arc = new frmAracListeleme();
            arc.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMusteriSozlesme arc = new frmMusteriSozlesme();
            arc.Show();
            this.Hide();
        }

  
    }
}
