namespace PizzaOrderForm
{
    public partial class Form1 : Form
    {
        string vidPizza = "";
        string sizePizza = "";
        string dobavki = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(radioSmall.Checked) 
            {
            sizePizza= radioSmall.Text;
            }
            if (radioMedium.Checked)
            {
                sizePizza = radioMedium.Text;
            }
            if (radioLarge.Checked)
            {
                sizePizza = radioLarge.Text;
            }

           
            
            if (chubricabox.Checked)
            {
                dobavki = chubricabox.Text;
            }
            if (ketchupbox.Checked)
            {
                dobavki = ", " + ketchupbox.Text;
            }
            if (mayobox.Checked)
            {
                dobavki = ", " + mayobox.Text;
            }
            if (gorchicabox.Checked)
            {
                dobavki = "," + gorchicabox.Text;
            }
           
            
            if (comboPizzaType.Text=="")
            {
                MessageBox.Show("Не сте избрали пица","Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboPizzaType.Focus();
                return;
            }
            else if(sizePizza== "")
                {

                MessageBox.Show("Не сте избрали размер", "Проблем", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radioLarge.Focus();
                    }
            else
            {
                DialogResult btnOrder = MessageBox.Show($"Избрахте пица от вида: {comboPizzaType.Text}.\n" +
                    $"Избрани добавки към нея са: {dobavki}.\n" +
                    $"Потвърждавате ли вашата поръчка?", "Потвърждаване", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lboxToppings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboPizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}