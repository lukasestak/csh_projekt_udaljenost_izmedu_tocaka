namespace udaljenosttocka._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void class12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textkorx1.Text = button1.Location.ToString();
            textkorx2.Text = button2.Location.ToString();
            
            double x1, x2, y1, y2;

            x1 = button1.Location.X;
            x2 = button2.Location.X;
            y1 = button1.Location.Y;
            y2 = button2.Location.Y;
            

            var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));

            textBox1.Text = distance.ToString("0.00");            
        }
    }
}