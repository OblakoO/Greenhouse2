using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Greenhouse
{
    public partial class window : Form
    {
        

        public window()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)  //кнопка создать новый план
        {
            Form3 newForm = new Form3();
            newForm.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   //выпадающий список
        {
            
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //кнопка стартовать цикл
        {
            if (listsPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Ошибка: выберите план.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)   //кнопка отобразить теплицу
        {
            Form2 newForm = new Form2();
            //newForm.Show();
            newForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)  //текущее время
        {

        }

        private void button4_Click(object sender, EventArgs e)  //пуск
        {

        }

        private void button3_Click(object sender, EventArgs e) //пауза
        {

        }

        private void button5_Click(object sender, EventArgs e) // х2
        {

        }
        
    }
}
