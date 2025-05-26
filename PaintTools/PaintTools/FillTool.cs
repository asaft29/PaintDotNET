using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTools
{
    /// <summary>
    /// Class for filling tool
    /// </summary>
    public class FillTool : IDrawingTool
    {
        private Color _targetColor;
        private Color _replacementColor;
        private Bitmap _bitmap;

        public Color Color
        {
            get { return _replacementColor; }
            set { _replacementColor = value; }
        }

        public int PenSize
        {
            get { return 0; }
            set { }
        }
        /// <summary>
        /// Constructor for filling tool
        /// </summary>
        /// <param name="color">Filling color</param>
        public FillTool(Color color)
        {
            _replacementColor = color;
        }

        /// <summary>
        /// Method that sets the space to be filled
        /// </summary>
        /// <param name="bitmap"></param>
        public void SetTargetBitmap(Bitmap bitmap)
        {
            _bitmap = bitmap;
        }

        public void OnMouseDown(Point location)
        {
            if (_bitmap == null) return;

            _targetColor = _bitmap.GetPixel(location.X, location.Y);
            if (_targetColor.ToArgb() == _replacementColor.ToArgb()) return;

            FloodFill(location.X, location.Y);
        }

        public void OnMouseMove(Point location) { }
        public void OnMouseUp(Point location) { }
        public void Draw(Graphics graphics) { }

        /// <summary>
        /// Method that fills the space with the new color
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        private void FloodFill(int x, int y)
        {
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point p = pixels.Pop();
                if (p.X < 0 || p.X >= _bitmap.Width || p.Y < 0 || p.Y >= _bitmap.Height)
                    continue;

                if (_bitmap.GetPixel(p.X, p.Y) == _targetColor)
                {
                    _bitmap.SetPixel(p.X, p.Y, _replacementColor);
                    pixels.Push(new Point(p.X - 1, p.Y));
                    pixels.Push(new Point(p.X + 1, p.Y));
                    pixels.Push(new Point(p.X, p.Y - 1));
                    pixels.Push(new Point(p.X, p.Y + 1));
                }
            }
        }
    }
}
