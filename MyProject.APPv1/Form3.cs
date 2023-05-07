using Myprojec.MODEL;
using MyProject.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MyProject.APPv1
{
    public partial class Form3 : Form
    {
        Thread nt;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
            nt = new Thread(Formnovo4);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Formnovo4()
        {
            Application.Run(new Form4());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            nt = new Thread(Formnovo2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
        private void Formnovo2()
        {
            Application.Run(new Form2());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int check = 0;
            if (radioButton1.Checked == true)
            { check = 1; }
            else if (radioButton2.Checked == true)
            { check = 2; }
            else if (radioButton3.Checked == true)
            { check = 3; }

            MessageBox.Show(check.ToString());
            Projeto projeto = new Projeto(textBox1.Text, textBox2.Text, dateTimePicker1.Value, dateTimePicker2.Value, textBox6.Text, check);
            ProjetoRepository.Update(projeto);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

