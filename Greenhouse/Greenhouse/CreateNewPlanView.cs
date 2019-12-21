using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model.Service;
using Presentation;

namespace Greenhouse
{
    public partial class Form3 : Form, ICreateNewPlanView
    {
        private readonly Application _context;
        private readonly CreateNewPlanService _planSerivce;

        public Form3(ApplicationContext context/*,CreateNewPlanService planSerivce */)
        {
            InitializeComponent();
           // _planSerivce = planSerivce;
            
        }
   
        public event Action StartCycle;
        public event Action BackToMainWindow;

        public string Cultur => textBox4.Text;
        public string NamePlan => textBox3.Text;
        public string Stage => dataGridView1.Text;
        public string Hours => dataGridView1.Text;
        public string Temperature => dataGridView1.Text;
        public string Humidity => dataGridView1.Text;
        public string Light => dataGridView1.Text;
        public string Acidity => dataGridView1.Text;

       // int ICreateNewPlanView.Stage => throw new NotImplementedException();

        //int ICreateNewPlanView.Hours => throw new NotImplementedException();

        //int ICreateNewPlanView.Temperature => throw new NotImplementedException();

        //int ICreateNewPlanView.Humidity => throw new NotImplementedException();

        //int ICreateNewPlanView.Light => throw new NotImplementedException();

       // int ICreateNewPlanView.Acidity => throw new NotImplementedException();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)   //начать выращивание
        {
            
            int count = 0;
            for (int i = 0; i < 11; i++)
                for (int j = 0; j < 6; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value == null)
                        count++;

            if (textBox4.Text != "" && textBox3.Text != ""&&count==0)
            {
                StartCycle?.Invoke();  
            }
            else
            {
                MessageBox.Show("Не заполнены поля.");
            }


            // MessageBox.Show("Не заполнены поля в таблице.");
        }

        public void ShowError(string message)
        {
            lbl_Error.Text = message;
        }

        private void button4_Click(object sender, EventArgs e)   //кнопка вернуться на главную
        {
            BackToMainWindow?.Invoke();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        public new void Show()
        {
            //_context.MainForm = this;
            ShowError(string.Empty);
            base.Show();

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)   //окошко название плана
        {
            //MyClass.strTextChangeN = textBox3.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)    //табличка
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            //var cultureNameBox = (TextBox)sender;
           
           // _planSerivce.CreateNewPlan(cultureNameBox.Text, null);
        }
    }
}