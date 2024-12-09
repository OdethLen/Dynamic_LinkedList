namespace Dynamic_LinkedList
{
    public partial class Form1 : Form
    {
        private List<int> numbers;
        public Form1()
        {
            InitializeComponent();
            numbers = new List<int>();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                numbers.Add(number); 
                numbers.Sort(); 
                UpdateDisplay(); 
                MessageBox.Show("Number " + number + " inserted correctly.");
                txtNumber.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid number ");
                return; 
            }
        }

        private void UpdateDisplay()
        {
            lstvNumbers.DataSource = null; // Reseteamos el origen de datos.
            lstvNumbers.DataSource = numbers; // Actualizamos el origen de datos.
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                if (numbers.Remove(number)) 
                {
                    UpdateDisplay();
                    MessageBox.Show("Number " + number + " correctly eliminated .");
                }
                else
                {
                    MessageBox.Show("Number " + number + " was not found in the list .");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number. ");
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                if (numbers.Contains(number)) // Verificamos si el número está en la lista.
                {
                    MessageBox.Show("Number " + number + " is on the list ");
                }
                else
                {
                    MessageBox.Show("Number " + number + " is not on the list.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Linked list contains: " + numbers.Count + " elements.");
        }
    }
}
