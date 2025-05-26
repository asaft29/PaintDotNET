using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTools
{
    /// <summary>
    /// Class for drawing rectangles
    /// </summary>
    public class RectangleTool : TwoPointTool
    {
        private bool _fill;

        /// <summary>
        /// Constructor for RectangleTool
        /// </summary>
        /// <param name="color">Drawing color</param>
        /// <param name="penSize">Line width</param>
        /// <param name="fill">Fill or Outline only</param>
        public RectangleTool(Color color, int penSize, bool fill) : base(color, penSize)
        {
            _fill = fill;
        }

        /// <summary>
        /// Method that draws a rectangle between two points
        /// </summary>
        /// <param name="graphics"></param>
        public override void Draw(Graphics graphics)
        {
            var rect = GetRectangle();

            if (_fill)
            {
                using (var brush = new SolidBrush(color))
                {
                    graphics.FillRectangle(brush, rect);
                }
            }
            else
            {
                using (var pen = new Pen(color, penSize))
                {
                    graphics.DrawRectangle(pen, rect);
                }
            }
        }

        /// <summary>
        /// Method that returns a rectangle between two points
        /// </summary>
        /// <returns></returns>
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
