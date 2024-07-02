using System;
using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Зчитування значень з текстових полів
            float x1 = float.Parse(textBoxX1.Text);
            float y1 = float.Parse(textBoxY1.Text);
            float x2 = float.Parse(textBoxX2.Text);
            float y2 = float.Parse(textBoxY2.Text);
            float vx1 = float.Parse(textBoxVx1.Text);
            float vy1 = float.Parse(textBoxVy1.Text);
            float vx2 = float.Parse(textBoxVx2.Text);
            float vy2 = float.Parse(textBoxVy2.Text);

            // Малювання лінії Ерміта
            DrawHermiteCurve(x1, y1, x2, y2, vx1, vy1, vx2, vy2);
        }

        private void DrawHermiteCurve(float x1, float y1, float x2, float y2, float vx1, float vy1, float vx2, float vy2)
        {
            Bitmap bmp = new(panelGraph.Width, panelGraph.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Pen pen = new(Color.Black);

                for (float t = 0; t <= 1; t += 0.01f)
                {
                    PointF p1 = GetPoint(t, x1, y1, x2, y2, vx1, vy1, vx2, vy2);
                    PointF p2 = GetPoint(t + 0.01f, x1, y1, x2, y2, vx1, vy1, vx2, vy2);
                    g.DrawLine(pen, p1, p2);
                }
            }
            panelGraph.BackgroundImage = bmp;
        }

        private PointF GetPoint(float t, float x1, float y1, float x2, float y2, float vx1, float vy1, float vx2, float vy2)
        {
            float h1 = 2 * t * t * t - 3 * t * t + 1;
            float h2 = -2 * t * t * t + 3 * t * t;
            float h3 = t * t * t - 2 * t * t + t;
            float h4 = t * t * t - t * t;

            float x = h1 * x1 + h2 * x2 + h3 * vx1 + h4 * vx2;
            float y = h1 * y1 + h2 * y2 + h3 * vy1 + h4 * vy2;

            return new PointF(x, y);
        }
    }
}
