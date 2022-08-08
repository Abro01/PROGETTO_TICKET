using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace ProgettoRDF.Elementi
{
    class RJButton : Button
    {
        private int size_bordo = 0;
        private int radius_bordo = 40;
        private Color colore_bordo = Color.PaleVioletRed;

        [Category("RJ Code Advance")]
        public int Size_bordo
        {
            get
            {
                return size_bordo;
            }

            set
            {
                size_bordo = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int Radius_bordo
        {
            get
            {
                return radius_bordo;
            }

            set
            {
                radius_bordo = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color Colore_bordo
        {
            get
            {
                return colore_bordo;
            }

            set
            {
                colore_bordo = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width-radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width-radius, rect.Height-radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height-radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if(radius_bordo > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, radius_bordo))
                using (GraphicsPath pathBorder = GetFigurePath(rectSurface, radius_bordo - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(colore_bordo, size_bordo))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    if(size_bordo >=1)
                    {
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }else
            {
                this.Region = new Region(rectSurface);

                if(size_bordo >=1)
                {
                    using(Pen penBorder = new Pen(colore_bordo, size_bordo))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if(this.DesignMode)
            {
                this.Invalidate();
            }
        }
    }
}
