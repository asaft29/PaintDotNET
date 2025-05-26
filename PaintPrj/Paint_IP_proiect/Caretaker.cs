using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Paint_IP_proiect
{


    //public class Caretaker
    //{
    //    private Stack<Memento> _undoStack;
    //    private const int MAX_HISTORY = 20;

    //    public Caretaker()
    //    {
    //        _undoStack = new Stack<Memento>();
    //    }

    //    public void SaveState(Originator originator)
    //    {
    //        _undoStack.Push(originator.Save());

    //        // Clear redo stack because new action invalidates redo history (if you implement redo)

    //        if (_undoStack.Count > MAX_HISTORY)
    //        {
    //            // Convert to list (top of stack is at index 0)
    //            List<Memento> tempList = _undoStack.ToList();

    //            // Remove the oldest items from the end of the list
    //            while (tempList.Count > MAX_HISTORY)
    //            {
    //                tempList.RemoveAt(tempList.Count - 1); // Removes the last element (oldest memento)
    //            }

    //            // Reverse the list so that when we create a new stack, the order is preserved
    //            // (oldest at the bottom, newest at the top)
    //            tempList.Reverse();
    //            _undoStack = new Stack<Memento>(tempList);
    //        }
    //    }

    //    public bool CanUndo => _undoStack.Count > 1;

    //    public void Undo(ImageOriginator originator)
    //    {
    //        if (_undoStack.Count > 1)
    //        {
    //            var current = _undoStack.Pop();
                
    //            _undoStack.Peek().Restore(); // Restore previous
    //        }
    //    }
    //}









    //public interface Memento
    //{
    //    void Restore();
    //}

    //public interface Originator
    //{
    //    Memento Save();
    //}

    //public class ImageOriginator : Originator
    //{
    //    private Bitmap _img;
    //    public Image Image
    //    {
    //        get => _img;
    //        set => _img = new Bitmap(value);
    //    }

    //    public Memento Save()
    //    {
    //        return new ImageMemento(this, new Bitmap(_img));
    //    }

    //    public void RestoreState(Image img)
    //    {
    //        _img = new Bitmap(img);
    //    }
    //}

    //public class ImageMemento : Memento
    //{
    //    private readonly ImageOriginator _originator;
    //    private readonly Image _savedImage;

    //    public ImageMemento(ImageOriginator originator, Image savedImage)
    //    {
    //        _originator = originator;
    //        _savedImage = savedImage;
    //    }

    //    public void Restore()
    //    {
    //        _originator.RestoreState(new Bitmap(_savedImage));
    //    }
    //}



    


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

    class Caretaker
    {
        private Stack<Originator.Memento> _history;
        private Originator _originator;

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
