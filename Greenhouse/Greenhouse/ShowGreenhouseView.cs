using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using Model.Service;
using Presentation;

namespace Greenhouse
{
    public partial class ShowGreenhouseView : Form, IShowGreenhouseView
    {
        private readonly Application _context;
        private readonly ICreateNewPlanService _planSerivce;
        public ShowGreenhouseView(ApplicationContext context, ICreateNewPlanService _planSerivce)
        {
           _planSerivce = _planSerivce;
            InitializeComponent();
        }

        public event Action AddDevice;
        public event Action DeleteDevice;
        public event Action ChoiseDevice;
        public event Action BackToMainWindow;


        private void textBox1_TextChanged(object sender, EventArgs e)  //текст выберите устройство
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)//панель теплицы
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) //текст отображение теплицы
        {

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
            BackToMainWindow?.Invoke();
            //Form3 newForm = new Form3();
            //newForm.ShowDialog();
        }
        public string PlanName { get => textBox5.Text; set => textBox5.Text = value; }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = true;
            //  textBox5.Text = _planSerivce.CreateNewPlan().FirstOrDefault();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)     //освещение
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)    //обогреватель
        {

        }

        private void button3_Click_2(object sender, EventArgs e)      //кондиционер
        {

        }

        private void button5_Click_2(object sender, EventArgs e)     //увлажнитель
        {

        }

        private void button6_Click_1(object sender, EventArgs e)   //дозатор удобрений
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}
