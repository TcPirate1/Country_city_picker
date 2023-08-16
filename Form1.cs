using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Country_city_picker
{
    public partial class Form1 : Form
    {
        private ArrayList messages = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            CountryListBox.Items.Add("New Zealand");
            CountryListBox.Items.Add("Australia");

            PopulateCities("");
        }

        private void PopulateCities(string country)
        {
            CityComboBox.Items.Clear();

            // Populate the ComboBox based on the selected country
            switch (country)
            {
                case "New Zealand":
                    CityComboBox.Items.Add("Auckland");
                    CityComboBox.Items.Add("Wellington");
                    CityComboBox.Items.Add("Christchurch");
                    break;
                case "Australia":
                    CityComboBox.Items.Add("Sydney");
                    CityComboBox.Items.Add("Brisbane");
                    CityComboBox.Items.Add("Melbourne");
                    break;
            }
        }

        private void CountryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateCities(CountryListBox.SelectedItem.ToString());
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = NameEntryTextBox.Text;
            string city = CityComboBox.SelectedItem.ToString();
            string country = CountryListBox.SelectedItem.ToString();
            string message = $"{name} lives in {city}, {country}";

            messages.Add(message);

            // Display a MessageBox with the message
            MessageBox.Show(message, "Message Created");

            // Clear input fields
            NameEntryTextBox.Clear();
            CityComboBox.SelectedIndex = -1;
            CountryListBox.SelectedIndex = -1;
        }
    }
}
