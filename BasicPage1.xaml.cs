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

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Buddh_International_Circuit
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class BasicPage1 : Buddh_International_Circuit.Common.LayoutAwarePage
    {
        public BasicPage1()
        {
            this.InitializeComponent();
            TextBlock1.Text = "F1 racing is here to stay With the successful conclusion \n of the second edition of the Indian Grand Prix, there \n is no denying that the adrenalin-driven sport of Formula One (F1) \n  racing is here to stay in India. From a single Indian F1 driver a few years \n  ago to having an F1 team that symbolically represents the nation to \n successfully hosting a Grand Prix, Indian motorsports has come a long way in a very \n short time. There is sufficient reason to believe that the Indian audience for \n F1 is only going to grow from here on. The strongest point in favour of this is India's \n 1.2 billion people. With such a huge population, it is only a matter of talent-spotting \n to identify future F1 drivers. Besides, such a large viewership base \n also provides a sound financial foundation for F1 in India.";
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
    }
}
