using RestSharp;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        // Placeholder text
        private string placeholderText = "Enter City";

        public Form1()
        {
            InitializeComponent();
        }

        // Placeholder text logic
        private void CityTextBox_Enter(object sender, EventArgs e)
        {
            if (cityTextBox.Text == placeholderText)
            {
                cityTextBox.Text = "";
                cityTextBox.ForeColor = Color.Black;
            }
        }

        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityTextBox.Text = placeholderText;
                cityTextBox.ForeColor = Color.Gray;
            }
        }

        private async void getWeatherButton_Click(object sender, EventArgs e)
        {
            string city = cityTextBox.Text;
            if (!string.IsNullOrWhiteSpace(city) && city != placeholderText)
            {
                await GetWeatherAsync(city);
            }
            else
            {
                weatherLabel.Text = "Please enter a city name.";
            }
        }

        private async Task GetWeatherAsync(string city)
        {
            string apiKey = "66b0a713c0b4680b39ef20353aca6b14";  // Replace with your actual API key
            var client = new RestClient("https://api.openweathermap.org");
            var request = new RestRequest($"/data/2.5/weather?q={city}&appid={apiKey}&units=metric");

            try
            {
                var response = await client.ExecuteAsync(request);
                if (response.IsSuccessful && response.Content != null)
                {
                    // Parse JSON response
                    JsonDocument document = JsonDocument.Parse(response.Content);
                    JsonElement root = document.RootElement;

                    string description = root.GetProperty("weather")[0].GetProperty("description").GetString();
                    string iconCode = root.GetProperty("weather")[0].GetProperty("icon").GetString();
                    double temp = root.GetProperty("main").GetProperty("temp").GetDouble();
                    double feelsLike = root.GetProperty("main").GetProperty("feels_like").GetDouble();
                    int humidity = root.GetProperty("main").GetProperty("humidity").GetInt32();
                    double pressure = root.GetProperty("main").GetProperty("pressure").GetDouble();
                    double windSpeed = root.GetProperty("wind").GetProperty("speed").GetDouble();

                    // Extract city ID
                    int cityId = root.GetProperty("id").GetInt32();

                    // Store the city ID in the weatherIcon's Tag
                    weatherIcon.Tag = cityId;

                    // Update the weather label with detailed weather data
                    weatherLabel.Text = $"Weather: {description}\n" +
                                        $"Temperature: {temp}°C\n" +
                                        $"Feels Like: {feelsLike}°C\n" +
                                        $"Humidity: {humidity}%\n" +
                                        $"Pressure: {pressure} hPa\n" +
                                        $"Wind Speed: {windSpeed} m/s";

                    // Set weather icon
                    string iconUrl = $"https://openweathermap.org/img/wn/{iconCode}@2x.png";
                    weatherIcon.Load(iconUrl); // This loads the icon from the URL

                    weatherIcon.Enabled = true;
                }
                else
                {
                    weatherLabel.Text = "Could not retrieve weather data. Please check the city name or try again.";
                }
            }
            catch (Exception ex)
            {
                weatherLabel.Text = $"Error: {ex.Message}";
            }
        }

        private void weatherIcon_Click(object sender, EventArgs e)
        {
            var cityId = weatherIcon.Tag as int?;
            if (cityId.HasValue)
            {
                // Generate the URL for the city's detailed weather page using the city ID
                string url = $"https://openweathermap.org/city/{cityId.Value}";

                // Open the URL in the default web browser
                try
                {
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening the URL: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("City information not found.");
            }
        }
    }
}