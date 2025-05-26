using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTools
{
    /// <summary>
    /// Class for line drawing between two points
    /// </summary>
    public class LineTool : TwoPointTool
    {
        /// <summary>
        /// Constructor for LineTool
        /// </summary>
        /// <param name="color">Line color</param>
        /// <param name="penSize">Line width</param>
        public LineTool(Color color, int penSize) : base(color, penSize) { }

        /// <summary>
        /// Method for drawing a line between two points
        /// </summary>
        /// <param name="graphics">Drawing surface</param>
        public override void Draw(Graphics graphics)
        {
            if (startPoint != endPoint)
            {
                using (var pen = new Pen(color, penSize))
                {
                    graphics.DrawLine(pen, startPoint, endPoint);
                }
            }
        }
    }
}
