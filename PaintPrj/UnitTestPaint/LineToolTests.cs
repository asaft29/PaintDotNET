using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaintTools;

namespace PaintToolsTests
{
    [TestClass]
    public class LineToolTests
    {
        [TestMethod]
        public void Constructor_SetsColorAndPenSize()
        {
            var color = Color.Red;
            var penSize = 2;

            var lineTool = new LineTool(color, penSize);

            Assert.AreEqual(color, lineTool.Color);
            Assert.AreEqual(penSize, lineTool.PenSize);
        }

        [TestMethod]
        public void Draw_DoesNothing_WhenStartEqualsEnd()
        {
            var lineTool = new LineTool(Color.Black, 1);
            var bitmap = new Bitmap(10, 10);
            var graphics = Graphics.FromImage(bitmap);

            lineTool.OnMouseDown(new Point(5, 5));
            lineTool.OnMouseUp(new Point(5, 5));
            graphics.Clear(Color.White);
            lineTool.Draw(graphics);

            Assert.AreEqual(Color.White.ToArgb(), bitmap.GetPixel(5, 5).ToArgb());
        }

        [TestMethod]
        public void Draw_Line_WhenStartDifferentFromEnd()
        {
            var lineTool = new LineTool(Color.Blue, 1);
            var bitmap = new Bitmap(10, 10);
            var graphics = Graphics.FromImage(bitmap);

            lineTool.OnMouseDown(new Point(1, 1));
            lineTool.OnMouseUp(new Point(8, 8));
            graphics.Clear(Color.White);
            lineTool.Draw(graphics);

            Assert.AreEqual(Color.Blue.ToArgb(), bitmap.GetPixel(1, 1).ToArgb());
            Assert.AreEqual(Color.Blue.ToArgb(), bitmap.GetPixel(5, 5).ToArgb());
            Assert.AreEqual(Color.Blue.ToArgb(), bitmap.GetPixel(8, 8).ToArgb());
        }

        [TestMethod]
        public void Properties_CanBeModified()
        {
            var lineTool = new LineTool(Color.Green, 1);
            var newColor = Color.Red;
            var newSize = 3;

            lineTool.Color = newColor;
            lineTool.PenSize = newSize;

            Assert.AreEqual(newColor, lineTool.Color);
            Assert.AreEqual(newSize, lineTool.PenSize);
        }
    }
}
