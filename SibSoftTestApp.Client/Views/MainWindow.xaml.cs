using SibSoftTestApp.Client.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows;
using System.Windows.Media;

namespace SibSoftTestApp.Client.Views
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void customerNameTextBox_GotFocus(object sender, EventArgs e)
        {
            if (customerNameTextBox.Text == "Наименование заказчика")
            {
                customerNameTextBox.Text = "";
                customerNameTextBox.Foreground = Brushes.Black;
            }
        }

        private void customerNameTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerNameTextBox.Text))
            {
                customerNameTextBox.Text = "Наименование заказчика";
                customerNameTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void customerTaxNumberTextBox_GotFocus(object sender, EventArgs e)
        {
            if (customerTaxNumberTextBox.Text == "ИНН заказчика")
            {
                customerTaxNumberTextBox.Text = "";
                customerTaxNumberTextBox.Foreground = Brushes.Black;
            }
        }

        private void customerTaxNumberTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerTaxNumberTextBox.Text))
            {
                customerTaxNumberTextBox.Text = "ИНН заказчика";
                customerTaxNumberTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void performerNameTextBox_GotFocus(object sender, EventArgs e)
        {
            if (performerNameTextBox.Text == "Наименование исполнителя")
            {
                performerNameTextBox.Text = "";
                performerNameTextBox.Foreground = Brushes.Black;
            }
        }

        private void performerNameTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(performerNameTextBox.Text))
            {
                performerNameTextBox.Text = "Наименование исполнителя";
                performerNameTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void performerTaxNumberTextBox_GotFocus(object sender, EventArgs e)
        {
            if (performerTaxNumberTextBox.Text == "ИНН исполнителя")
            {
                performerTaxNumberTextBox.Text = "";
                performerTaxNumberTextBox.Foreground = Brushes.Black;
            }
        }

        private void performerTaxNumberTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(performerTaxNumberTextBox.Text))
            {
                performerTaxNumberTextBox.Text = "ИНН исполнителя";
                performerTaxNumberTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void vehicleNumberTextBox_GotFocus(object sender, EventArgs e)
        {
            if (vehicleNumberTextBox.Text == "Госномер")
            {
                vehicleNumberTextBox.Text = "";
                vehicleNumberTextBox.Foreground = Brushes.Black;
            }
        }

        private void vehicleNumberTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicleNumberTextBox.Text))
            {
                vehicleNumberTextBox.Text = "Госномер";
                vehicleNumberTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void vehicleBrandTextBox_GotFocus(object sender, EventArgs e)
        {
            if (vehicleBrandTextBox.Text == "Марка")
            {
                vehicleBrandTextBox.Text = "";
                vehicleBrandTextBox.Foreground = Brushes.Black;
            }
        }

        private void vehicleBrandTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicleBrandTextBox.Text))
            {
                vehicleBrandTextBox.Text = "Марка";
                vehicleBrandTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void vehicleModelTextBox_GotFocus(object sender, EventArgs e)
        {
            if (vehicleModelTextBox.Text == "Модель")
            {
                vehicleModelTextBox.Text = "";
                vehicleModelTextBox.Foreground = Brushes.Black;
            }
        }

        private void vehicleModelTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicleModelTextBox.Text))
            {
                vehicleModelTextBox.Text = "Модель";
                vehicleModelTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void vehicleServiceDescriptionTextBox_GotFocus(object sender, EventArgs e)
        {
            if (vehicleServiceDescriptionTextBox.Text == "Вид ремонта")
            {
                vehicleServiceDescriptionTextBox.Text = "";
                vehicleServiceDescriptionTextBox.Foreground = Brushes.Black;
            }
        }

        private void vehicleServiceDescriptionTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicleServiceDescriptionTextBox.Text))
            {
                vehicleServiceDescriptionTextBox.Text = "Вид ремонта";
                vehicleServiceDescriptionTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void servicePriceTextBox_GotFocus(object sender, EventArgs e)
        {
            if (servicePriceTextBox.Text == "Стоимость ремонта")
            {
                servicePriceTextBox.Text = "";
                servicePriceTextBox.Foreground = Brushes.Black;
            }
        }

        private void servicePriceTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(servicePriceTextBox.Text))
            {
                servicePriceTextBox.Text = "Стоимость ремонта";
                servicePriceTextBox.Foreground = Brushes.LightGray;
            }
        }

        private void vehicleMileageTextBox_GotFocus(object sender, EventArgs e)
        {
            if (vehicleMileageTextBox.Text == "Пробег")
            {
                vehicleMileageTextBox.Text = "";
                vehicleMileageTextBox.Foreground = Brushes.Black;
            }
        }

        private void vehicleMileageTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vehicleMileageTextBox.Text))
            {
                vehicleMileageTextBox.Text = "Пробег";
                vehicleMileageTextBox.Foreground = Brushes.LightGray;
            }
        }

        private async void AddDataToServer()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44316/api");
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    Customer customer = new Customer
                    {
                        customerName = customerNameTextBox.Text,
                        customerTaxNumber = customerTaxNumberTextBox.Text
                    };
                    
                    Performer performer = new Performer
                    {
                        performerName = performerNameTextBox.Text,
                        performerTaxNumber = performerTaxNumberTextBox.Text
                    };
                       
                    Vehicle vehicle = new Vehicle
                    {
                        vehicleNumber = vehicleNumberTextBox.Text,
                        vehicleBrand = vehicleBrandTextBox.Text,
                        vehicleModel = vehicleModelTextBox.Text
                    };
                          
                    VehicleService vehicleService = new VehicleService
                    {
                        vehicleNumber = vehicleNumberTextBox.Text,
                        customerTaxNumber = customerTaxNumberTextBox.Text,
                        performerTaxNumber = performerTaxNumberTextBox.Text,
                        vehicleServiceDescription = vehicleServiceDescriptionTextBox.Text,
                        serviceDate = (DateTime)serviceDatePicker.SelectedDate,
                        servicePrice = float.Parse(servicePriceTextBox.Text),
                        vehicleMileage = float.Parse(vehicleMileageTextBox.Text)
                    };

                    HttpResponseMessage customerResponse = await client.PostAsJsonAsync("api/Customer", customer);
                    if (customerResponse.IsSuccessStatusCode) 
                    { 
                        HttpResponseMessage performerResponse = await client.PostAsJsonAsync("api/Performer", performer);
                            if (performerResponse.IsSuccessStatusCode)
                            {
                            HttpResponseMessage vehicleResponse = await client.PostAsJsonAsync("api/Vehicle", vehicle);
                                if (vehicleResponse.IsSuccessStatusCode)
                                {
                                    HttpResponseMessage vehicleServiceResponse = await client.PostAsJsonAsync("api/VehicleService", vehicleService);
                                    MessageBox.Show("Заказ успешно сохранен в базу");
                                }
                            }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при сохранении заказа в базу");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Необходимо заполнить все поля");
                }
            };
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            AddDataToServer();
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            customerNameTextBox.Clear();
            customerTaxNumberTextBox.Clear();
            performerNameTextBox.Clear();
            performerTaxNumberTextBox.Clear();
            vehicleNumberTextBox.Clear();
            vehicleBrandTextBox.Clear();
            vehicleModelTextBox.Clear();
            vehicleServiceDescriptionTextBox.Clear();
            servicePriceTextBox.Clear();
            vehicleMileageTextBox.Clear();
            serviceDatePicker.Text = string.Empty;
        }
    }
}