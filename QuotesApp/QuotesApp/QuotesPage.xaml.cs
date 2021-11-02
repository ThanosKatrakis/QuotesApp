using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        int index = 0;
        string[] quotesList = {
            "Don’t ask who is now, but who he has always been.",
            "Habit is second nature.",
            "One thing i know, that i know nothing. This is the source of my wisdom.",
            "Good people do not need law to tell them to act responsibly, while bad people will find a way around the laws.",
            "You don't develop courage by being happy in your relationships everyday. You develop it by surviving difficult times and challenging adversity.",
            "By all means, get married: if you find a good wife, you'll be happy; if not, you'll become a philosopher.",
            "I am indebted to my father for living, but to my teacher for living well.",
            "Nothing exists except atoms and empty space; everything else is just opinion.",
            "Love is composed of a single soul inhabiting two bodies.",
            "He who steals a little steals with the same wish as he who steals much, but with less power.",
            "mall opportunities are often the beginning of great enterprises."};

        public QuotesPage()
        {
            InitializeComponent();
            currenQuote.Text = quotesList[index];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            index++;
            if (index >= quotesList.Length)
            {
                index = 0;
            }
            currenQuote.Text = quotesList[index];
        }
    }
}