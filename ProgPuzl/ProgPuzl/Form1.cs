using System;

using System.Drawing;
using WMPLib;
using System.Windows.Forms;

namespace ProgPuzl
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        // 4х4 - размер игрового поля
        const int nw = 4, nh = 4;

        // графическая поверхность формы
        Graphics g;

        // картинка
        Bitmap pics;

        // размер (ширина и высота) клетки
        int cw, ch;

        // игровое поле: хранит номера фрагментов
        // картинки
        int[,] field = new int[nw, nh];

        // координаты пустой клетки
        int ex, ey;

        int timersec = 0, timerm=0;

        //  отображения номера фишки
        Boolean showNumb=false;
        public Form1()
        {
            InitializeComponent();
           
            try
            {
                wplayer.URL = "res/muzikfon.mp3";
                wplayer.settings.setMode("loop", true);
                // загружаем файл картинки
                pics = new Bitmap("res/picture.bmp");
                pics = new Bitmap("res/Shrek.bmp");
                pics = new Bitmap("res/Mops.bmp");
                pics = new Bitmap("res/Gomer.bmp");
                pics = new Bitmap("res/Gravity.bmp");
                pics = new Bitmap("res/Futurama.bmp");
                pics = new Bitmap("res/Wither.bmp");
                pics = new Bitmap("res/Garri.bmp");
              
            }
            catch (Exception exc)
            {
                MessageBox.Show("Все файлы не присутствуют.\n",
                    "Собери картинку",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
                return;
            }
            optionpics();
           
            newGame();
            timer1.Stop();
        }
        //устанавливаем значения
        public void optionpics()
        {
            cw = (int)(pics.Width / nw);
            ch = (int)(pics.Height / nh);

            // установить размер клиентской (внутренней) области формы
            ClientSize =
                new Size(cw * nw + 1, ch * nh + 1 + menuStrip1.Height);
            // рабочая графическая поверхность
            g = CreateGraphics();
        }
        //новая игра
        private void newGame()
        { // располагаем фишки в правильном порядке
         
            for (int j = 0; j < nh; j++)
                for (int i = 0; i < nw; i++)
                    field[i, j] = j * nw + i + 1;

            // последняя фишка - пустая
            field[nw - 1, nh - 1] = 0;
            ex = nw - 1; ey = nh - 1;

            mixer();        // перемешиваем фишки
            drawField();    // выводим игровое поле
            timersec = 0;
            timerm = 0;
            labeltimermin.Text = "0";
            timer1.Start();

        }
        // перемешиваем фишки
        private void mixer()
        {
            int d;    // положение (относительно пустой) перемещаемой
                      // клетки: 0 - слева; 1 - справа; 2 - сверху; 3 - снизу.

            int x, y; // координаты клеткы

            // генератор случайных чисел
            Random rnd = new Random();

            for (int i = 0; i < nw * nh * 10; i++)
            // nw * nh * 10 - кол-во перестановок
            {
                x = ex;
                y = ey;

                d = rnd.Next(4);
                switch (d)
                {
                    case 0: if (x > 0) x--; break;
                    case 1: if (x < nw - 1) x++; break;
                    case 2: if (y > 0) y--; break;
                    case 3: if (y < nh - 1) y++; break;
                }
                // здесь определили фишку, которую
                // нужно переместить в пустую клетку
                field[ex, ey] = field[x, y];
                field[x, y] = 0;

                // запоминаем координаты пустой фишки
                ex = x; ey = y;
            }
        }
        // отрисовывает поле
        private void drawField()
        {
            // содержимое клеток
            for (int i = 0; i < nw; i++)
                for (int j = 0; j < nh; j++)
                {
                    if (field[i, j] != 0)
                        // выводим фишку с картинкой:
                        
                        // координаты левого верхнего угла
                        // области файла-источника картинки
                        g.DrawImage(pics,
                            new Rectangle(i * cw, j * ch + menuStrip1.Height, cw, ch),
                            new Rectangle(
                                ((field[i, j] - 1) % nw) * cw,
                                ((field[i, j] - 1) / nw) * ch,
                                cw, ch),
                            GraphicsUnit.Pixel);
                    else
                        // выводим пустую фишку
                        g.FillRectangle(SystemBrushes.Control,
                            i * cw, j * ch + menuStrip1.Height, cw, ch);
                    // рисуем границу
                    g.DrawRectangle(Pens.Black,
                        i * cw, j * ch + menuStrip1.Height, cw, ch);

                    // номер фишки
                    if ((showNumb) && field[i, j] != 0)
                        g.DrawString(Convert.ToString(field[i, j]),
                            new Font("Tahoma", 10, FontStyle.Bold),
                            Brushes.Black, i * cw + 5, j * ch + 5 + menuStrip1.Height);
                }
        }
        // проверяет, расположены ли фишки в правильном порядке
        private Boolean finish()
        {
            // координаты клетки
            int i = 0;
            int j = 0;

            int c;       // число в клетке

            // фишки расположены правильно, если
            
            //   1  2  3  4
            //   5  6  7  8
            //   9 10 11 12
            //  13 14 15

            for (c = 1; c < nw * nh; c++)
            {
                if (field[i, j] != c) return false;

                // к следующей клетке
                if (i < nw - 1) i++;
                else { i = 0; j++; }
            }
            timer1.Stop();
            return true;
        }
        // перемещает фишку, на которой сделан щелчок,
    
        private void move(int cx, int cy)
        {
            // проверим, возможен ли обмен
            if (!(((Math.Abs(cx - ex) == 1) && (cy - ey == 0)) ||
                ((Math.Abs(cy - ey) == 1) && (cx - ex == 0))))
                return;
            // обмен. переместим фишку из (x, y) в (ex, ey)
            field[ex, ey] = field[cx, cy];
            field[cx, cy] = 0;

            ex = cx; ey = cy;

            // отрисовать поле
            drawField();

            if (finish())
            {
                field[nw - 1, nh - 1] = nh * nw;
                drawField();

               
                if (MessageBox.Show("Поздравляю! Ви собрали картинку !\n Ваше время:"+timerm+"м  "+timersec+"с\n" +
                         "Еще раз?", "ProgPuzl",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question)
                          == DialogResult.No)
                    Close();
                else newGame();
            }
        }
        // обработка события Paint
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawField();

        }

        private void ПикачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pics = new Bitmap("res/picture.bmp");
            optionpics();
            newGame();
        }

        private void шрекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pics = new Bitmap("res/Shrek.bmp");
            optionpics();
            newGame();
        }

        private void мопсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pics = new Bitmap("res/Mops.bmp");
            optionpics();
            newGame();
        }

       

        private void поставитьНомеркиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( поставитьНомеркиToolStripMenuItem.Text == "Поставить номерки")
            {
                showNumb = true;
                поставитьНомеркиToolStripMenuItem.Text = "Убрать номера";
                drawField();
                
            }
           else if(поставитьНомеркиToolStripMenuItem.Text == "Убрать номера")
            {
                showNumb = false;
                поставитьНомеркиToolStripMenuItem.Text = "Поставить номерки";
                drawField();
            }
            timer1.Enabled = true;
        }

        private void гомерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pics = new Bitmap("res/Gomer.bmp");
            optionpics();
            newGame();
        }

        private void артЗГаріПотераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pics = new Bitmap("res/Garri.bmp");
            optionpics();
            newGame();
        }

        private void gravityFallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pics = new Bitmap("res/Gravity.bmp");
            optionpics();
            newGame();
        }

        private void futuramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pics = new Bitmap("res/Futurama.bmp");
            optionpics();
            newGame();
        }

        private void witherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pics = new Bitmap("res/Wither.bmp");
            optionpics();
            newGame();
        }

    

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Escape)
            {
                if (MessageBox.Show("Вы точно хотите выйти из самой лучшй игры на планете? \n" 
                          , "????????????",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question)
                           == DialogResult.Yes)
                    Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timersec++;
            if (timersec == 60)
            {
                timerm++;
                labeltimermin.Text = "" + timerm+" м";
                timersec = 0;
            }
            labeltimersec.Text = "" + timersec+" c";
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            // щелчок кнопкой мыши на игровом поле
            // преобразуем координаты мыши в координаты клетки
            move(e.X / cw, (e.Y - menuStrip1.Height) / ch);
        }

        private void оПрограмеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Прога v1.0 \n Автор Богдан\n  Спасиба что играете игру",
                      "ProgPuzl",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newGame();
            timer1.Enabled = true;
        }
    }
}
