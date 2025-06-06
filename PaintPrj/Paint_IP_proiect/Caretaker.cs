using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Paint_IP_proiect
{

    //Clasa pentru sablonul Originator-produce obiecte de tip Memento
    class Originator
    {


        public class Memento
        {
            private Bitmap _img;
            public Memento(Bitmap img)
            {
                _img = new Bitmap(img);
            }

            public Bitmap GetState()
            {
                return _img;
            }

        }

        private Bitmap _img;
        public Memento Save()
        {
            return new Memento(_img);
        }
        public Bitmap Image
        {
            get => _img;
            set=>_img= value;
        }
        public void Restore(Memento memento)
        {
            _img = new Bitmap(memento.GetState());
        }
    }

    //clasa pentru sablonul Memento, responsabila pentru salvat/istoric
    class Caretaker
    {
        private Stack<Originator.Memento> _history;
        private Originator _originator;
        private const int MaxHistory = 20;
        
        public Originator Originator
        {
            get => _originator;
            set => _originator = value;
        }

        public Caretaker(Originator originator)
        {
            _originator = originator;
            _history = new Stack<Originator.Memento>();
        }

        

        public void Save()
        {
            if (_history.Count >= MaxHistory)
            {
                _history = new Stack<Originator.Memento>(_history.Reverse().Skip(1)); 
            }
            _history.Push(_originator.Save());
        }



        public void Undo()
        {
            if (_history.Count > 0)
            {
                Originator.Memento m = _history.Pop();
                _originator.Restore(m);
            }
        }
    }

}
