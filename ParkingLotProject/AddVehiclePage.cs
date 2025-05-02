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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingLotProject
{
    public partial class AddVehiclePage : Form
    {
        private readonly DatabaseContext _context;
        public Vehicle Vehicle { get; set; }
        public User User { get; set; }
        public AddVehiclePage(Vehicle vehicle, User user)
        {
            InitializeComponent();
            _context = new DatabaseContext();
            Vehicle = vehicle;
            User = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "" && comboBox1.Text != "")
            {
                _context.Vehicles.Add(new Vehicle
                {
                    UserID = User.UserID,
                    VehiclePlate = textBox2.Text,
                    VehicleType = comboBox1.Text
                });
                _context.SaveChanges();

                MessageBox.Show("Vehicle added successfully!");

                var userPage = new UserPage(User, Vehicle);
                userPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var userPage = new UserPage(User, Vehicle);
            userPage.Show();
            this.Hide();
        }
    }
}
