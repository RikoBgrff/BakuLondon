using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakuLondon
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Label label = new Label();

        public Form1()
        {
            timer.Interval = 500;
            timer.Start();
            InitializeComponent();
            CreateLabel();
        }
    void CreateLabel()
    {
            Image image = Properties.Resources.baku2;
            Image image2 = Properties.Resources.london2;
            label.Size = new Size(image.Width, image.Height);
            label.Image = image2;
            label.Image = image;
            this.Controls.Add(label);
        }

        private void BakuBtn_Click(object sender, EventArgs e)
        {
            this.bakuBtn.BackColor = Color.DeepSkyBlue;
            this.londonBtn.BackColor = Color.Empty;
            Image image = Properties.Resources.baku2;
            label.Image = image;
            Text = $"Baku:{DateTime.Now.ToLongTimeString()}";
        }

        private void londonBtn_Click(object sender, EventArgs e)
        {
            this.bakuBtn.BackColor = Color.Empty;
            this.londonBtn.BackColor = Color.SkyBlue;
            Image image2 = Properties.Resources.london2;
            label.Image = image2;
            Text = $"London:{DateTime.Now.ToLongTimeString()}";
            label.Image = image2;
        }
    }
}
