using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class UpdateVehiclePage : Form
    {
        private readonly DatabaseContext _context;
        public Vehicle Vehicle { get; set; }
        public User User { get; set; }
        public UpdateVehiclePage(Vehicle vehicle, User user)
        {
            InitializeComponent();
            _context = new DatabaseContext();
            Vehicle = vehicle;
            User = user;
            textBox1.Text = Vehicle.VehicleID.ToString();
            textBox2.Text = Vehicle.VehiclePlate;
            comboBox1.Text = Vehicle.VehicleType;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var userPage = new UserPage(User, Vehicle);
            userPage.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text != "")
           { 
              
               _context.Vehicles.Update(new Vehicle
                 {
                     VehicleID = int.Parse(textBox1.Text),
                     UserID = User.UserID,
                     VehiclePlate = textBox2.Text,
                     VehicleType = comboBox1.Text
                 });
               _context.SaveChanges();
                 
               Vehicle = new Vehicle
                 {
                     VehicleID = int.Parse(textBox1.Text),
                     UserID = User.UserID,
                     VehiclePlate = textBox2.Text,
                     VehicleType = comboBox1.Text
                 };

                MessageBox.Show("Vehicle updated successfully!");

                var userPage = new UserPage(User, Vehicle);
                userPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }

        }

    }
}
