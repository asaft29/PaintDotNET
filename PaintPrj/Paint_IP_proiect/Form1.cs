using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageIO;
using PaintTools;

namespace Paint_IP_proiect
{
    //notita - robert
    /*
    //butoanele atat pentru culori/tool-uri/meniu sunt redenumite
    //desi sunt generate functii button_click
    //pe undeva cu fulger la properties  se pot regenera
    //nu ma mai bag ca am stat vreo 2-3 ore innebunind cu aia de culori
    //spor, daca e mai modificam pe parcurs interfata, nu stiu ce color pallete sa ii pun
    //sau ce alte chestiute sa ii mai punem
    //eventual alte detalii ma intrebati sau sunt pe discord
    */

    //notita 2 - robert
    /*
     //da, am rezolvat ce ziceam mai sus, in teorie fiecare item, cel putin cele utile au nume sugestive, clare
    //am regenerat si functiile
    //cititi si aia de mai sus notita
    //ceau
    */


    public partial class Form1 : Form
    {
        private ToolManager _toolManager;
        private bool _isDrawing = false;

        private Graphics _canvasGraphics;
        private Color _currentColor = Color.Black;
        private int _currentPenSize = 3;

        private Caretaker _caretaker;
        private Originator _originator;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Paintdotnet";
            pictureBoxCanvas.Image = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);


            _canvasGraphics = Graphics.FromImage(pictureBoxCanvas.Image);
            _canvasGraphics.Clear(Color.White);


            _toolManager = new ToolManager();

            _toolManager.SetTool(new PencilTool(_currentColor, _currentPenSize));


            _originator = new Originator();
            _caretaker = new Caretaker(_originator);

            _originator.Image = (Bitmap)pictureBoxCanvas.Image;
            _caretaker.Save();
        }

        //butoane menustrip de sus


        //Butonul File->Save
        //To be tested
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Dorești să salvezi imaginea?", "Salvare", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ImageIO.ImageIO.Save(pictureBoxCanvas.Image);
                }
                catch (ImageIOException)
                {
                    //nimic, nu avem ce salva
                }

            }


            pictureBoxCanvas.Image = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
            _canvasGraphics = Graphics.FromImage(pictureBoxCanvas.Image);
            _canvasGraphics.Clear(Color.White);

            _originator.Image = (Bitmap)pictureBoxCanvas.Image;
            _caretaker.Save();
        }

        //Butonul File->Open
        //To be tested
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Dorești să salvezi imaginea?", "Salvare", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ImageIO.ImageIO.Save(pictureBoxCanvas.Image);
                }
                catch (ImageIOException)
                {
                    //nimic, nu avem ce salva
                }

            }

            try
            {
                pictureBoxCanvas.Image = ImageIO.ImageIO.Load(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                _canvasGraphics = Graphics.FromImage(pictureBoxCanvas.Image);
            }
            catch (ImageIOException)
            {
                pictureBoxCanvas.Image = new Bitmap(pictureBoxCanvas.Width, pictureBoxCanvas.Height);
                _canvasGraphics = Graphics.FromImage(pictureBoxCanvas.Image);
                _canvasGraphics.Clear(Color.White);
            }
            finally
            {
                pictureBoxCanvas.Invalidate();

                _originator.Image = (Bitmap)pictureBoxCanvas.Image;
                _caretaker.Save();
            }



        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageIO.ImageIO.Save(pictureBoxCanvas.Image);
            }
            catch (ImageIOException)
            {
                //nimic, nu avem ce salva
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _caretaker.Undo();
            _canvasGraphics?.Dispose();

            pictureBoxCanvas.Image?.Dispose();

            pictureBoxCanvas.Image = new Bitmap(_originator.Image);

            _canvasGraphics = Graphics.FromImage(pictureBoxCanvas.Image);

            _isDrawing = false;

            pictureBoxCanvas.Invalidate();


        }


        private void butonHelp_Click(object sender, EventArgs e)
        {
            Process.Start("Paintdotnet.chm");
        }

        private void butonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Dorești să salvezi imaginea?", "Salvare", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ImageIO.ImageIO.Save(pictureBoxCanvas.Image);
                }
                catch (ImageIOException)
                {
                    //nimic, nu avem ce salva
                }

            }
            Application.Exit();
        }


        //culoare custom
        private void buttonCuloareCustom_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                buttonCuloareCustom.BackColor = color;
            }
        }
        //butoane culori, prima linie, in ordine (stanga-dreapta)
        private void buttonCuloareNegru_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Black;
            UpdateToolColor();
        }

        private void buttonCuloareGriInchis_Click(object sender, EventArgs e)
        {
            _currentColor = Color.DarkGray;
            UpdateToolColor();
        }

        private void buttonCuloareMaroon_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Maroon;
            UpdateToolColor();
        }

        private void buttonCuloareOlive_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Olive;
            UpdateToolColor();
        }

        private void buttonCuloareVerde_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Green;
            UpdateToolColor();
        }

        private void buttonCuloareTeal_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Teal;
            UpdateToolColor();
        }

        private void buttonCuloareNavy_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Navy;
            UpdateToolColor();
        }

        private void buttonCuloarePurple_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Purple;
            UpdateToolColor();
        }

        private void buttonCuloareR192G192B0_Click(object sender, EventArgs e)
        {
            _currentColor = Color.FromArgb(192, 192, 0); 
            UpdateToolColor();
        }

        private void buttonCuloareR0G64B64_Click(object sender, EventArgs e)
        {
            _currentColor = Color.FromArgb(0, 64, 64); 
            UpdateToolColor();
        }

        private void buttonCuloareR128G128B255_Click(object sender, EventArgs e)
        {
            _currentColor = Color.FromArgb(128, 128, 255); 
            UpdateToolColor();
        }

        private void buttonCuloareR0G0B192_Click(object sender, EventArgs e)
        {
            _currentColor = Color.FromArgb(0, 0, 192); 
            UpdateToolColor();
        }

        private void buttonCuloareR192G192B255_Click(object sender, EventArgs e)
        {
            _currentColor = Color.FromArgb(192, 192, 255); 
            UpdateToolColor();
        }

        private void buttonCuloareMaro_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Brown;
            UpdateToolColor();
        }

        //butoane culori, linia 2, stanga dreapta
        private void buttonCuloareAlb_Click(object sender, EventArgs e)
        {
            _currentColor = Color.White;
            UpdateToolColor();
        }

        private void buttonCuloareGriDeschis_Click(object sender, EventArgs e)
        {
            _currentColor = Color.LightGray;
            UpdateToolColor();
        }

        private void buttonCuloareRosu_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Red;
            UpdateToolColor();
        }

        private void buttonCuloareGalben_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Yellow;
            UpdateToolColor();
        }

        private void buttonCuloareLime_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Lime;
            UpdateToolColor();
        }

        private void buttonCuloareCyan_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Cyan;
            UpdateToolColor();
        }

        private void buttonCuloareAlbastru_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Blue;
            UpdateToolColor();
        }

        private void buttonCuloareFichsia_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Fuchsia;
            UpdateToolColor();
        }

        private void buttonCuloareR25G255B128_Click(object sender, EventArgs e)
        {
            _currentColor = Color.FromArgb(25, 255, 128); 
            UpdateToolColor();
        }

        private void buttonCuloareR128G255B128_Click(object sender, EventArgs e)
        {
            _currentColor = Color.FromArgb(128, 255, 128); 
            UpdateToolColor();
        }

        private void buttonCuloareR192G255B255_Click(object sender, EventArgs e)
        {
            _currentColor = Color.FromArgb(192, 255, 255); 
            UpdateToolColor();
        }

        private void buttonCuloareMediumSlateBlue_Click(object sender, EventArgs e)
        {
            _currentColor = Color.MediumSlateBlue;
            UpdateToolColor();
        }

        private void buttonCuloareRoz_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Pink;
            UpdateToolColor();
        }

        private void buttonCuloarePortocaliu_Click(object sender, EventArgs e)
        {
            _currentColor = Color.Orange;
            UpdateToolColor();
        }

        private void UpdateToolColor()
        {
            if (_toolManager.CurrentTool != null)
            {
                _toolManager.CurrentTool.Color = _currentColor;
            }
        }

        //butoane unelte siderbar
        private void buttonEraser_Click(object sender, EventArgs e)
        {
            _toolManager.SetTool(new EraserTool(_currentPenSize));
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            _toolManager.SetTool(new PencilTool(_currentColor, _currentPenSize));
        }

        private void buttonBucketFill_Click(object sender, EventArgs e)
        {
            var fillTool = new FillTool(_currentColor);
            fillTool.SetTargetBitmap((Bitmap)pictureBoxCanvas.Image);
            _toolManager.SetTool(fillTool);
        }

        private void buttonStraightLine_Click(object sender, EventArgs e)
        {
            _toolManager.SetTool(new LineTool(_currentColor, _currentPenSize));
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            _toolManager.SetTool(new RectangleTool(_currentColor, _currentPenSize, false));
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            _toolManager.SetTool(new CircleTool(_currentColor, _currentPenSize, false));
        }

        //suprafata de desenat ig
        private void pictureBoxCanvas_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            _caretaker.Save();
            _isDrawing = true;
            _toolManager.MouseDown(e.Location);
            pictureBoxCanvas.Invalidate();
        }

        private void pictureBoxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _toolManager.MouseMove(e.Location);
                pictureBoxCanvas.Invalidate();
            }
        }

        private void pictureBoxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            _toolManager.MouseUp(e.Location);
            _toolManager.ApplyToBitmap((Bitmap)pictureBoxCanvas.Image);


            _originator.Image = new Bitmap((Bitmap)pictureBoxCanvas.Image);
            _isDrawing = false;
            pictureBoxCanvas.Invalidate();


        }

        private void pictureBoxCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (pictureBoxCanvas.Image != null)
            {
                e.Graphics.DrawImage(pictureBoxCanvas.Image, Point.Empty);
            }
            if (_isDrawing)
            {
                _toolManager.Draw(e.Graphics);
            }
        }

        //ramasisuri pe care daca le scot crapa si le-am generat din greseala
        private void groupBoxCulori_Enter(object sender, EventArgs e)
        {

        }
    }
}
