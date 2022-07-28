using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtPlayer.Text = openFileDialog1.FileName;
            }
            Player.URL = txtPlayer.Text;
        }

        private void btnOynat_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void btnDuraklat_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.pause();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.stop();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
