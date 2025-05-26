using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaintTools;

namespace UnitTestPaint
{
    [TestClass]
    public class PencilToolTests
    {
        private PictureBox _canvas;
        private Color _testColor = Color.Red;
        private int _testPenSize = 2;

        [TestInitialize]
        public void Init()
        {
            _canvas = new PictureBox();
            _canvas.Image = new Bitmap(100, 100);
        }

        [TestMethod]
        public void PencilTool_Constructor()
        {
            IDrawingTool pencilTool = new PencilTool(_testColor, _testPenSize);

            Assert.AreEqual(_testColor, pencilTool.Color);
            Assert.AreEqual(_testPenSize, pencilTool.PenSize);
        }

        [TestMethod]
        public void OnMouseDown_StartsNewPath()
        {
            var pencilTool = new PencilTool(_testColor, _testPenSize);
            var startPoint = new Point(10, 10);

            pencilTool.OnMouseDown(startPoint);

            var pointsField = typeof(PencilTool).GetField("_points",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var points = (List<Point>)pointsField.GetValue(pencilTool);

            Assert.AreEqual(1, points.Count);
            Assert.AreEqual(startPoint, points[0]);
        }

        [TestMethod]
        public void OnMouseMove_AddsPointsWhileDrawing()
        {
            var pencilTool = new PencilTool(_testColor, _testPenSize);
            var startPoint = new Point(10, 10);
            var movePoint1 = new Point(15, 15);
            var movePoint2 = new Point(20, 20);

            pencilTool.OnMouseDown(startPoint);
            pencilTool.OnMouseMove(movePoint1);
            pencilTool.OnMouseMove(movePoint2);

            var pointsField = typeof(PencilTool).GetField("_points",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var points = (List<Point>)pointsField.GetValue(pencilTool);

            Assert.AreEqual(3, points.Count);
            Assert.AreEqual(movePoint2, points[2]);
        }

        [TestMethod]
        public void OnMouseUp_AddsFinalPoint()
        {
            var pencilTool = new PencilTool(_testColor, _testPenSize);
            var startPoint = new Point(10, 10);
            var endPoint = new Point(30, 30);

            pencilTool.OnMouseDown(startPoint);
            pencilTool.OnMouseMove(new Point(15, 15));
            pencilTool.OnMouseUp(endPoint);

            var pointsField = typeof(PencilTool).GetField("_points",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var points = (List<Point>)pointsField.GetValue(pencilTool);

            Assert.IsTrue(points.Count >= 2);
            Assert.AreEqual(endPoint, points[points.Count - 1]);
        }

        [TestMethod]
        public void Draw_DoesNotCrashWithEmptyPath()
        {
            var pencilTool = new PencilTool(_testColor, _testPenSize);
            var testBitmap = new Bitmap(100, 100);

            using (var graphics = Graphics.FromImage(testBitmap))
            {
                try
                {
                    pencilTool.Draw(graphics);
                    Assert.IsTrue(true, "Nu ar trebui sa dea crash fara path");
                }
                catch (Exception ex)
                {
                    Assert.Fail($"Eroare : {ex.Message}");
                }
            }
        }

        [TestMethod]
        public void Draw_CreatesVisibleLine()
        {
            var pencilTool = new PencilTool(_testColor, _testPenSize);
            var testBitmap = new Bitmap(100, 100);

            pencilTool.OnMouseDown(new Point(10, 10));
            pencilTool.OnMouseMove(new Point(90, 90));
            pencilTool.OnMouseUp(new Point(90, 90));

            using (var graphics = Graphics.FromImage(testBitmap))
            {
                graphics.Clear(Color.White);
                pencilTool.Draw(graphics);
            }

            Assert.AreEqual(_testColor.ToArgb(), testBitmap.GetPixel(50, 50).ToArgb());
        }
    }
}
