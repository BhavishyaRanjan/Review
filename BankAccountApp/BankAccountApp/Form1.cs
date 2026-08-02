namespace BankAccountApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            BankAccount user1 = new BankAccount();
            user1.owner = "Bhavishya Ranjan";
            user1.accountNumber = Guid.NewGuid();
            user1.balance = 0;

            BankAccount user2 = new BankAccount();
            user1.owner = "Elon Musk";
            user1.accountNumber = Guid.NewGuid();
            user1.balance = 0;

            BankAccount user3 = new BankAccount();
            user1.owner = "Bill gates";
            user1.accountNumber = Guid.NewGuid();
            user1.balance = 0;

            List<BankAccount> users = new List<BankAccount>();
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            BankAccountGrid.DataSource = users;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
