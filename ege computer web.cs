namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 100;

            if (mrkCasper.Checked) tabanFiyat = 500;
            if (mrkAcer.Checked) tabanFiyat = 800;
            if (mrkApple.Checked) tabanFiyat = 2000;
            if (mrkBelinea.Checked) tabanFiyat = 100;
            if (mrkSamsung.Checked) tabanFiyat = 600;

            decimal cpuFiyat = 0;
            if (rbCpuI7.Checked)
                cpuFiyat = 300;
            else if (rbCpuI5.Checked)
                cpuFiyat = 200;
            else if (rbCpuI3.Checked)
                cpuFiyat = 100;
            else if (rbCpuR5.Checked)
                cpuFiyat = 250;
            else if (rbCpuR3.Checked)
                cpuFiyat = 150;

            tabanFiyat += cpuFiyat;
            decimal ramFiyat = 0;
            
            if (rbRam16.Checked)
                ramFiyat = 125;
            else if (rbRam8.Checked)
                ramFiyat = 75;
            else if (rbRam4.Checked)
                ramFiyat = 45;
            tabanFiyat += ramFiyat;

            MessageBox.Show(string.Format("Toplam Fiyat ={ 0:C}", tabanFiyat));
        }
    }
}