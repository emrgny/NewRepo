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
    public partial class UserPage : Form
    {
        private List<Button> parkingButtons;
        private readonly DatabaseContext _context;
        public string ParkingAreaName { get; set; }
        public Vehicle Vehicle { get; set; }
        public User User { get; set; }
        public UserPage(User user, Vehicle vehicle)
        {
            InitializeComponent();
            InitializeParkingButtons();

            User = user;
            Vehicle = vehicle;
            _context = new DatabaseContext();

            var vehicles = GetAllMyVehicles();
            PopulateListView(vehicles);
        }
        private void InitializeParkingButtons()
        {
            parkingButtons = new List<Button> { A1, A2, A3, A4, A5, A6, A7, A8, A9, A10, A11, A12 };

            foreach (var button in parkingButtons)
            {
                button.Visible = false;
                button.Enabled = true;
                button.BackColor = Color.MediumPurple;

                button.Click += ParkingButton_Click;
            }
        }
        private void ParkingButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                ParkingAreaName = clickedButton.Name;
                MessageBox.Show($"Seçilen park alanı: {ParkingAreaName}");
            }
        }

        private List<Vehicle> GetAllMyVehicles()
        {
            return _context.Vehicles.Where(v => v.UserID == User.UserID).ToList();
        }
        private void PopulateListView(List<Vehicle> vehicles)
        {
            listView2.Items.Clear();
            foreach (var vehicle in vehicles)
            {
                var item = new ListViewItem(vehicle.VehicleID.ToString());
                item.SubItems.Add(vehicle.VehiclePlate);
                item.SubItems.Add(vehicle.VehicleType);
                listView2.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Başlangıç tarihi, bitiş tarihinden sonra olamaz!", "Tarih Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // İşleme devam etme
            }

            // 1. Tüm rezervasyonları al
            var reservations = _context.Reservations
                .Where(r =>
                    (startDate <= r.ExitTime && endDate >= r.EntryTime) // çakışan tarihler
                )
                .ToList();

            // 2. Tüm butonları görünür ve resetle
            foreach (var button in parkingButtons)
            {
                button.Visible = true;
                button.Enabled = true;
                button.BackColor = Color.LightGreen;
            }

            // 3. Dolu alanları kırmızı yap
            foreach (var reservation in reservations)
            {
                var button = parkingButtons.FirstOrDefault(b => b.Name == reservation.ParkingAreaNumber);
                if (button != null)
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ParkingAreaName))
            {
                MessageBox.Show("Lütfen bir park alanı seçiniz.");
                return;
            }

            var reservation = new Reservation
            {
                ParkingAreaNumber = ParkingAreaName,
                EntryTime = dateTimePicker1.Value.Date,
                ExitTime = dateTimePicker2.Value.Date,
                UserID = User.UserID
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            MessageBox.Show("Rezervasyon başarıyla yapıldı.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                var selectedItem = listView2.SelectedItems[0];
                int vehicleId = int.Parse(selectedItem.SubItems[0].Text); 

                
                var vehicleToDelete = _context.Vehicles.Find(vehicleId);
                if (vehicleToDelete != null)
                {
                    _context.Vehicles.Remove(vehicleToDelete);
                    _context.SaveChanges();

                    if (Vehicle != null && vehicleToDelete.VehicleID == Vehicle.VehicleID)
                    {
                        MessageBox.Show("Giriş yaptığınız araç silindi. Ana sayfaya yönlendiriliyorsunuz.");
                        this.Hide();
                        var loginPage = new LoginPage();
                        loginPage.Show();
                        this.Close(); // Formu tamamen kapatmak istersen
                    }
                    else
                    {
                        // Silinmeyen araçsa sadece listeyi yenile
                        var updatedVehicles = GetAllMyVehicles();
                        PopulateListView(updatedVehicles);
                    }
                }
                else
                {
                    MessageBox.Show("Araç bulunamadı.");
                }
                
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir araç seçin.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                var updatePage = new UpdateVehiclePage(Vehicle,User);
                updatePage.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir araç seçin.");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }
    }

        
    
}
