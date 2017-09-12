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
    public partial class slStorehouse : Form
    {
        private Boolean fals = true;
        public slStorehouse()
        {
            InitializeComponent();
        }
        private void slStorehouse_Load(object sender, EventArgs e)
        {
            this.skinPictureBox1.SetBounds(560,60,48,48);
            this.skinPictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon\\" + "search_48px.ico");
        }

        private void skinPictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.skinPictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon\\" + "moresearch_48px.ico");
        }

        private void skinPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.skinPictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon\\" + "search_48px.ico");
        }

        private void skinPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.skinPictureBox1.SetBounds(568, 68, 32, 32);
            this.skinPictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon\\" + "moresearch_32px.ico");
        }

        private void skinPictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.skinPictureBox1.SetBounds(560, 60, 48, 48);
            this.skinPictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\icon\\" + "moresearch_48px.ico");
        }
    }
}
