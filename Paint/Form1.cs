using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {


        Tools _tools;//экземпляр класса Tools (инструментя для отрисовки изображения)
        ImageOL _colorinversion = new ImageOL();//экземпляр класса ImageOL (содержит делегат )
        ToolStripButton cLoadimage, cSaveimage; //экземпляр класса ToolStripButton (пункты меню)
        Graphics grpx;//экземпляр класса Graphics rjnjhsq предоставляет методы для рисования объектов
        public Form1()
        {


            InitializeComponent();
            // задание палитры цветов 
            //{
            red.BackColor = Color.Red;
            orange.BackColor = Color.Orange;
            yellow.BackColor = Color.Yellow;
            green.BackColor = Color.Green;
            blue.BackColor = Color.Blue;
            purple.BackColor = Color.Purple;
            black.BackColor = Color.Black;
            white.BackColor = Color.White;
            brown.BackColor = Color.Brown;
            //}

            labelsize.Text = "1px";//отображени текущей толщины  кисти
            timer1.Interval = 1;// установка интервала таймеру. Для более точной отрисовки точки.
            line.Enabled = false;//установка фигуры по умолчанию (линия)


            _tools = new Tools();
            _tools.FlagName = "line";//установка фигуры по умолчанию (линия)
            _tools.Count = 0;//установка счетчика нажатий на 0.

            grpx = Graphics.FromImage(_tools.bmp);
            picture.Image = _tools.bmp;

            //создание пунктов меню
            cSaveimage = new ToolStripButton();
            cLoadimage = new ToolStripButton();
            cSaveimage.Text = "Сохранить";//задание имени пункту меню
            cLoadimage.Text = "Открыть";//задание имени пункту меню
            menu.Items.Add(cLoadimage);//добавление пункта меню на к
            menu.Items.Add(cSaveimage);//задание имени пункту меню

            //создание обработчика событий для меню(Открыть,Сохранить)
            cLoadimage.Click += LoadImage;
            cSaveimage.Click += SaveImage;
        }



        private void draw()//Метод отрисовки фигур
        {
            //счетчик для определения количества нажатий (максимум 2)
            _tools.Count++;
            switch (_tools.FlagName)//проверка на выбранную фигуру
            {

                case "line"://выбрана линия

                    switch (_tools.Count)
                    {

                        case 1://получение координат первой точки
                            var pb = this.PointToClient(Cursor.Position);
                            _tools.PositionX1 = pb.X - 13;
                            _tools.PositionY1 = pb.Y - 28;
                            break;
                        case 2://получение координат второй точки
                            var pb2 = this.PointToClient(Cursor.Position);
                            _tools.PositionX2 = pb2.X - 13;
                            _tools.PositionY2 = pb2.Y - 28;
                            grpx.DrawLine(_tools.Bbrush, _tools.PositionX2, _tools.PositionY2, _tools.PositionX1, _tools.PositionY1); //отрисовка линии
                            picture.Image = _tools.bmp;

                            _tools.Count = 0; // установка счетчика в 0 для коректности определения количества нажатий
                            break;
                        default:
                            break;
                    }
                    break;

                case "rectangle"://выбран прямоуголник

                    switch (_tools.Count)
                    {
                        case 1://получение координат  первой точки
                            var pb = this.PointToClient(Cursor.Position);
                            _tools.PositionX1 = pb.X - 13;
                            _tools.PositionY1 = pb.Y - 28;
                            break;
                        case 2: //получение координат второй точки
                            var pb2 = this.PointToClient(Cursor.Position);
                            _tools.PositionX2 = pb2.X - 13;
                            _tools.PositionY2 = pb2.Y - 28;
                            //блок схема if-else предназначена для коректной отрисовки фигуры (круг)
                            if (_tools.PositionX1 > _tools.PositionX2 && _tools.PositionY1 > _tools.PositionY2)
                            {
                                _tools.ExchangeXY(_tools.PositionX2, _tools.PositionY2);
                            }
                            else if (_tools.PositionX1 > _tools.PositionX2)
                            {
                                _tools.ExchangeX(_tools.PositionX1, _tools.PositionX2);
                            }
                            else if (_tools.PositionY1 > _tools.PositionY2)
                            {
                                _tools.ExchangeY(_tools.PositionY1, _tools.PositionY2);
                            }
                            else { }
                            //отрисовка прямоуголника
                            grpx.FillRectangle(_tools.Sbrush, _tools.PositionX1, _tools.PositionY1, System.Math.Abs(_tools.PositionX2 - _tools.PositionX1), System.Math.Abs(_tools.PositionY2 - _tools.PositionY1));
                            picture.Image = _tools.bmp;
                            _tools.Count = 0;// установка счетчика в 0 для коректности определения количества нажатий
                            break;
                        default:
                            break;
                    }
                    break;

                case "ellipse"://выбран  круг
                    switch (_tools.Count)
                    {
                        case 1://получение координат  первой точки
                            var pb = this.PointToClient(Cursor.Position);
                            _tools.PositionX1 = pb.X - 13;
                            _tools.PositionY1 = pb.Y - 28;
                            break;
                        case 2: //получение координат второй точки
                            var pb2 = this.PointToClient(Cursor.Position);
                            _tools.PositionX2 = pb2.X - 13;
                            _tools.PositionY2 = pb2.Y - 28;

                            //блок схема if-else предназначена для коректной отрисовки фигуры (круг)
                            if (_tools.PositionX1 > _tools.PositionX2 && _tools.PositionY1 > _tools.PositionY2)
                            {
                                _tools.ExchangeXY(_tools.PositionX2, _tools.PositionY2);
                            }
                            else if (_tools.PositionX1 > _tools.PositionX2)
                            {
                                _tools.ExchangeX(_tools.PositionX1, _tools.PositionX2);
                            }
                            else if (_tools.PositionY1 > _tools.PositionY2)
                            {
                                _tools.ExchangeY(_tools.PositionY1, _tools.PositionY2);
                            }
                            else { }
                            //отрисовка круга
                            grpx.FillEllipse(_tools.Sbrush, _tools.PositionX1, _tools.PositionY1, System.Math.Abs(_tools.PositionX2 - _tools.PositionX1), System.Math.Abs(_tools.PositionY2 - _tools.PositionY1));
                            picture.Image = _tools.bmp;
                            _tools.Count = 0;// установка счетчика в 0 для коректности определения количества нажатий
                            break;
                        default:

                            break;
                    }

                    break;
            }
        }

        //обработчик событий при нажатии на область рисования(PictureBox)
        private void picture_Click(object sender, EventArgs e)
        {
            draw(); //отрисовка фигур
        }
        //обработчик событий при  выборе прямоуголника (кнопка rectangle)
        private void rect_Click(object sender, EventArgs e)
        {
            _tools.FlagName = rectangle.Name;//получение  имени фигуры для правельной отрисовки фигуры(прямоуголник)
            rectangle.Enabled = false;//отключение кнопки для отображения выбраной фигуры (прямоуголник)
            ellipse.Enabled = true;//включение кнопки для возможности выбора фигуры (круг)
            line.Enabled = true;//включение кнопки для возможности выбора фигуры (линия)
            dot.Enabled = true;//включение кнопки для возможности выбора фигуры (точка)
        }
        //обработчик событий при выборе линии (кнопка line)
        private void line_Click(object sender, EventArgs e)
        {
            _tools.FlagName = line.Name;//получение  имени фигуры для правельной отрисовки фигуры(линия)
            line.Enabled = false;//отключение кнопки для отображения выбраной фигуры (линия)
            ellipse.Enabled = true;//включение кнопки для возможности выбора фигуры (круг)
            rectangle.Enabled = true;//включение кнопки для возможности выбора фигуры (прямоуголник)
            dot.Enabled = true;//включение кнопки для возможности выбора фигуры (точка)
        }
        //обработчик событий при выборе круга (кнопка ellipse)
        private void ellipse_Click(object sender, EventArgs e)
        {

            _tools.FlagName = ellipse.Name;//получение  имени фигуры для правельной отрисовки фигуры(круг)
            ellipse.Enabled = false;//отключение кнопки для отображения выбраной фигуры (круг)
            line.Enabled = true;//включение кнопки для возможности выбора фигуры (линия)
            rectangle.Enabled = true;//включение кнопки для возможности выбора фигуры (прямоуголник)
            dot.Enabled = true;//включение кнопки для возможности выбора фигуры (точка)
        }

        // обработчик событий при открытии документа(кнопка открыть)
        public void LoadImage(object sender, EventArgs e)
        {
            //задание фильтра документов
            openFileDialog1.Filter = "Image Files (*.bmp, *.jpg)|*.bmp;*.jpg;*.png";//фильтр для формата изображений
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)//проверка на корректноть открытия диалогового  окна
                    using (System.IO.FileStream fl = new System.IO.FileStream(openFileDialog1.FileName, System.IO.FileMode.Open))//считывание файла в файловый поток
                    {

                        Image img = Image.FromStream(fl);
                        _tools.bmp = (Bitmap)img;
                        grpx = Graphics.FromImage(img);
                        picture.Image = _tools.bmp;//отображение загруженного  изображения

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // обработчик событий при сокранении документа(кнопка сохранить)
        public void SaveImage(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)//проверка на корректноть открытия диалогового  окна
                    _tools.bmp.Save(saveDialog.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);//формирование имени и сохранение документа

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //обработчик событий при нажатие на кнопу Инвертирование (кнопка button1)
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = _tools.bmp.Width;//утсановка максимального значения progressBar. Максимальное значение берется из нирины изображения
            Thread foregroundthread = new Thread(new ThreadStart(thread));//создание потока
            foregroundthread.IsBackground = true;// установка в потока в фоноый поток
            foregroundthread.Start();//запуск потока
        }
        //обработчик собития таймера (timer1)
        //таймер для отрисовки произволніх  линий
        private void timer1_Tick(object sender, EventArgs e)
        {
            var pb = this.PointToClient(Cursor.Position);//получение позиции курсора 
            _tools.PositionX1 = pb.X - 13;
            _tools.PositionY1 = pb.Y - 28;
            grpx.FillRectangle(_tools.Sbrush, _tools.PositionX1, _tools.PositionY1, _tools.Size, _tools.Size);//отрисовка  точек
            picture.Image = _tools.bmp;
        }

        //метод для потока
        private void thread()
        {
            _colorinversion.del(picture, _tools.bmp, progressBar1);//передача параметров делегату
        }
        //обработчик событий при выборе цвета (кнопка red)
        private void red_Click(object sender, EventArgs e)
        {

            _tools.Bbrush.Color = Color.Red;//задание красного цвета карандашу 
            _tools.Sbrush.Color = Color.Red;//задание красного цвета заливке 
        }
        //обработчик событий при выборе цвета (кнопка orange)
        private void orange_Click(object sender, EventArgs e)
        {
            _tools.Bbrush.Color = Color.Orange;//задание оранжевого цвета карандашу 
            _tools.Sbrush.Color = Color.Orange;//задание оранжевого цвета заливке 
        }
        //обработчик событий при выборе цвета (кнопка yellow)
        private void yellow_Click(object sender, EventArgs e)
        {
            _tools.Bbrush.Color = Color.Yellow;//задание желтого цвета карандашу 
            _tools.Sbrush.Color = Color.Yellow;//задание желтого цвета заливке 
        }
        //обработчик событий при выборе цвета (кнопка green)
        private void green_Click(object sender, EventArgs e)
        {
            _tools.Bbrush.Color = Color.Green;//задание зеленого цвета карандашу 
            _tools.Sbrush.Color = Color.Green;//задание зеленого цвета заливке 
        }
        //обработчик событий при выборе цвета (кнопка blue)
        private void blue_Click(object sender, EventArgs e)
        {
            _tools.Bbrush.Color = Color.Blue;//задание синего цвета карандашу 
            _tools.Sbrush.Color = Color.Blue;//задание синего цвета заливке 
        }
        //обработчик событий при выборе цвета (кнопка purple)
        private void purple_Click(object sender, EventArgs e)
        {
            _tools.Bbrush.Color = Color.Purple;//задание пурпурного цвета карандашу 
            _tools.Sbrush.Color = Color.Purple;//задание пурпурного цвета заливке 
        }
        //обработчик событий при выборе цвета (кнопка black)
        private void black_Click(object sender, EventArgs e)
        {
            _tools.Bbrush.Color = Color.Black;//задание черного цвета карандашу 
            _tools.Sbrush.Color = Color.Black;//задание черного цвета заливке
        }
        //обработчик событий при выборе цвета (кнопка brown)
        private void brown_Click(object sender, EventArgs e)
        {
            _tools.Bbrush.Color = Color.Brown;//задание коричневого цвета карандашу 
            _tools.Sbrush.Color = Color.Brown;//задание коричневого цвета заливке
        }
        //обработчик событий при выборе цвета (кнопка white)
        private void white_Click(object sender, EventArgs e)
        {
            _tools.Bbrush.Color = Color.White;//задание белого цвета карандашу 
            _tools.Sbrush.Color = Color.White;//задание белого цвета заливке 
        }
        //обработчик событий при произвольном рисовании
        // старт отрисовки точек при нажатой кнопке мыши
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (dot.Enabled == false)//проверка на вібраную  фигуру (точки)
                timer1.Enabled = true;// включении таймера 
        }
        //обработчик событий при произвольном рисовании
        //отсановка рисования при отаускании кнопке мыши
        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;//отключение таймера
        }
        //обработчик событий при выборе произволном рисовании (кнопка "dot")
        private void dot_Click(object sender, EventArgs e)
        {
            dot.Enabled = false;
            ellipse.Enabled = true;//включени выбора фигуры для рисования круга(кнопка "ellipse")
            line.Enabled = true;//включени выбора фигуры для рисования круга(кнопка "line")
            rectangle.Enabled = true;//включени выбора фигуры для рисования круга(кнопка "rectangle")
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {

        }
        //обработчик событий при задании толщины кисти  (элемент trackBar1)
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _tools.Size = trackBar1.Value;//задание размера 
            labelsize.Text = trackBar1.Value.ToString() + "px";//отображение толшины кисти (элемент "labelsize" )
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
