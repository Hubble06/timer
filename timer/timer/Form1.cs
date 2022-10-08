namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour = 0;
        int min = 0;
        int sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (sec == 59)
            {
                min = min + 1;
                sec = 0;
            }
            else
            {
                sec = sec + 1;
            }
            if (min == 59)
            {
                hour = hour + 1;
                min = 0;
            }
           
            cho.Text = sec.ToString("00");
            boon.Text = min.ToString("00");
            si.Text = hour.ToString("00");
        }

        private void starter(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void stoper_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            hour = 0;
            min = 0;
            sec = 0;

            cho.Text = sec.ToString("00");
            boon.Text = min.ToString("00");
            si.Text = hour.ToString("00");
        }
    }
}