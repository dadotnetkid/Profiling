using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Helpers;

namespace Win.Test.UC
{
    public partial class ucToken : UserControl
    {
        private string _token;

        public void SetText(string txt)
        {
            this.label1.Text = txt;
            this.Size = new Size(getWith(txt), this.Size.Height);
        }
        
        int getWith(string txt)
        {
            Font font = new Font("Segoe UI", 12.0F);
            Image fakeImage = new Bitmap(1, 1); //As we cannot use CreateGraphics() in a class library, so the fake image is used to load the Graphics.
            Graphics graphics = Graphics.FromImage(fakeImage);
            SizeF size = graphics.MeasureString(txt, font);
            return size.Width.ToInt() +50;
        }
        public ucToken()
        {
            InitializeComponent();
        }

        private void ucToken_Load(object sender, EventArgs e)
        {

        }

    }
}
