using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Drawing;
using System.Windows.Forms;
namespace ImageIO
{
    /// <summary>
    /// Clasa pentru a salva/incarca imagini.
    /// </summary>
    public class ImageIO
    {
        /// <summary>
        /// Salveaza imaginea.
        /// </summary>
        /// <param name="image">Imaginea ce trebuie salvata.</param>
        /// <exception cref="ImageIOException">Exceptie aruncata cand imaginea este nula.</exception>
        public static void Save(Image image)
        {
            if(image == null)
            {
                throw new ImageIOException();
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            string[] funnyNames = { "Monalisa", "Fata cu cercel de perla",
                                            "Nasterea lui Venus", "Noapte instelata",
                                            "Crearea lui Adam", "American Gothic"};

            saveFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            saveFileDialog.DefaultExt = "png";
            Random rnd = new Random();
            int index = rnd.Next(funnyNames.Length);
            saveFileDialog.FileName = funnyNames[index];

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                image.Save(saveFileDialog.FileName);
            }

        }


        /// <summary>
        /// Salveaza imaginea.
        /// </summary>
        /// <param name="width">Latimea imaginii returnate.</param>
        /// <param name="height">Inaltimea imaginii returnate.</param>
        /// <returns>Un obiect de tipul Image ce contine imaginea incarcata.</returns>
        /// <exception cref="ImageIOException">Exceptie aruncata cand nu se selecteaza un path.</exception>
        public static Image Load(int width, int height)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selectati ce imagine doriti sa incarcati:";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image ret = Image.FromFile(openFileDialog.FileName);
                ret = new Bitmap(ret, width, height);
                return ret;
            }
            throw new ImageIOException("Nu s-a putut incarca imaginea. Trebuie ales un path neaparat!");
        }
    }
}
