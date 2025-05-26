using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PaintTools
{
    /// <summary>
    /// Drawing tool interface
    /// </summary>
    public interface IDrawingTool
    {
        Color Color { get; set; }
        int PenSize { get; set; }

        void OnMouseDown(Point location);
        void OnMouseMove(Point location);
        void OnMouseUp(Point location);
        void Draw(Graphics graphics);
    }

    /// <summary>
    /// Class responsible for managing all the tool types
    /// </summary>
    public class ToolManager
    {
        private IDrawingTool _currentTool;

        public IDrawingTool CurrentTool
        {
            get { return _currentTool; }
        }
        public void SetTool(IDrawingTool tool)
        {
            _currentTool = tool;
        }

        public void MouseDown(Point location) => _currentTool?.OnMouseDown(location);
        public void MouseMove(Point location) => _currentTool?.OnMouseMove(location);
        public void MouseUp(Point location) => _currentTool?.OnMouseUp(location);

        public void Draw(Graphics graphics) => _currentTool?.Draw(graphics);

        public void ApplyToBitmap(Bitmap bitmap)
        {
            if (_currentTool == null) return;

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                _currentTool.Draw(g);
            }
        }
    }

    /// <summary>
    /// Type of tool that requires 2 points to draw the shape
    /// </summary>
    public abstract class TwoPointTool : IDrawingTool
    {


        protected Point startPoint;
        protected Point endPoint;
        protected bool isDrawing = false;
        protected Color color;
        protected int penSize;

        public virtual Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public virtual int PenSize
        {
            get { return penSize; }
            set { penSize = value; }
        }

        /// <summary>
        /// Constructor for TwoPointTool
        /// </summary>
        /// <param name="color">Drawing color</param>
        /// <param name="penSize">Line width</param>
        public TwoPointTool(Color color, int penSize)
        {
            this.color = color;
            this.penSize = penSize;
        }

        public virtual void OnMouseDown(Point location)
        {
            startPoint = location;
            endPoint = location;
            isDrawing = true;
        }

        public virtual void OnMouseMove(Point location)
        {
            if (isDrawing)
            {
                endPoint = location;
            }
        }

        public virtual void OnMouseUp(Point location)
        {
            endPoint = location;
            isDrawing = false;
        }

        public abstract void Draw(Graphics graphics);
    }
}
