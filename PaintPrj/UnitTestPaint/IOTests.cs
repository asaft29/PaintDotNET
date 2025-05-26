using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ImageIO;
using System.Windows.Forms;
using System.Drawing;

namespace UnitTestPaint
{
    [TestClass]
    public class Test
    {
        private PictureBox _canvas;

        [TestInitialize]
        public void Init()
        {
            _canvas = new PictureBox();
        }

        // test pentru un canvas de dimensiuni mici
        [TestMethod]
        public void DLL_SaveSmallCanvas()
        {
            _canvas.Image = new Bitmap(100, 100);

            try
            {
                ImageIO.ImageIO.Save(_canvas.Image);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail($"Eroare la salvarea unui canvas mic! : {e.Message}");
            }
        }
    
        // test pentru un canvas de dimensiuni mari
        [TestMethod]
        public void DLL_SaveBigCanvas()
        {
            _canvas.Image = new Bitmap(8000, 8000);

            try
            {
                ImageIO.ImageIO.Save(_canvas.Image);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail($"Eroare la salvarea unui canvas mare! : {e.Message}");
            }
        }
        
        // test pentru o imagine transparenta sa nu fie erori
        [TestMethod]
        public void DLL_SaveTransparentCanvas()
        {
            _canvas.Image = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(_canvas.Image))
            {
                g.Clear(Color.Transparent);
            }

            try
            {
                ImageIO.ImageIO.Save(_canvas.Image);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail($"Eroare la salvarea unei canvas transparent!: {e.Message}");
            }
        }
        
        // test pentru a vedea daca exceptia creeata in DLL este valida
        [TestMethod]
        [ExpectedException(typeof(ImageIO.ImageIOException))]
        public void DLLSaveNullCanvas()
        {
            ImageIO.ImageIO.Save(null);
        }

        // test pentru cand se extrage corespunzator o imagine cu Load
        [TestMethod]
        public void DLL_LoadCorrectImage()
        {
            Random rand = new Random();

            int width = rand.Next(1000);
            int height = rand.Next(1000);

            Image test = ImageIO.ImageIO.Load(width, height);

            Assert.AreEqual(width, test.Width);
            Assert.AreEqual(height, test.Height);

        }

        // testam atunci cand dam Load si nu incarcam nicio imagine
        [TestMethod]
        [ExpectedException(typeof(ImageIO.ImageIOException))]
        public void DLL_LoadWrongImage()
        {
            Random rand = new Random();

            Image test = ImageIO.ImageIO.Load(rand.Next(5000), rand.Next(5000));
        
        }
    }
}
