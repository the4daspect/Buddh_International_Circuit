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
    public sealed partial class races : Page
    {
        public races()
        {
            this.InitializeComponent();
            textblock1.Text = "Before the opening weekend, the expected lap time for a Formula One car around the 5,137m long track, was 1 minute, 27.02 seconds, at an average speed of 210.03 km/h (131 mph). At the end of the long straight between corners 3 and 4, Formula One cars were expected to reach a top speed of about 318 km/h (198 mph).In the inaugural qualifying session, Sebastian Vettel turned in a lap time of 1 minute, 24.178 seconds, beating the predicted lap times from tyre manufacturer Pirelli. Scuderia Toro Rosso driver Jaime Alguersuari posted the top speed through the speed trap, reaching 324.2 km/h.";
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void hyp1_Click(object sender, RoutedEventArgs e)
        {
            var a = new races2();
            Window.Current.Content = a;
            Window.Current.Activate();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = new MainPage();
            Window.Current.Content = a;
            Window.Current.Activate();
        }
    }
}
