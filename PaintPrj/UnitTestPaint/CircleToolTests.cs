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
    public class CircleTests
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
        public void CircleTool_Constructor()
        {
            IDrawingTool circleTool = new CircleTool(_testColor, _testPenSize, true);

            Assert.AreEqual(_testColor, circleTool.Color);
            Assert.AreEqual(_testPenSize, circleTool.PenSize);
        }
        [TestMethod]
        public void Draw_TransparentFill_DoesNotCorruptImage()
        {
            var color = Color.FromArgb(128, 255, 0, 0); 
            var circleTool = new CircleTool(color, penSize: 1, fill: true);
            var testBitmap = new Bitmap(100, 100);

            using (var graphics = Graphics.FromImage(testBitmap))
            {
                graphics.Clear(Color.White);

                circleTool.OnMouseDown(new Point(20, 20));
                circleTool.OnMouseMove(new Point(60, 60));

                circleTool.Draw(graphics);
            }

            Color centerPixel = testBitmap.GetPixel(40, 40);
            Assert.IsTrue(centerPixel.R > 200);
            Assert.IsTrue(centerPixel.A == 255);
        }

        [TestMethod]
        public void GetRectangle_ReturnsCorrectDimensions()
        {
            
            CircleTool circleTool = new CircleTool(_testColor, _testPenSize, true);
            circleTool.OnMouseDown(new Point(70, 80));             circleTool.OnMouseMove(new Point(20, 30)); 
            
            var getRectangleMethod = typeof(CircleTool).GetMethod("GetRectangle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Rectangle actualRect = (Rectangle)getRectangleMethod.Invoke(circleTool, null);

            Assert.AreEqual(20, actualRect.X);
            Assert.AreEqual(30, actualRect.Y);
            Assert.AreEqual(50, actualRect.Width);
            Assert.AreEqual(50, actualRect.Height);
        }
        [TestMethod]
        public void NoException_NoPointMethod()
        {
            CircleTool circleTool = new CircleTool(_testColor, _testPenSize, true);
            Bitmap testBitmap = new Bitmap(1, 1); 
            using (Graphics graphics = Graphics.FromImage(testBitmap))
            {
                try
                {
                    circleTool.Draw(graphics);
                    Assert.IsTrue(true, "Nu ar trebuie sa dea exceptie");
                }
                catch (Exception ex)
                {
                    Assert.Fail($"Eroare : {ex.Message}");
                }
            }
        }
    }
}
