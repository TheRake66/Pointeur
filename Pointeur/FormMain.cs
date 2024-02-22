using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pointeur
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Rectangle bounds = SystemInformation.VirtualScreen;
            int x = bounds.Left;
            int y = bounds.Top;
            int width = bounds.Width;
            int height = bounds.Height;
            this.Location = new Point(x, y);
            this.Size = new Size(width, height);

            Bitmap cursor = Properties.Resources.curseur;
            IntPtr handle = cursor.GetHicon();
            this.Cursor = new Cursor(handle);
        }

        private void FormMain_Click(object sender, EventArgs e)
        {
            Point current = Cursor.Position;
            int currentX = current.X;
            int currentY = current.Y;
            Clipboard.SetText($"{currentX}, {currentY}");

            Application.Exit();
        }
    }
}
