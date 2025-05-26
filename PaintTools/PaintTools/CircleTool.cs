using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTools
{
    /// <summary>
    /// Class for drawing a circle/elipse
    /// </summary>
    public class CircleTool : TwoPointTool
    {
        private bool _fill;
        /// <summary>
        /// CircleTool constructor
        /// </summary>
        /// <param name="color">Drawing color</param>
        /// <param name="penSize">Line width</param>
        /// <param name="fill">Fill or Outline only</param>
        public CircleTool(Color color, int penSize, bool fill) : base(color, penSize)
        {
            _fill = fill;
        }

        /// <summary>
        /// Method that draws the circle/elipse inside de rectangle formed using de two selected points
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public override void Draw(Graphics graphics)
        {
            var rect = GetRectangle();

            if (_fill)
            {
                using (var brush = new SolidBrush(color))
                {
                    graphics.FillEllipse(brush, rect);
                }
            }
            else
            {
                using (var pen = new Pen(color, penSize))
                {
                    graphics.DrawEllipse(pen, rect);
                }
            }
        }

        /// <summary>
        /// Method for creating a rectangle between two selected points
        /// </summary>
        /// <returns>Rectangle</returns>
        private Rectangle GetRectangle()
        {
            return new Rectangle(
                Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(endPoint.X - startPoint.X),
                Math.Abs(endPoint.Y - startPoint.Y));
        }
    }
}
