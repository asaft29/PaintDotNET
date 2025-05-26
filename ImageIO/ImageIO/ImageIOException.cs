using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/// <summary>
/// Exceptie aruncata atunci cand o imagine este nula.
/// </summary>
namespace ImageIO
{
    public class ImageIOException : Exception
    {

        /// <summary>
        /// Initializeaza o instanta noua instanta de <see cref="ImageIOException"/> class.
        /// </summary>
        public ImageIOException() : base("Imaginea este nula. Nu se pot salva iamgini nule.")
        {
        }

        /// <summary>
        /// Initializeaza o instanta noua instanta de <see cref="ImageIOException"/> class.
        /// </summary>
        /// <param name="message">Mesajul care descrie exceptia.</param>
        public ImageIOException(string message) : base(message) 
        {
        }
    }
}
