namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelsize = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.dot = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.ellipse = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.brown = new System.Windows.Forms.Button();
            this.black = new System.Windows.Forms.Button();
            this.purple = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.picture);
            this.panel1.Location = new System.Drawing.Point(13, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 418);
            this.panel1.TabIndex = 0;
            // 
            // picture
            // 
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(630, 418);
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.picture_Click);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.labelsize);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.dot);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.ellipse);
            this.panel2.Controls.Add(this.line);
            this.panel2.Controls.Add(this.rectangle);
            this.panel2.Controls.Add(this.white);
            this.panel2.Controls.Add(this.brown);
            this.panel2.Controls.Add(this.black);
            this.panel2.Controls.Add(this.purple);
            this.panel2.Controls.Add(this.blue);
            this.panel2.Controls.Add(this.green);
            this.panel2.Controls.Add(this.yellow);
            this.panel2.Controls.Add(this.orange);
            this.panel2.Controls.Add(this.red);
            this.panel2.Location = new System.Drawing.Point(649, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 418);
            this.panel2.TabIndex = 1;
            // 
            // labelsize
            // 
            this.labelsize.AutoSize = true;
            this.labelsize.Location = new System.Drawing.Point(34, 153);
            this.labelsize.Name = "labelsize";
            this.labelsize.Size = new System.Drawing.Size(45, 13);
            this.labelsize.TabIndex = 16;
            this.labelsize.Text = "размер";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(4, 121);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(4, 172);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(44, 45);
            this.dot.TabIndex = 14;
            this.dot.Text = "*";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(4, 320);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Инвертирование";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ellipse
            // 
            this.ellipse.Location = new System.Drawing.Point(60, 172);
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(45, 45);
            this.ellipse.TabIndex = 11;
            this.ellipse.Text = "Ellipse";
            this.ellipse.UseVisualStyleBackColor = true;
            this.ellipse.Click += new System.EventHandler(this.ellipse_Click);
            // 
            // line
            // 
            this.line.Location = new System.Drawing.Point(3, 223);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(45, 45);
            this.line.TabIndex = 10;
            this.line.Text = "line";
            this.line.UseVisualStyleBackColor = true;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // rectangle
            // 
            this.rectangle.Location = new System.Drawing.Point(60, 224);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(45, 45);
            this.rectangle.TabIndex = 9;
            this.rectangle.Text = "Rectangle";
            this.rectangle.UseVisualStyleBackColor = true;
            this.rectangle.Click += new System.EventHandler(this.rect_Click);
            // 
            // white
            // 
            this.white.Location = new System.Drawing.Point(75, 84);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(30, 30);
            this.white.TabIndex = 8;
            this.white.UseVisualStyleBackColor = true;
            this.white.Click += new System.EventHandler(this.white_Click);
            // 
            // brown
            // 
            this.brown.Location = new System.Drawing.Point(39, 84);
            this.brown.Name = "brown";
            this.brown.Size = new System.Drawing.Size(30, 30);
            this.brown.TabIndex = 7;
            this.brown.UseVisualStyleBackColor = true;
            this.brown.Click += new System.EventHandler(this.brown_Click);
            // 
            // black
            // 
            this.black.Location = new System.Drawing.Point(3, 84);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(30, 30);
            this.black.TabIndex = 6;
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // purple
            // 
            this.purple.Location = new System.Drawing.Point(75, 48);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(30, 30);
            this.purple.TabIndex = 5;
            this.purple.UseVisualStyleBackColor = true;
            this.purple.Click += new System.EventHandler(this.purple_Click);
            // 
            // blue
            // 
            this.blue.Location = new System.Drawing.Point(39, 48);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(30, 30);
            this.blue.TabIndex = 4;
            this.blue.UseVisualStyleBackColor = true;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(3, 48);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(30, 30);
            this.green.TabIndex = 3;
            this.green.UseVisualStyleBackColor = true;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // yellow
            // 
            this.yellow.Location = new System.Drawing.Point(75, 12);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(30, 30);
            this.yellow.TabIndex = 2;
            this.yellow.UseVisualStyleBackColor = true;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // orange
            // 
            this.orange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orange.Location = new System.Drawing.Point(39, 12);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(30, 30);
            this.orange.TabIndex = 1;
            this.orange.UseVisualStyleBackColor = true;
            this.orange.Click += new System.EventHandler(this.orange_Click);
            // 
            // red
            // 
            this.red.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.red.Location = new System.Drawing.Point(3, 12);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(30, 30);
            this.red.TabIndex = 0;
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(766, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button white;
        private System.Windows.Forms.Button brown;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button purple;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button ellipse;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Label labelsize;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

