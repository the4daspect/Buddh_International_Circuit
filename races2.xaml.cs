using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Buddh_International_Circuit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class races2 : Page
    {
        public races2()
        {
            this.InitializeComponent();
            textblock1.Text = "\n\nWith the successful conclusion of the second edition of the Indian Grand Prix, there is no denying that the adrenalin-driven sport of Formula One (F1) racing is here to stay in India. From a single Indian F1 driver a few years ago to having an F1 team that symbolically represents the nation to successfully hosting a Grand Prix, Indian motorsports has come a long way in a very short time. There is sufficient reason to believe that the Indian audience for F1 is only going to grow from here on. The strongest point in favour of this is India's 1.2 billion people. With such a huge population, it is only a matter of talent-spotting to identify future F1 drivers. Besides, such a large viewership base also provides a sound financial foundation for F1 in India. What India currently lacks is infra-structure to develop future F1 drivers. A vibrant motorsports hierarchy from go-karting to F1 is a must if India is to progress in this field of sport. However, any new sport takes time to become popular and achieve critical mass. The argument that F1 is an elitist sport doesn't cut ice. Many other sports too require a significant amount of financial investment. As exemplified by Team Force India, there isn't a dearth of local corporate interest in F1. Besides, despite all the expensive automotive technology involved, at the end of the day it is the F1 driver's skills that matter most.F1 racing is a modern, cutting-edge sport that represents the acme of human-technology integration. There are various ways in which the sport can be packaged. Singapore's night Grand Prix is a huge crowd-puller that generates significant revenues. In the same vein - and not unlike cricket's Indian Premier League - F1's combination of sport and entertainment perfectly suits Indian tastes.\nRace Winner:  Sebastian Vettel from Red Bull Racing-Renault acrosses 60 laps in 1:31:10.744 time. ";

        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = new races();
            Window.Current.Content = a;
            Window.Current.Activate();
        }
    }
 }
