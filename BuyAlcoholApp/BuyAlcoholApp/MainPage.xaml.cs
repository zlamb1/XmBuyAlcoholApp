using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuyAlcoholApp
{
    public partial class MainPage : ContentPage
    {
        public Dictionary<string, int> countryDrinkingAge = new Dictionary<string, int>
        {
            { "United States of America", 21 }, { "United Kingdom", 18 },
            { "Canada", 19 }, { "Mexico", 18 }
        };

        public MainPage()
        {
            InitializeComponent();
        }

        public void OnSelectBirthday(object target, DateChangedEventArgs e)
        {
            var birthDate = DatePicker.Date;
            var currentDate = DateTime.Now;

            var drinkingAge = countryDrinkingAge[(string)CountryPicker.SelectedItem];
            var drinkingAgeDate = birthDate.AddYears(drinkingAge);
            var yearsRemaining = (drinkingAgeDate - currentDate).Days / 365.0f;

            if (yearsRemaining > 0.0f)
            {
                Label_Years.Text = "How Many Years Until I Am Legal? " + Math.Round(yearsRemaining, 2);
            }
            else
            {
                Label_Years.Text = "How Many Years Until I Am Legal? You're LEGAL!"; 
            }

        }
    }
}
