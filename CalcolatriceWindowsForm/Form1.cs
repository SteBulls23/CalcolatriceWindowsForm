namespace CalcolatriceWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double n1, n2, r;
        
        string operazione = string.Empty;
        private void Zerobtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "0";
        }
        private void Unobtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "1";
        }

        private void Duebtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "2";
        }

        private void Trebtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "3";
        }

        private void Quattrobtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "4";
        }

        private void Cinquebtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "5";
        }

        private void Seibtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "6";
        }

        private void Settebtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "7";
        }

        private void Ottobtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "8";
        }

        private void Novebtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + "9";
        }

        private void Puntobtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Text = Operazionetxt.Text + ",";
        }

        private void Sommabtn_Click(object sender, EventArgs e)
        {
            operazione = "+";
            n1 = double.Parse(Operazionetxt.Text);
            Operazionetxt.Clear();
        }

        private void Sottrazionebtn_Click(object sender, EventArgs e)
        {
            operazione = "-";
            n1 = double.Parse(Operazionetxt.Text);
            Operazionetxt.Clear();
        }

        private void Moltiplicazionebtn_Click(object sender, EventArgs e)
        {
            operazione = "*";
            n1 = double.Parse(Operazionetxt.Text);
            Operazionetxt.Clear();
        }

        private void Divisionebtn_Click(object sender, EventArgs e)
        {
            operazione = "/";
            n1 = double.Parse(Operazionetxt.Text);
            Operazionetxt.Clear();
        }

        private void Ugualebtn_Click(object sender, EventArgs e)
        {
            n2 = double.Parse(Operazionetxt.Text);

            if (operazione.Equals("+"))
            {
                r = n1 + n2;
            }

            if (operazione.Equals("-"))
            {
                r = n1 - n2;
            }

            if (operazione.Equals("*"))
            {
                r = n1 * n2;
            }

            if (operazione.Equals("/"))
            {
                r = n1 / n2;
            }
            
            Operazionetxt.Text = r + "";
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Operazionetxt.Clear();
            n1 = 0;
            n2 = 0;
            r = 0;
        }
    }
}
