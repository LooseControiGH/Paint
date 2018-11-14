using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
namespace Paint
{
    public delegate void delrevers( PictureBox _pictorebox, Bitmap _bitmap, ProgressBar _progressbar);// создание делегата для потока
    class ImageOL
    {

        public delrevers del; // обьявление экземпляра делегата
        public ImageOL()
        {
            del = new delrevers(revers);//присвоение метода revers делегату
        }

        private void revers(PictureBox _pictorebox, Bitmap _bitmap, ProgressBar _progressbar)// метод в отдельном потоке для ниверсирования изображения
        {
            try
            {
                if (_progressbar.InvokeRequired)//определяет нужно ли использовать  Invoke 
                    _progressbar.Invoke(new Action<int>((z) => _progressbar.Maximum = _bitmap.Width), _bitmap.Width);// вызов Invoke для вызова методя из другого потока. Получение максимального значени для progressbar
                else { _progressbar.Maximum = _bitmap.Width; }

                for (int x = 0; x <= _bitmap.Width - 1; x++)
                {
                    for (int y = 0; y <= _bitmap.Height - 1; y += 1)
                    {
                        //получение старого цвета
                        Color oldColor = _bitmap.GetPixel(x, y);
                        //определяем новый цвет для замены старого
                        Color newColor;
                        //устанавливаем новый цвет
                        newColor = Color.FromArgb(oldColor.A, 255 - oldColor.R, 255 - oldColor.G, 255 - oldColor.B);
                        //заменяем старый цвет на новый
                        _bitmap.SetPixel(x, y, newColor);
                    }
                    Thread.Sleep(5);
                    if (_progressbar.InvokeRequired)
                        _progressbar.Invoke(new Action<int>((z) => _progressbar.Value = x), x); // заполнение progressbar
                    else { _progressbar.Value = x; }

                }
                if (_progressbar.InvokeRequired)
                    _progressbar.Invoke(new Action<int>((z) => _progressbar.Value = 0), 0); //установка знчение в 0 
                else { _progressbar.Value = 0; }
                _pictorebox.Image = _bitmap; //отрисовка инверсированого  изображения
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }


}
 