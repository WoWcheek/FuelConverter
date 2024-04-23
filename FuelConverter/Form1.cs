namespace FuelConverter
{
    public partial class Form1 : Form
    {
        protected bool IsDarkTheme { get; set; }

        public Form1()
        {
            InitializeComponent();
            DateTime now = DateTime.Now;
            if (now.Hour >= 19 || now.Hour <= 6)
                IsDarkTheme = true;
            else
                IsDarkTheme = false;

            SetTheme();
        }

        protected void SetTheme()
        {
            if (IsDarkTheme)
            {
                BackColor = Color.DimGray;
                foreach (var control in Controls)
                    if (control is Label)
                        (control as Label).ForeColor = Color.White;
                pictureBox1.Image = Image.FromFile("../../../images/dark_theme.png");
            }
            else
            {
                BackColor = Color.LightGray;
                foreach (var control in Controls)
                    if (control is Label)
                        (control as Label).ForeColor = Color.Black;
                pictureBox1.Image = Image.FromFile("../../../images/light_theme.png");
            }
        }

        private async void calculateBtn_Click(object sender, EventArgs e)
        {
            double distans = 0, ordinary = 0, price = 0;

            try
            {
                distans = double.Parse(distTB.Text);
                ordinary = double.Parse(ordinaryConsumTB.Text);
                price = double.Parse(priceTB.Text);
                if (distans <= 0 || ordinary <= 0 || price <= 0)
                    throw new Exception();
                double expens = distans / 100 * ordinary;
                fuelCountLB.Text = expens.ToString();
                double priceDistansUAH = expens * price;
                uanLB.Text = priceDistansUAH.ToString();

                double priceDistansUSD = await Exchange.Convert(priceDistansUAH);
                dolLB.Text = priceDistansUSD.ToString();
            }
            catch { MessageBox.Show("Неверно введены данные"); }

            distTB.Text = "";
            ordinaryConsumTB.Text = "";
            priceTB.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IsDarkTheme = !IsDarkTheme;
            SetTheme();
        }
    }
}
