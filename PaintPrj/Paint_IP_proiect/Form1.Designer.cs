namespace Paint_IP_proiect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.butonFile = new System.Windows.Forms.ToolStripSplitButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.butonEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.butonHelp = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.butonExit = new System.Windows.Forms.ToolStripLabel();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.buttonEraser = new System.Windows.Forms.Button();
            this.buttonPencil = new System.Windows.Forms.Button();
            this.buttonBucketFill = new System.Windows.Forms.Button();
            this.buttonStraightLine = new System.Windows.Forms.Button();
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.groupBoxCulori = new System.Windows.Forms.GroupBox();
            this.buttonCuloareAlb = new System.Windows.Forms.Button();
            this.buttonCuloareNegru = new System.Windows.Forms.Button();
            this.buttonCuloareGriDeschis = new System.Windows.Forms.Button();
            this.buttonCuloareGriInchis = new System.Windows.Forms.Button();
            this.buttonCuloareRosu = new System.Windows.Forms.Button();
            this.buttonCuloareMaroon = new System.Windows.Forms.Button();
            this.buttonCuloareGalben = new System.Windows.Forms.Button();
            this.buttonCuloareOlive = new System.Windows.Forms.Button();
            this.buttonCuloareLime = new System.Windows.Forms.Button();
            this.buttonCuloareVerde = new System.Windows.Forms.Button();
            this.buttonCuloareCyan = new System.Windows.Forms.Button();
            this.buttonCuloareTeal = new System.Windows.Forms.Button();
            this.buttonCuloareAlbastru = new System.Windows.Forms.Button();
            this.buttonCuloareNavy = new System.Windows.Forms.Button();
            this.buttonCuloareFichsia = new System.Windows.Forms.Button();
            this.buttonCuloarePurple = new System.Windows.Forms.Button();
            this.buttonCuloareR25G255B128 = new System.Windows.Forms.Button();
            this.buttonCuloareR192G192B0 = new System.Windows.Forms.Button();
            this.buttonCuloareR128G255B128 = new System.Windows.Forms.Button();
            this.buttonCuloareR0G64B64 = new System.Windows.Forms.Button();
            this.buttonCuloareR192G255B255 = new System.Windows.Forms.Button();
            this.buttonCuloareR128G128B255 = new System.Windows.Forms.Button();
            this.buttonCuloareMediumSlateBlue = new System.Windows.Forms.Button();
            this.buttonCuloareR0G0B192 = new System.Windows.Forms.Button();
            this.buttonCuloareRoz = new System.Windows.Forms.Button();
            this.buttonCuloareR192G192B255 = new System.Windows.Forms.Button();
            this.buttonCuloarePortocaliu = new System.Windows.Forms.Button();
            this.buttonCuloareMaro = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCuloareCustom = new System.Windows.Forms.Button();
            this.groupBoxCuloarePersonalizata = new System.Windows.Forms.GroupBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.groupBoxTools.SuspendLayout();
            this.groupBoxCulori.SuspendLayout();
            this.groupBoxCuloarePersonalizata.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.butonFile,
            this.toolStripSeparator1,
            this.butonEdit,
            this.toolStripSeparator2,
            this.butonHelp,
            this.toolStripSeparator3,
            this.butonExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(606, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // butonFile
            // 
            this.butonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.butonFile.Name = "butonFile";
            this.butonFile.Size = new System.Drawing.Size(41, 22);
            this.butonFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // butonEdit
            // 
            this.butonEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.butonEdit.Name = "butonEdit";
            this.butonEdit.Size = new System.Drawing.Size(40, 22);
            this.butonEdit.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // butonHelp
            // 
            this.butonHelp.Name = "butonHelp";
            this.butonHelp.Size = new System.Drawing.Size(32, 22);
            this.butonHelp.Text = "Help";
            this.butonHelp.Click += new System.EventHandler(this.butonHelp_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // butonExit
            // 
            this.butonExit.Name = "butonExit";
            this.butonExit.Size = new System.Drawing.Size(26, 22);
            this.butonExit.Text = "Exit";
            this.butonExit.Click += new System.EventHandler(this.butonExit_Click);
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.Color.White;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(8, 37);
            this.pictureBoxCanvas.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(524, 282);
            this.pictureBoxCanvas.TabIndex = 1;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.Click += new System.EventHandler(this.pictureBoxCanvas_Click);
            this.pictureBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCanvas_Paint);
            this.pictureBoxCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseDown);
            this.pictureBoxCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseMove);
            this.pictureBoxCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseUp);
            // 
            // buttonEraser
            // 
            this.buttonEraser.BackgroundImage = global::Paint_IP_proiect.Properties.Resources.eraser;
            this.buttonEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEraser.Location = new System.Drawing.Point(8, 16);
            this.buttonEraser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEraser.Name = "buttonEraser";
            this.buttonEraser.Size = new System.Drawing.Size(25, 24);
            this.buttonEraser.TabIndex = 10;
            this.buttonEraser.UseVisualStyleBackColor = true;
            this.buttonEraser.Click += new System.EventHandler(this.buttonEraser_Click);
            // 
            // buttonPencil
            // 
            this.buttonPencil.BackgroundImage = global::Paint_IP_proiect.Properties.Resources.pencil;
            this.buttonPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPencil.Location = new System.Drawing.Point(8, 56);
            this.buttonPencil.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(25, 24);
            this.buttonPencil.TabIndex = 11;
            this.buttonPencil.UseVisualStyleBackColor = true;
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonBucketFill
            // 
            this.buttonBucketFill.BackgroundImage = global::Paint_IP_proiect.Properties.Resources.paint_bucket;
            this.buttonBucketFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBucketFill.Location = new System.Drawing.Point(8, 95);
            this.buttonBucketFill.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBucketFill.Name = "buttonBucketFill";
            this.buttonBucketFill.Size = new System.Drawing.Size(25, 24);
            this.buttonBucketFill.TabIndex = 12;
            this.buttonBucketFill.UseVisualStyleBackColor = true;
            this.buttonBucketFill.Click += new System.EventHandler(this.buttonBucketFill_Click);
            // 
            // buttonStraightLine
            // 
            this.buttonStraightLine.BackgroundImage = global::Paint_IP_proiect.Properties.Resources.diagonal_line;
            this.buttonStraightLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStraightLine.Location = new System.Drawing.Point(8, 132);
            this.buttonStraightLine.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStraightLine.Name = "buttonStraightLine";
            this.buttonStraightLine.Size = new System.Drawing.Size(25, 24);
            this.buttonStraightLine.TabIndex = 13;
            this.buttonStraightLine.UseVisualStyleBackColor = true;
            this.buttonStraightLine.Click += new System.EventHandler(this.buttonStraightLine_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.BackgroundImage = global::Paint_IP_proiect.Properties.Resources.rectangular_shape_outline;
            this.buttonRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRectangle.Location = new System.Drawing.Point(8, 170);
            this.buttonRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(25, 24);
            this.buttonRectangle.TabIndex = 14;
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.BackgroundImage = global::Paint_IP_proiect.Properties.Resources.dry_clean;
            this.buttonCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCircle.Location = new System.Drawing.Point(8, 207);
            this.buttonCircle.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(25, 24);
            this.buttonCircle.TabIndex = 15;
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.BackColor = System.Drawing.Color.Firebrick;
            this.groupBoxTools.Controls.Add(this.buttonCircle);
            this.groupBoxTools.Controls.Add(this.buttonRectangle);
            this.groupBoxTools.Controls.Add(this.buttonStraightLine);
            this.groupBoxTools.Controls.Add(this.buttonBucketFill);
            this.groupBoxTools.Controls.Add(this.buttonPencil);
            this.groupBoxTools.Controls.Add(this.buttonEraser);
            this.groupBoxTools.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBoxTools.Location = new System.Drawing.Point(548, 53);
            this.groupBoxTools.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTools.Size = new System.Drawing.Size(44, 252);
            this.groupBoxTools.TabIndex = 16;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Tools";
            // 
            // groupBoxCulori
            // 
            this.groupBoxCulori.BackColor = System.Drawing.Color.Firebrick;
            this.groupBoxCulori.Controls.Add(this.buttonCuloareAlb);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareNegru);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareGriDeschis);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareGriInchis);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareRosu);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareMaroon);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareGalben);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareOlive);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareLime);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareVerde);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareCyan);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareTeal);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareAlbastru);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareNavy);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareFichsia);
            this.groupBoxCulori.Controls.Add(this.buttonCuloarePurple);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareR25G255B128);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareR192G192B0);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareR128G255B128);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareR0G64B64);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareR192G255B255);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareR128G128B255);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareMediumSlateBlue);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareR0G0B192);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareRoz);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareR192G192B255);
            this.groupBoxCulori.Controls.Add(this.buttonCuloarePortocaliu);
            this.groupBoxCulori.Controls.Add(this.buttonCuloareMaro);
            this.groupBoxCulori.ForeColor = System.Drawing.Color.White;
            this.groupBoxCulori.Location = new System.Drawing.Point(58, 336);
            this.groupBoxCulori.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCulori.Name = "groupBoxCulori";
            this.groupBoxCulori.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCulori.Size = new System.Drawing.Size(260, 42);
            this.groupBoxCulori.TabIndex = 17;
            this.groupBoxCulori.TabStop = false;
            this.groupBoxCulori.Text = "Colors";
            this.groupBoxCulori.Enter += new System.EventHandler(this.groupBoxCulori_Enter);
            // 
            // buttonCuloareAlb
            // 
            this.buttonCuloareAlb.BackColor = System.Drawing.Color.White;
            this.buttonCuloareAlb.Location = new System.Drawing.Point(41, 22);
            this.buttonCuloareAlb.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareAlb.Name = "buttonCuloareAlb";
            this.buttonCuloareAlb.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareAlb.TabIndex = 44;
            this.buttonCuloareAlb.UseVisualStyleBackColor = false;
            this.buttonCuloareAlb.Click += new System.EventHandler(this.buttonCuloareAlb_Click);
            // 
            // buttonCuloareNegru
            // 
            this.buttonCuloareNegru.BackColor = System.Drawing.Color.Black;
            this.buttonCuloareNegru.ForeColor = System.Drawing.Color.Black;
            this.buttonCuloareNegru.Location = new System.Drawing.Point(41, 7);
            this.buttonCuloareNegru.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareNegru.Name = "buttonCuloareNegru";
            this.buttonCuloareNegru.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareNegru.TabIndex = 43;
            this.buttonCuloareNegru.UseVisualStyleBackColor = false;
            this.buttonCuloareNegru.Click += new System.EventHandler(this.buttonCuloareNegru_Click);
            // 
            // buttonCuloareGriDeschis
            // 
            this.buttonCuloareGriDeschis.BackColor = System.Drawing.Color.Gray;
            this.buttonCuloareGriDeschis.Location = new System.Drawing.Point(56, 22);
            this.buttonCuloareGriDeschis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareGriDeschis.Name = "buttonCuloareGriDeschis";
            this.buttonCuloareGriDeschis.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareGriDeschis.TabIndex = 42;
            this.buttonCuloareGriDeschis.UseVisualStyleBackColor = false;
            this.buttonCuloareGriDeschis.Click += new System.EventHandler(this.buttonCuloareGriDeschis_Click);
            // 
            // buttonCuloareGriInchis
            // 
            this.buttonCuloareGriInchis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCuloareGriInchis.Location = new System.Drawing.Point(56, 7);
            this.buttonCuloareGriInchis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareGriInchis.Name = "buttonCuloareGriInchis";
            this.buttonCuloareGriInchis.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareGriInchis.TabIndex = 41;
            this.buttonCuloareGriInchis.UseVisualStyleBackColor = false;
            this.buttonCuloareGriInchis.Click += new System.EventHandler(this.buttonCuloareGriInchis_Click);
            // 
            // buttonCuloareRosu
            // 
            this.buttonCuloareRosu.BackColor = System.Drawing.Color.Red;
            this.buttonCuloareRosu.Location = new System.Drawing.Point(72, 22);
            this.buttonCuloareRosu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareRosu.Name = "buttonCuloareRosu";
            this.buttonCuloareRosu.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareRosu.TabIndex = 40;
            this.buttonCuloareRosu.UseVisualStyleBackColor = false;
            this.buttonCuloareRosu.Click += new System.EventHandler(this.buttonCuloareRosu_Click);
            // 
            // buttonCuloareMaroon
            // 
            this.buttonCuloareMaroon.BackColor = System.Drawing.Color.Maroon;
            this.buttonCuloareMaroon.Location = new System.Drawing.Point(72, 7);
            this.buttonCuloareMaroon.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareMaroon.Name = "buttonCuloareMaroon";
            this.buttonCuloareMaroon.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareMaroon.TabIndex = 39;
            this.buttonCuloareMaroon.UseVisualStyleBackColor = false;
            this.buttonCuloareMaroon.Click += new System.EventHandler(this.buttonCuloareMaroon_Click);
            // 
            // buttonCuloareGalben
            // 
            this.buttonCuloareGalben.BackColor = System.Drawing.Color.Yellow;
            this.buttonCuloareGalben.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCuloareGalben.Location = new System.Drawing.Point(87, 22);
            this.buttonCuloareGalben.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareGalben.Name = "buttonCuloareGalben";
            this.buttonCuloareGalben.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareGalben.TabIndex = 38;
            this.buttonCuloareGalben.UseVisualStyleBackColor = false;
            this.buttonCuloareGalben.Click += new System.EventHandler(this.buttonCuloareGalben_Click);
            // 
            // buttonCuloareOlive
            // 
            this.buttonCuloareOlive.BackColor = System.Drawing.Color.Olive;
            this.buttonCuloareOlive.Location = new System.Drawing.Point(87, 7);
            this.buttonCuloareOlive.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareOlive.Name = "buttonCuloareOlive";
            this.buttonCuloareOlive.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareOlive.TabIndex = 37;
            this.buttonCuloareOlive.UseVisualStyleBackColor = false;
            this.buttonCuloareOlive.Click += new System.EventHandler(this.buttonCuloareOlive_Click);
            // 
            // buttonCuloareLime
            // 
            this.buttonCuloareLime.BackColor = System.Drawing.Color.Lime;
            this.buttonCuloareLime.Location = new System.Drawing.Point(102, 22);
            this.buttonCuloareLime.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareLime.Name = "buttonCuloareLime";
            this.buttonCuloareLime.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareLime.TabIndex = 36;
            this.buttonCuloareLime.UseVisualStyleBackColor = false;
            this.buttonCuloareLime.Click += new System.EventHandler(this.buttonCuloareLime_Click);
            // 
            // buttonCuloareVerde
            // 
            this.buttonCuloareVerde.BackColor = System.Drawing.Color.Green;
            this.buttonCuloareVerde.Location = new System.Drawing.Point(102, 7);
            this.buttonCuloareVerde.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareVerde.Name = "buttonCuloareVerde";
            this.buttonCuloareVerde.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareVerde.TabIndex = 35;
            this.buttonCuloareVerde.UseVisualStyleBackColor = false;
            this.buttonCuloareVerde.Click += new System.EventHandler(this.buttonCuloareVerde_Click);
            // 
            // buttonCuloareCyan
            // 
            this.buttonCuloareCyan.BackColor = System.Drawing.Color.Cyan;
            this.buttonCuloareCyan.Location = new System.Drawing.Point(117, 22);
            this.buttonCuloareCyan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareCyan.Name = "buttonCuloareCyan";
            this.buttonCuloareCyan.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareCyan.TabIndex = 34;
            this.buttonCuloareCyan.UseVisualStyleBackColor = false;
            this.buttonCuloareCyan.Click += new System.EventHandler(this.buttonCuloareCyan_Click);
            // 
            // buttonCuloareTeal
            // 
            this.buttonCuloareTeal.BackColor = System.Drawing.Color.Teal;
            this.buttonCuloareTeal.Location = new System.Drawing.Point(117, 7);
            this.buttonCuloareTeal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareTeal.Name = "buttonCuloareTeal";
            this.buttonCuloareTeal.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareTeal.TabIndex = 33;
            this.buttonCuloareTeal.UseVisualStyleBackColor = false;
            this.buttonCuloareTeal.Click += new System.EventHandler(this.buttonCuloareTeal_Click);
            // 
            // buttonCuloareAlbastru
            // 
            this.buttonCuloareAlbastru.BackColor = System.Drawing.Color.Blue;
            this.buttonCuloareAlbastru.Location = new System.Drawing.Point(132, 22);
            this.buttonCuloareAlbastru.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareAlbastru.Name = "buttonCuloareAlbastru";
            this.buttonCuloareAlbastru.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareAlbastru.TabIndex = 32;
            this.buttonCuloareAlbastru.UseVisualStyleBackColor = false;
            this.buttonCuloareAlbastru.Click += new System.EventHandler(this.buttonCuloareAlbastru_Click);
            // 
            // buttonCuloareNavy
            // 
            this.buttonCuloareNavy.BackColor = System.Drawing.Color.Navy;
            this.buttonCuloareNavy.Location = new System.Drawing.Point(132, 7);
            this.buttonCuloareNavy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareNavy.Name = "buttonCuloareNavy";
            this.buttonCuloareNavy.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareNavy.TabIndex = 31;
            this.buttonCuloareNavy.UseVisualStyleBackColor = false;
            this.buttonCuloareNavy.Click += new System.EventHandler(this.buttonCuloareNavy_Click);
            // 
            // buttonCuloareFichsia
            // 
            this.buttonCuloareFichsia.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonCuloareFichsia.Location = new System.Drawing.Point(147, 22);
            this.buttonCuloareFichsia.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareFichsia.Name = "buttonCuloareFichsia";
            this.buttonCuloareFichsia.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareFichsia.TabIndex = 30;
            this.buttonCuloareFichsia.UseVisualStyleBackColor = false;
            this.buttonCuloareFichsia.Click += new System.EventHandler(this.buttonCuloareFichsia_Click);
            // 
            // buttonCuloarePurple
            // 
            this.buttonCuloarePurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonCuloarePurple.Location = new System.Drawing.Point(147, 7);
            this.buttonCuloarePurple.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloarePurple.Name = "buttonCuloarePurple";
            this.buttonCuloarePurple.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloarePurple.TabIndex = 29;
            this.buttonCuloarePurple.UseVisualStyleBackColor = false;
            this.buttonCuloarePurple.Click += new System.EventHandler(this.buttonCuloarePurple_Click);
            // 
            // buttonCuloareR25G255B128
            // 
            this.buttonCuloareR25G255B128.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCuloareR25G255B128.Location = new System.Drawing.Point(162, 22);
            this.buttonCuloareR25G255B128.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareR25G255B128.Name = "buttonCuloareR25G255B128";
            this.buttonCuloareR25G255B128.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareR25G255B128.TabIndex = 28;
            this.buttonCuloareR25G255B128.UseVisualStyleBackColor = false;
            this.buttonCuloareR25G255B128.Click += new System.EventHandler(this.buttonCuloareR25G255B128_Click);
            // 
            // buttonCuloareR192G192B0
            // 
            this.buttonCuloareR192G192B0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonCuloareR192G192B0.Location = new System.Drawing.Point(162, 7);
            this.buttonCuloareR192G192B0.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareR192G192B0.Name = "buttonCuloareR192G192B0";
            this.buttonCuloareR192G192B0.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareR192G192B0.TabIndex = 27;
            this.buttonCuloareR192G192B0.UseVisualStyleBackColor = false;
            this.buttonCuloareR192G192B0.Click += new System.EventHandler(this.buttonCuloareR192G192B0_Click);
            // 
            // buttonCuloareR128G255B128
            // 
            this.buttonCuloareR128G255B128.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonCuloareR128G255B128.Location = new System.Drawing.Point(177, 22);
            this.buttonCuloareR128G255B128.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareR128G255B128.Name = "buttonCuloareR128G255B128";
            this.buttonCuloareR128G255B128.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareR128G255B128.TabIndex = 26;
            this.buttonCuloareR128G255B128.UseVisualStyleBackColor = false;
            this.buttonCuloareR128G255B128.Click += new System.EventHandler(this.buttonCuloareR128G255B128_Click);
            // 
            // buttonCuloareR0G64B64
            // 
            this.buttonCuloareR0G64B64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCuloareR0G64B64.Location = new System.Drawing.Point(177, 7);
            this.buttonCuloareR0G64B64.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareR0G64B64.Name = "buttonCuloareR0G64B64";
            this.buttonCuloareR0G64B64.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareR0G64B64.TabIndex = 25;
            this.buttonCuloareR0G64B64.UseVisualStyleBackColor = false;
            this.buttonCuloareR0G64B64.Click += new System.EventHandler(this.buttonCuloareR0G64B64_Click);
            // 
            // buttonCuloareR192G255B255
            // 
            this.buttonCuloareR192G255B255.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCuloareR192G255B255.Location = new System.Drawing.Point(193, 22);
            this.buttonCuloareR192G255B255.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareR192G255B255.Name = "buttonCuloareR192G255B255";
            this.buttonCuloareR192G255B255.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareR192G255B255.TabIndex = 24;
            this.buttonCuloareR192G255B255.UseVisualStyleBackColor = false;
            this.buttonCuloareR192G255B255.Click += new System.EventHandler(this.buttonCuloareR192G255B255_Click);
            // 
            // buttonCuloareR128G128B255
            // 
            this.buttonCuloareR128G128B255.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonCuloareR128G128B255.Location = new System.Drawing.Point(193, 7);
            this.buttonCuloareR128G128B255.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareR128G128B255.Name = "buttonCuloareR128G128B255";
            this.buttonCuloareR128G128B255.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareR128G128B255.TabIndex = 23;
            this.buttonCuloareR128G128B255.UseVisualStyleBackColor = false;
            this.buttonCuloareR128G128B255.Click += new System.EventHandler(this.buttonCuloareR128G128B255_Click);
            // 
            // buttonCuloareMediumSlateBlue
            // 
            this.buttonCuloareMediumSlateBlue.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCuloareMediumSlateBlue.Location = new System.Drawing.Point(208, 22);
            this.buttonCuloareMediumSlateBlue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareMediumSlateBlue.Name = "buttonCuloareMediumSlateBlue";
            this.buttonCuloareMediumSlateBlue.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareMediumSlateBlue.TabIndex = 22;
            this.buttonCuloareMediumSlateBlue.UseVisualStyleBackColor = false;
            this.buttonCuloareMediumSlateBlue.Click += new System.EventHandler(this.buttonCuloareMediumSlateBlue_Click);
            // 
            // buttonCuloareR0G0B192
            // 
            this.buttonCuloareR0G0B192.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonCuloareR0G0B192.Location = new System.Drawing.Point(208, 7);
            this.buttonCuloareR0G0B192.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareR0G0B192.Name = "buttonCuloareR0G0B192";
            this.buttonCuloareR0G0B192.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareR0G0B192.TabIndex = 21;
            this.buttonCuloareR0G0B192.UseVisualStyleBackColor = false;
            this.buttonCuloareR0G0B192.Click += new System.EventHandler(this.buttonCuloareR0G0B192_Click);
            // 
            // buttonCuloareRoz
            // 
            this.buttonCuloareRoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCuloareRoz.Location = new System.Drawing.Point(223, 22);
            this.buttonCuloareRoz.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareRoz.Name = "buttonCuloareRoz";
            this.buttonCuloareRoz.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareRoz.TabIndex = 20;
            this.buttonCuloareRoz.UseVisualStyleBackColor = false;
            this.buttonCuloareRoz.Click += new System.EventHandler(this.buttonCuloareRoz_Click);
            // 
            // buttonCuloareR192G192B255
            // 
            this.buttonCuloareR192G192B255.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCuloareR192G192B255.Location = new System.Drawing.Point(223, 7);
            this.buttonCuloareR192G192B255.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareR192G192B255.Name = "buttonCuloareR192G192B255";
            this.buttonCuloareR192G192B255.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareR192G192B255.TabIndex = 19;
            this.buttonCuloareR192G192B255.UseVisualStyleBackColor = false;
            this.buttonCuloareR192G192B255.Click += new System.EventHandler(this.buttonCuloareR192G192B255_Click);
            // 
            // buttonCuloarePortocaliu
            // 
            this.buttonCuloarePortocaliu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCuloarePortocaliu.Location = new System.Drawing.Point(238, 22);
            this.buttonCuloarePortocaliu.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloarePortocaliu.Name = "buttonCuloarePortocaliu";
            this.buttonCuloarePortocaliu.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloarePortocaliu.TabIndex = 18;
            this.buttonCuloarePortocaliu.UseVisualStyleBackColor = false;
            this.buttonCuloarePortocaliu.Click += new System.EventHandler(this.buttonCuloarePortocaliu_Click);
            // 
            // buttonCuloareMaro
            // 
            this.buttonCuloareMaro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonCuloareMaro.Location = new System.Drawing.Point(238, 7);
            this.buttonCuloareMaro.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareMaro.Name = "buttonCuloareMaro";
            this.buttonCuloareMaro.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareMaro.TabIndex = 0;
            this.buttonCuloareMaro.UseVisualStyleBackColor = false;
            this.buttonCuloareMaro.Click += new System.EventHandler(this.buttonCuloareMaro_Click);
            // 
            // buttonCuloareCustom
            // 
            this.buttonCuloareCustom.BackColor = System.Drawing.Color.White;
            this.buttonCuloareCustom.Location = new System.Drawing.Point(80, 17);
            this.buttonCuloareCustom.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCuloareCustom.Name = "buttonCuloareCustom";
            this.buttonCuloareCustom.Size = new System.Drawing.Size(15, 16);
            this.buttonCuloareCustom.TabIndex = 20;
            this.buttonCuloareCustom.UseVisualStyleBackColor = false;
            this.buttonCuloareCustom.Click += new System.EventHandler(this.buttonCuloareCustom_Click);
            // 
            // groupBoxCuloarePersonalizata
            // 
            this.groupBoxCuloarePersonalizata.BackColor = System.Drawing.Color.Firebrick;
            this.groupBoxCuloarePersonalizata.Controls.Add(this.buttonCuloareCustom);
            this.groupBoxCuloarePersonalizata.ForeColor = System.Drawing.Color.White;
            this.groupBoxCuloarePersonalizata.Location = new System.Drawing.Point(388, 336);
            this.groupBoxCuloarePersonalizata.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCuloarePersonalizata.Name = "groupBoxCuloarePersonalizata";
            this.groupBoxCuloarePersonalizata.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxCuloarePersonalizata.Size = new System.Drawing.Size(112, 42);
            this.groupBoxCuloarePersonalizata.TabIndex = 21;
            this.groupBoxCuloarePersonalizata.TabStop = false;
            this.groupBoxCuloarePersonalizata.Text = "Culoare personalizata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(606, 388);
            this.Controls.Add(this.groupBoxCuloarePersonalizata);
            this.Controls.Add(this.groupBoxCulori);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxCulori.ResumeLayout(false);
            this.groupBoxCuloarePersonalizata.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton butonFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton butonEdit;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel butonHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel butonExit;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Button buttonEraser;
        private System.Windows.Forms.Button buttonPencil;
        private System.Windows.Forms.Button buttonBucketFill;
        private System.Windows.Forms.Button buttonStraightLine;
        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.GroupBox groupBoxCulori;
        private System.Windows.Forms.Button buttonCuloarePortocaliu;
        private System.Windows.Forms.Button buttonCuloareMaro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonCuloareRoz;
        private System.Windows.Forms.Button buttonCuloareR192G192B255;
        private System.Windows.Forms.Button buttonCuloareR192G255B255;
        private System.Windows.Forms.Button buttonCuloareR128G128B255;
        private System.Windows.Forms.Button buttonCuloareMediumSlateBlue;
        private System.Windows.Forms.Button buttonCuloareR0G0B192;
        private System.Windows.Forms.Button buttonCuloareAlb;
        private System.Windows.Forms.Button buttonCuloareGriDeschis;
        private System.Windows.Forms.Button buttonCuloareGriInchis;
        private System.Windows.Forms.Button buttonCuloareRosu;
        private System.Windows.Forms.Button buttonCuloareMaroon;
        private System.Windows.Forms.Button buttonCuloareGalben;
        private System.Windows.Forms.Button buttonCuloareOlive;
        private System.Windows.Forms.Button buttonCuloareLime;
        private System.Windows.Forms.Button buttonCuloareVerde;
        private System.Windows.Forms.Button buttonCuloareCyan;
        private System.Windows.Forms.Button buttonCuloareTeal;
        private System.Windows.Forms.Button buttonCuloareAlbastru;
        private System.Windows.Forms.Button buttonCuloareNavy;
        private System.Windows.Forms.Button buttonCuloareFichsia;
        private System.Windows.Forms.Button buttonCuloarePurple;
        private System.Windows.Forms.Button buttonCuloareR25G255B128;
        private System.Windows.Forms.Button buttonCuloareR192G192B0;
        private System.Windows.Forms.Button buttonCuloareR128G255B128;
        private System.Windows.Forms.Button buttonCuloareR0G64B64;
        private System.Windows.Forms.Button buttonCuloareNegru;
        private System.Windows.Forms.Button buttonCuloareCustom;
        private System.Windows.Forms.GroupBox groupBoxCuloarePersonalizata;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

