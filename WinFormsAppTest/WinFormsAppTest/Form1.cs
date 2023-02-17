using TestWinForm_3;

namespace WinFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string textBox1 = "";
            string txtBoxTitle = "";
            string comboBox1 = "";
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Author= textBox1.Text;
            book.Title= txtBoxTitle.Text;
            book.Publisher = comboBox1.Text;
            book.Genre = groupBox1.Text;
            book.Cover = groupBox2.Text;
            if (radioButton1.Checked)
            {
                book.Genre = radioButton1.Text;
            }
            if (radioButton2.Checked)
            {
                book.Genre = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                book.Genre = radioButton3.Text;
            }

            if (checkBox1.Checked)
            {
                book.Cover = checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                book.Cover = checkBox2.Text;
            }
            
            List<Book> list = new List<Book>();
            if (comboBox1.Text == "")
            {
                MessageBox.Show("You have not choosen a cover type", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }
            else if (textBox1.Text=="")
            {
                MessageBox.Show("You have not entered an author", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtBoxTitle.Text == "")
            {
                MessageBox.Show("You have not choosen a publisher", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult btnEnter =  MessageBox.Show($"You entered {txtBoxTitle.Text} from {textBox1.Text}," +
                $"{book.Genre} literature with {book.Cover} cover from publishing studio {comboBox1.Text}\n " + 
                $"Do you confirm?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                MessageBox.Show("Entered!");
                
            }
            
            
           
            

          

        }

        private void lblGenre_Click(object sender, EventArgs e)
        {

        }
    }
}