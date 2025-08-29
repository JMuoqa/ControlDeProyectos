﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;

namespace ControlDeProyectos.ElementosPersonalizados
{
    public class PanelPer : Panel
    {
        private int radioDelPanel  = 40;
        private int tamañoBordePanel = 0;
        Color colorDelPanel = Color.FromArgb(242, 225, 199);
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectSuper = new RectangleF(0,0,this.Width,this.Height);
            RectangleF rectBorde = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
            if(radioDelPanel > 2) // Boton redondo
            {
                using (GraphicsPath pathSuper = GetFigurePath(rectSuper, radioDelPanel))
                using (GraphicsPath pathBorde = GetFigurePath(rectBorde, radioDelPanel - 1f))
                using (Pen penSuper = new Pen(this.Parent.BackColor,2))
                using (Pen penBorde = new Pen(this.Parent.BackColor, tamañoBordePanel))
                {
                    penBorde.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSuper);
                    e.Graphics.DrawPath(penSuper, pathSuper);
                    if(tamañoBordePanel >= 1)
                        e.Graphics.DrawPath(penBorde, pathBorde);
                }
            }
            else // Boton normal
            {
                this.Region = new Region(rectSuper);
                if (tamañoBordePanel >= 1)
                {
                    using (Pen penBorde = new Pen(this.Parent.BackColor, tamañoBordePanel))
                    {
                        penBorde.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorde, 0,0,this.Width-1,this.Height-1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Contenedor_BackColorChanged);
        }

        private void Contenedor_BackColorChanged(object? sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }
    }
}
