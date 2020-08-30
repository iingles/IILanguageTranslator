using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IILanguageTranslator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Display Spanish for "Good Morning"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSpanish_Clicked(object sender, EventArgs e)
        {
            // Change the label results to Spanish good morning
            LblResults.Text = "Buenos Dias";
        }

        /// <summary>
        /// Display Italian for "Good Morning"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnItalian_Clicked(object sender, EventArgs e)
        {
            // Change the label results to Italian good morning
            LblResults.Text = "Buongiorno";
        }

        /// <summary>
        ///  Display German for "Good Morning"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGerman_Clicked(object sender, EventArgs e)
        {
            // Change the label results to German good morning
            LblResults.Text = "Guten Morgen";
        }
    }
}
