using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTools
{
    /// <summary>
    /// Class for drawing pencil tool
    /// </summary>
    public class PencilTool : IDrawingTool
    {

        private List<Point> _points = new List<Point>();
        private Color _color;
        private int _penSize;

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int PenSize
        {
            get { return _penSize; }
            set { _penSize = value; }
        }

        /// <summary>
        /// Constructor for PencilTool
        /// </summary>
        /// <param name="color">Line color</param>
        /// <param name="penSize">Line width</param>
        public PencilTool(Color color, int penSize)
        {
            _color = color;
            _penSize = penSize;
        }

        public void OnMouseDown(Point location)
        {
            _points.Clear();
            _points.Add(location);
        }

        public void OnMouseMove(Point location)
        {
            if (_points.Count > 0)
            {
                _points.Add(location);
            }
        }

        public void OnMouseUp(Point location)
        {
            _points.Add(location);
        }

        /// <summary>
        /// Method for connecting all the points with small lines to create a uniform line
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public void Draw(Graphics graphics)
        {
            if (_points.Count > 1)
            {
                using (var pen = new Pen(_color, _penSize))
                {
                    pen.StartCap = LineCap.Round;
                    pen.EndCap = LineCap.Round;
                    graphics.DrawLines(pen, _points.ToArray());
                }
            }
        }
    }
}
