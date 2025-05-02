using ParkingLotProject.Context;
using ParkingLotProject.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLotProject
{
    public partial class RegisterPage : Form
    {
        private readonly DatabaseContext _context;
        public RegisterPage()
        {
            InitializeComponent();
            _context = new DatabaseContext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && comboBox1.Text !="")
            {
                if(textBox5.Text == textBox6.Text)
                {
                    var user = new User
                    {
                        Name = textBox1.Text,
                        Surname = textBox2.Text,
                        PhoneNumber = textBox3.Text,
                        Email = textBox4.Text,
                        Password = textBox5.Text
                    };

                    _context.Users.Add(user);
                    _context.SaveChanges();

                    var userInfo = _context.Users.FirstOrDefault(x=> x.Email == textBox4.Text && x.Password == textBox5.Text);

                    _context.Vehicles.Add(new Vehicle
                    {
                        UserID = userInfo.UserID,
                        VehiclePlate =textBox7.Text ,
                        VehicleType = comboBox1.Text,
                    });

                    _context.SaveChanges();

                    MessageBox.Show("User registered successfully!");

                    var loginPage = new LoginPage();
                    loginPage.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                }
               
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }
    }
}
