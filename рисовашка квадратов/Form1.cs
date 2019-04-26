//Автор Дамир Алмаев Маратович
//библиотеки
using System;//библиотека
using System.Collections.Generic;//библиотека
using System.ComponentModel;//библиотека
using System.Data;//библиотека
using System.Drawing;//библиотека
using System.Linq;//библиотека
using System.Text;//библиотека
using System.Threading.Tasks;//библиотека
using System.Windows.Forms;//библиотека
//Автор Дамир Алмаев Маратович
namespace рисовашка_квадратов//Как называется прога
{
    public partial class Form1 : Form// В какой форме работаем
    {
        //Автор Дамир Алмаев Маратович
        //переменные
        //Автор Дамир Алмаев Маратович
        public static int x, y, a = 0;//для коридинатов
        //Автор Дамир Алмаев Маратович
        private void pictureBox1_Paint(object sender, PaintEventArgs e)//для рисования
        {
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x, y, x, y + a);//рисуем
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x, y, x + a, y);//рисуем
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x + a, y, x + a, y + a);//рисуем
            e.Graphics.DrawLine(System.Drawing.Pens.Red, x, y + a, x + a, y + a);//рисуем
        }
        //Автор Дамир Алмаев Маратович
        private void Form1_Load(object sender, EventArgs e)//При загруски формы
        {
            //для разрабов
            //автоматическое вбивание
            /*
            textBox1.Text = "12";
            textBox2.Text = "12";
            textBox3.Text = "120";
            */
        }
        //Автор Дамир Алмаев Маратович
        private void button1_Click(object sender, EventArgs e)//При нажатие кнопки рисуем
        {
            try//Попытка
            {
                x = Convert.ToInt32(textBox1.Text);//Водим инфу
                y = Convert.ToInt32(textBox2.Text);//Водим инфу
                a = Convert.ToInt32(textBox3.Text);//Водим инфу
                pictureBox1.Refresh();//Перисование
            }
            catch//Ошибка
            {
                DialogResult lol = MessageBox.Show("Error: Ошибка инфы", this.Text, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);//Выводим сообщение о ошибки
                if (lol == DialogResult.Retry)//Если нажата кнопка Повторить, то
                {
                    try//Попытка
                    {
                        x = Convert.ToInt32(textBox1.Text);//Водим инфу
                        y = Convert.ToInt32(textBox2.Text);//Водим инфу
                        a = Convert.ToInt32(textBox3.Text);//Водим инфу
                    }
                    catch//Ошибка
                    {
                        button1.PerformClick();//Нажимаем на кнопку (автомат)
                    }
                }
            }
        }
        //Автор Дамир Алмаев Маратович
        public Form1()//Загружаем форму
        {
            InitializeComponent();//Загружаем форму
        }
    }
}
//Автор Дамир Алмаев Маратович
//Конец