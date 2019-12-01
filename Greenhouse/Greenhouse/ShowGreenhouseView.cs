using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Presentation;

namespace Greenhouse
{
    public partial class ShowGreenhouseView : Form, IShowGreenhouseView
    {
        private readonly Application _context;
        public ShowGreenhouseView(ApplicationContext context)
        {
            InitializeComponent();
        }

        public event Action AddDevice;
        public event Action DeleteDevice;
        public event Action ChoiseDevice;
        public event Action ChangePlan;


        private void textBox1_TextChanged(object sender, EventArgs e)  //текст выберите устройство
        {

        }

        private void button1_Click(object sender, EventArgs e) //кнопка добавить устройство
        {

            AddDevice?.Invoke();
            //if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedIndex == 8)
            //{
            //    MessageBox.Show("Ошибка: устройство не выбрано.");
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)  //выпадающий список
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)//панель теплицы
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //текст отображение теплицы
        {

        }

        private void button2_Click(object sender, EventArgs e)  //кнопка удалить устройство
        {
            DeleteDevice?.Invoke();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePlan?.Invoke();
            //Form3 newForm = new Form3();
            //newForm.ShowDialog();
        }
    }
}
