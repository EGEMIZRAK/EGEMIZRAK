using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Queue kuyruk = new Queue();
        int sira = 0;

        private void btnSiraAl_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            listeSiralar();
        }

        private void btnSiraÇikart_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            listeSiralar();
        }

        private void listeSiralar_SelectedIndexChanged(object sender, EventArgs e)
        {
            listeSiralar.Items.Clear();
            foreach (int sira in kuyruk)
            {
                listeSiralar.Items.Add(sira);
            }
        }
    }
}
