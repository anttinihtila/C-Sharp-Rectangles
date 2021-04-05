using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectanglesEx
{
    class Program : Form
    {
        public Program()
        {
            InitUI();
        }

        private void InitUI()
        {
            Text = "Rectangles";
            Paint += new PaintEventHandler(OnPaint);

            ClientSize = new Size(450, 350);
            CenterToScreen();
        }

        void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Violet, 10, 15, 90, 60);
            g.FillRectangle(Brushes.Blue, 130, 15, 90, 60);
            g.FillRectangle(Brushes.LightBlue, 250, 15, 90, 60);
            g.FillRectangle(Brushes.Green, 10, 105, 90, 60);
            g.FillRectangle(Brushes.Yellow, 130, 105, 90, 60);
            g.FillRectangle(Brushes.Orange, 250, 105, 90, 60);
            g.FillRectangle(Brushes.Red, 10, 195, 90, 60);

        }

        [STAThread]
        static void Main()
        {
            // Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.Run(new Program());
        }
    }
}