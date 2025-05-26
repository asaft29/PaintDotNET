using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintTools
{
    public class EraserTool : PencilTool
    {
        /// <summary>
        /// Class for eraser tool
        /// </summary>
        /// <param name="penSize">Eraser size</param>
        public EraserTool(int penSize) : base(Color.White, penSize)
        {
        }
    }
}
