namespace Prime_numbers
{
    public partial class PrimeNumbers : Form
    {
        public PrimeNumbers()
        {
            InitializeComponent();
        }

        private void ButonNprime_Click(object sender, EventArgs e)
        {
             int rezultat;
            bool enumar = Int32.TryParse(Numarul.Text, out rezultat);
            if (enumar)
            {
                int d = 1;
                for (int i = 1; i <= rezultat / 2; i++) { if (rezultat % i == 0) { d++; } }
                if (d == 2) { this.BackColor = Color.Green; }
                else { this.BackColor = Color.Red; }

            }
            else { this.BackColor = Color.Yellow; } 
        }
    }
}