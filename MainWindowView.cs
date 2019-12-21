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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)  //кнопка создать новый план
        {
            CreateNewPlan?.Invoke();
        }

        public new void Show()
        {
            base.Show();

        }
        
    }
}
