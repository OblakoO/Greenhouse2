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
    public partial class MainWindowView : Form, IMainWindowView
    {
        private readonly Application _context;
        public MainWindowView(ApplicationContext context)
        {
          //  _context = context;
            InitializeComponent();
        }

        public event Action CreateNewPlan;
        public event Action ShowGreenhouse;
        public event Action StartCycle;
        public event Action ChoisePlan;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void ShowError(string message)
        {
            //lbl_Error.Text = message;
        }
        private void button1_Click(object sender, EventArgs e)  //кнопка создать новый план
        {
            CreateNewPlan?.Invoke();
            
            // Form3 newForm = new Form3();
            //newForm.ShowDialog();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)   //выпадающий список
        {
            
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  //кнопка стартовать цикл
        {
            //прописать ошибку
            //lbl_Error.Text = "";
            ShowGreenhouse?.Invoke();

            //if (listsPlan.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Ошибка: выберите план.");
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)   //кнопка отобразить теплицу
        {
            ShowGreenhouse?.Invoke();
            //ShowGreenhouseView newForm = new ShowGreenhouseView();
            //newForm.ShowDialog();
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


        public new void Show()
        {
            //_context.MainForm = this;
            base.Show();

        }
        
    }
}
