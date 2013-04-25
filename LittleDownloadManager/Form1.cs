using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LittleDownloadManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }
    }
}


namespace System.Windows.Forms
{
    public class SplitContainerEx : SplitContainer
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            /*
            int dotWidth = 4;
            int dotHeight = 4;
            int dotSpacing = 10;

            Point centerPoint = new Point(SplitterRectangle.Left - 1 + SplitterRectangle.Width / 2, SplitterRectangle.Top - 1 + SplitterRectangle.Height / 2);

            e.Graphics.FillEllipse(SystemBrushes.ControlText, centerPoint.X, centerPoint.Y, dotWidth, dotHeight);
            if (Orientation == System.Windows.Forms.Orientation.Horizontal)
            {
                e.Graphics.FillEllipse(SystemBrushes.ControlText, centerPoint.X - dotSpacing, centerPoint.Y, dotWidth, dotHeight);
                e.Graphics.FillEllipse(SystemBrushes.ControlText, centerPoint.X + dotSpacing, centerPoint.Y, dotWidth, dotHeight);
            }
            else
            {
                e.Graphics.FillEllipse(SystemBrushes.ControlText, centerPoint.X, centerPoint.Y - dotSpacing, dotWidth, dotHeight);
                e.Graphics.FillEllipse(SystemBrushes.ControlText, centerPoint.X, centerPoint.Y + dotSpacing, dotWidth, dotHeight);
            }
            */

            //paint the three dots'
            Point[] points = new Point[3];
            var w = this.Width;
            var h = this.Height;
            var d = this.SplitterDistance;
            var sW = this.SplitterWidth;

            //calculate the position of the points'
            if (this.Orientation == Orientation.Horizontal)
            {
                points[0] = new Point((w / 2), d + (sW / 2));
                points[1] = new Point(points[0].X - 10, points[0].Y);
                points[2] = new Point(points[0].X + 10, points[0].Y);
            }
            else
            {
                points[0] = new Point(d + (sW / 2), (h / 2));
                points[1] = new Point(points[0].X, points[0].Y - 10);
                points[2] = new Point(points[0].X, points[0].Y + 10);
            }

            foreach (Point p in points)
            {
                p.Offset(-2, -2);
                e.Graphics.FillEllipse(SystemBrushes.ControlDark,
                    new Rectangle(p, new Size(3, 3)));

                p.Offset(1, 1);
                e.Graphics.FillEllipse(SystemBrushes.ControlLight,
                    new Rectangle(p, new Size(3, 3)));
            }

        }
    }
}