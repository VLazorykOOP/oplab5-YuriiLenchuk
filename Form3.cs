using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab5
{
    public partial class Form3 : Form
    {
        private readonly Random random = new();

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxK.Text, out int K) && K > 0)
            {
                DrawBarnsleyFern(K);
            }
            else
            {
                MessageBox.Show("Please enter a valid positive integer for K.");
            }
        }

        private void DrawBarnsleyFern(int K)
        {
            Bitmap bitmap = new(pictureBoxFern.Width, pictureBoxFern.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.Clear(Color.Black);

            double x = 0.0, y = 0.0;

            Color[] leafColors = new Color[4];
            for (int i = 0; i < 4; i++)
            {
                leafColors[i] = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            }

            for (int i = 0; i < K; i++)
            {
                double nextX, nextY;
                int p = random.Next(100);
                Color leafColor;

                if (p == 0)
                {
                    nextX = 0;
                    nextY = 0.16 * y;
                    leafColor = leafColors[0];
                }
                else if (p < 86)
                {
                    nextX = 0.85 * x + 0.04 * y;
                    nextY = -0.04 * x + 0.85 * y + 1.6;
                    leafColor = leafColors[1];
                }
                else if (p < 93)
                {
                    nextX = 0.2 * x - 0.26 * y;
                    nextY = 0.23 * x + 0.22 * y + 1.6;
                    leafColor = leafColors[2];
                }
                else
                {
                    nextX = -0.15 * x + 0.28 * y;
                    nextY = 0.26 * x + 0.24 * y + 0.44;
                    leafColor = leafColors[3];
                }

                x = nextX;
                y = nextY;

                int plotX = (int)(bitmap.Width / 2 + x * bitmap.Width / 10);
                int plotY = (int)(bitmap.Height - y * bitmap.Height / 12);

                bitmap.SetPixel(plotX, plotY, leafColor);
            }

            pictureBoxFern.Image = bitmap;
        }
    }
}