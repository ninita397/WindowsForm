using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace Components
{
    public partial class MakeLogarithmSpiral : UserControl
    {
        public MakeLogarithmSpiral()
        {
            InitializeComponent();
        }

        private void picSpiral_Resize(object sender, EventArgs e)
        {
            picSpiral.Refresh();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            picSpiral.Refresh();
        }

        // Pens to use for different spirals.
        private Pen[] SpiralPens =
        {
            Pens.Red, Pens.Green, Pens.Purple,
            Pens.Blue, Pens.Magenta, 
        };

        // Draw the spiral(s).
        private void picSpiral_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(picSpiral.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            try
            {
                txtA.Text.Replace(",", ".");
                float A = float.Parse(txtA.Text, System.Globalization.CultureInfo.InvariantCulture);

                txtB.Text.Replace(",", ".");
                float B = float.Parse(txtB.Text, System.Globalization.CultureInfo.InvariantCulture);
                int num_spirals = int.Parse(txtNumSpirals.Text);

                // Angular spacing between different spirals.
                float d_start = (float)(2 * Math.PI / num_spirals);

                // The angle where the next spiral starts.
                float start_angle = 0;

                // Center point.
                PointF center = new PointF(
                    picSpiral.ClientSize.Width / 2,
                    picSpiral.ClientSize.Height / 2);

                // Draw axes.
                e.Graphics.DrawLine(Pens.Black,
                    center.X, 0,
                    center.X, picSpiral.ClientSize.Height);
                e.Graphics.DrawLine(Pens.Black,
                    0, center.Y,
                    picSpiral.ClientSize.Width, center.Y);

                // Draw the spiral on only part of the PictureBox.
                Rectangle rect = new Rectangle(25, 50, 150, 150);

                // Find the maximum distance to the rectangle's corners.
                float max_r = Distance(center, rect);

                // Draw the spirals.
                for (int i = 0; i < num_spirals; i++)
                {
                    List<PointF> points =
                        GetSpiralPoints(center, A, B, start_angle, max_r);
                    e.Graphics.DrawLines(SpiralPens[i % SpiralPens.Length],
                        points.ToArray());
                    start_angle += d_start;
                }

                // Draw the target rectangle.
                e.Graphics.DrawRectangle(Pens.Black, rect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Return points that define a spiral.
        private List<PointF> GetSpiralPoints(
            PointF center, float A, float B,
            float angle_offset, float max_r)
        {
            // Get the points.
            List<PointF> points = new List<PointF>();
            const float dtheta = (float)(5 * Math.PI / 180);    // Five degrees.
            float min_theta = (float)(Math.Log(0.1 / A) / B);
            for (float theta = min_theta; ; theta += dtheta)
            {
                // Calculate r.
                float r = (float)(A * Math.Exp(B * theta));

                // Convert to Cartesian coordinates.
                float x, y;
                PolarToCartesian(r, theta + angle_offset, out x, out y);

                // Center.
                x += center.X;
                y += center.Y;

                // Create the point.
                points.Add(new PointF((float)x, (float)y));

                // If we have gone far enough, stop.
                if (r > max_r) break;
            }
            return points;
        }

        // Return the distance between two points.
        private float Distance(PointF point1, PointF point2)
        {
            float dx = point1.X - point2.X;
            float dy = point1.Y - point2.Y;
            return (float)Math.Sqrt(dx * dx + dy * dy);
        }

        // Return the distance between the point
        // and the rectangle's farthest corner.
        private float Distance(PointF point, Rectangle rect)
        {
            float max_dist = Distance(point, new PointF(rect.Left, rect.Top));

            float test_dist = Distance(point, new PointF(rect.Left, rect.Bottom));
            if (max_dist < test_dist) max_dist = test_dist;

            test_dist = Distance(point, new PointF(rect.Right, rect.Top));
            if (max_dist < test_dist) max_dist = test_dist;

            test_dist = Distance(point, new PointF(rect.Right, rect.Bottom));
            if (max_dist < test_dist) max_dist = test_dist;

            return max_dist;
        }

        private void PolarToCartesian(float r, float theta, out float x, out float y)
        {
            x = (float)(r * Math.Cos(theta));
            y = (float)(r * Math.Sin(theta));
        }
    }
}
