using ParkingLotProject.Context;

namespace ParkingLotProject
{
    public partial class LoginPage : Form
    {
        private readonly DatabaseContext _context;
        public LoginPage()
        {
            InitializeComponent();
            _context = new DatabaseContext();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var registerPage = new RegisterPage();
            registerPage.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
           var user = _context.Users.FirstOrDefault(x => x.Email == textBox1.Text && x.Password == textBox2.Text);
           var vehicle = _context.Vehicles.FirstOrDefault(x => x.VehiclePlate == textBox3.Text);
            if (user != null && vehicle != null)
            {
                var userPage = new UserPage(user,vehicle);
                userPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }
        }
    }
}
