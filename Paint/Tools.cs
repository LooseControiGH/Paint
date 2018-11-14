using System.Drawing;

namespace Paint
{
    class Tools
    {

        private int _x1, _x2, _y1, _y2;//переменные для записи координат течек 
        private Bitmap _bitmap;//создание обьекта для рисования
        private Pen _pbrash;//создание карандаша для рисования
        private SolidBrush _sbrush;//созданиезаливки для рисования

        public Tools()
        {
            _bitmap = new Bitmap(630, 418);//задание обьекта для рисования(ширина, высота)
            _pbrash = new Pen(Color.Black);//задание цвета карандашу
            _sbrush = new SolidBrush(Color.Black);//задание цвета заливке
        }

       
        public int Size { get; set; }//свойство  для задание и получения размера карандаша
        public int Count { get; set; }//свойство  для подсчета количества нажатий
        public string FlagName { get; set; }//свойство определения фигуры для рисования

        public int PositionX1//свойство  для получение координаты х при для первой точке
        {
            get
            {
                return _x1;
            }
            set
            {
                _x1 = value;
            }
        }

        public int PositionY1//свойство  для получение координаты Y при для первой точке
        {
            get
            {
                return _y1;
            }
            set
            {
                _y1 = value;
            }
        }

        public int PositionX2//свойство  для получение координаты X при для второй точке
        {
            get
            {
                return _x2;
            }
            set
            {
                _x2 = value;
            }
        }

        public int PositionY2//свойство  для получение координаты Y при для  второй точке
        {
            get
            {
                return _y2;
            }
            set
            {
                _y2 = value;
            }
        }

        public Pen Bbrush
        {
            get
            {
                return _pbrash;
            }
            set
            {
                _pbrash = value;
            }
        }

        public Bitmap bmp//свойство  для получение и задания полотна для рисования 
        {
            get
            {

                return _bitmap;
            }
            set
            {
                _bitmap = value;
            }
        }

        public SolidBrush Sbrush//свойство  для получение и задания заливки
        {
            get
            {
                return _sbrush;
            }
            set
            {
                _sbrush = value;
            }
        }

        public void ExchangeX(int first, int second)//метод для задания правелных  координат точек
        {
            _x1 = second;
            _x2 = first;
        }

        public void ExchangeY(int first, int second)//метод для задания правелных  координат точек
        {
            _y1 = second;
            _y2 = first;
        }

        public void ExchangeXY(int first, int second)//метод для задания правелных  координат точек
        {
            _x2 = _x1;
            _y2 = _y1;
            _x1 = first;
            _y1 = second;

        }

    }
}
