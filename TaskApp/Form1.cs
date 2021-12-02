using DAL.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void populate_lvFizzBuzz()
        {
            string items = "";
            for (int i = 1; i <= 100; i++)
                items += FizzBuzzer.GetValues(i) + "\r\n";

           txtFizzBuzz.Text=items;
        }

        private void btnPlayFizzBuzz_Click(object sender, EventArgs e)
        {
            populate_lvFizzBuzz();
        }
    }
}
