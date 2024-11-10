using System.Drawing;
using System.Windows.Forms;
using System;

namespace WeatherApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.getWeather = new System.Windows.Forms.Button();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // cityTextBox
            // 
            this.cityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cityTextBox.BackColor = System.Drawing.Color.White;
            this.cityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cityTextBox.ForeColor = System.Drawing.Color.Gray;
            this.cityTextBox.Location = new System.Drawing.Point(80, 40);
            this.cityTextBox.MaxLength = 30;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(250, 25);
            this.cityTextBox.TabIndex = 0;
            this.cityTextBox.Text = "Enter City";
            this.cityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cityTextBox.Enter += new System.EventHandler(this.CityTextBox_Enter);
            this.cityTextBox.Leave += new System.EventHandler(this.CityTextBox_Leave);
            // 
            // weatherLabel
            // 
            this.weatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.weatherLabel.ForeColor = System.Drawing.Color.White;
            this.weatherLabel.Location = new System.Drawing.Point(40, 250);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(320, 200);
            this.weatherLabel.TabIndex = 1;
            this.weatherLabel.Text = "Weather information will appear here...";
            this.weatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getWeather
            // 
            this.getWeather.BackColor = System.Drawing.Color.SlateGray;
            this.getWeather.FlatAppearance.BorderSize = 0;
            this.getWeather.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getWeather.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.getWeather.ForeColor = System.Drawing.Color.White;
            this.getWeather.Location = new System.Drawing.Point(138, 80);
            this.getWeather.Name = "getWeather";
            this.getWeather.Size = new System.Drawing.Size(125, 30);
            this.getWeather.TabIndex = 2;
            this.getWeather.Text = "Get Weather";
            this.getWeather.UseVisualStyleBackColor = false;
            this.getWeather.Click += new System.EventHandler(this.getWeatherButton_Click);
            // 
            // weatherIcon
            // 
            this.weatherIcon.BackColor = System.Drawing.Color.Transparent;
            this.weatherIcon.Location = new System.Drawing.Point(150, 150);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(100, 100);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIcon.TabIndex = 3;
            this.weatherIcon.TabStop = false;
            this.weatherIcon.Click += new System.EventHandler(this.weatherIcon_Click);
            this.weatherIcon.Cursor = Cursors.Hand;
            weatherIcon.Enabled = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.getWeather);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.weatherLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Button getWeather;
        private System.Windows.Forms.PictureBox weatherIcon;
    }
}