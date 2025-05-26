using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Paint_IP_proiect
{


    public class Caretaker
    {
        private Stack<Memento> _undoStack;
        private const int MAX_HISTORY = 20;

        public Caretaker()
        {
            _undoStack = new Stack<Memento>();
        }

        public void SaveState(Originator originator)
        {
            _undoStack.Push(originator.Save());

            // Clear redo stack because new action invalidates redo history (if you implement redo)

            if (_undoStack.Count > MAX_HISTORY)
            {
                // Convert to list (top of stack is at index 0)
                List<Memento> tempList = _undoStack.ToList();

                // Remove the oldest items from the end of the list
                while (tempList.Count > MAX_HISTORY)
                {
                    tempList.RemoveAt(tempList.Count - 1); // Removes the last element (oldest memento)
                }

                // Reverse the list so that when we create a new stack, the order is preserved
                // (oldest at the bottom, newest at the top)
                tempList.Reverse();
                _undoStack = new Stack<Memento>(tempList);
            }
        }

        public bool CanUndo => _undoStack.Count > 1;

        public void Undo(ImageOriginator originator)
        {
            if (_undoStack.Count > 1)
            {
                var current = _undoStack.Pop();
                
                _undoStack.Peek().Restore(); // Restore previous
            }
        }
    }

    public interface Memento
    {
        void Restore();
    }

    public interface Originator
    {
        Memento Save();
    }

    public class ImageOriginator : Originator
    {
        private Image _img;
        public Image Image
        {
            get => _img;
            set => _img = value;
        }

        public Memento Save()
        {
            return new ImageMemento(this, (Image)_img.Clone());
        }

        public void RestoreState(Image img)
        {
            _img = img;
        }
    }

    public class ImageMemento : Memento
    {
        private readonly ImageOriginator _originator;
        private readonly Image _savedImage;

        public ImageMemento(ImageOriginator originator, Image savedImage)
        {
            _originator = originator;
            _savedImage = savedImage;
        }

        public void Restore()
        {
            _originator.RestoreState((Image)_savedImage.Clone());
        }
    }
}
