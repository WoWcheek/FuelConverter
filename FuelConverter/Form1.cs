namespace FuelConverter
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double distans = 0, ordinary = 0, price = 0;

            try
            {
                 distans = double.Parse(distTB.Text);
                ordinary = double.Parse(ordinaryConsumTB.Text);
                price = double.Parse(priceTB.Text);
            }
            catch { MessageBox.Show("Неверно введены данные"); }

            distTB.Text = "";
            ordinaryConsumTB.Text = "";
            priceTB.Text = "";

            double expens = distans / 100 * ordinary;
            fuelCountLB.Text = expens.ToString();
            double priceDistansUAH = expens * price;
            uanLB.Text = priceDistansUAH.ToString();




        }
    }
}
