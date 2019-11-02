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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)   //начать выращивание
        {
            if (maskedTextBox2.Text == ""
                || maskedTextBox1.Text == "" 
                || maskedTextBox3.Text == ""
                || maskedTextBox4.Text == "" 
                || comboBox1.SelectedIndex == -1 
                || comboBox2.SelectedIndex == -1
                || comboBox3.SelectedIndex == -1
                || listsPlan.SelectedIndex==-1)
            {
                MessageBox.Show("Ошибка: заполнены не все поля.");
            }
            else
            {
                Form2 f = new Form2();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)   //кнопка вернуться на главную
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listsPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
