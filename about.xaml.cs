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
    public sealed partial class about : Page
    {
        public about()
        {
            this.InitializeComponent();
            textblock2.Text = "The Buddh International Circuit is an Indian motor racing circuit in Greater Noida, Uttar Pradesh, India, near the national capital New Delhi.\nThe circuit is best known as the venue for the annual Formula One Indian Grand Prix, which was first hosted in 2011.\nThe track was officially inaugurated on 18 October 2011.The 5.14 km long Circuit has been designed by world-renowned \nGerman architect and racetrack designer, Herman Tilke, who has also designed other race circuits in Malaysia,Bahrain, China, Turkey, the UAE, South Korea and the US.\nFormula One racing's governing body, the FIA, had announced the inclusion of the Indian Grand Prix for the 30th of October 2011.\nEstimated to cost about INR10 billion ($215 million) to build, the circuit has an approximate length of 5.14 km and is spread over \nan area of 874 acres (354ha) and is another creation of Hermann Tilke. The circuit was officially inaugurated on 18 October 2011, just about two weeks before the first race. \nThe seating capacity is initially expected to be 110,000 with provisions to increase it to 200,000 later on.\nThe circuit is part of the 2,500 acres (10 km2) Jaypee Greens Sports City,Greens Sports City home which also includes a 100,000 seat cricket stadium, 18-hole golf course, 25,000 seat field hockey stadium and a sports academy have been planned. The sports complex is expected to cost INR40 billion ($820 million) and generate $170m of revenue annually, and employ 10,000 people.The design was forwarded to the teams to gather feedback on how the circuit could be altered to improve overtaking and this has resulted in some minor changes as became clear from April 2010. The planned hairpin at turn seven was removed, and the track at turn three was widened to allow drivers to take different lines throughout the corner. More information was released in August 2010, revealing that there were plans to make the circuit one of the most challenging for drivers, with the circuit rising fourteen metres within the first three corners alone and a banked double-apex bend on the far side of the circuit.[12] The track has since been praised by drivers, including Lewis Hamilton who compared it to the classic Circuit de Spa-Francorchamps.\nOriginally known as the Jaypee Group Circuit or the Jaypee International Circuit after the circuit's owners, the circuit was officially named the Buddh International Circuit in April 2011. According to Sameer Gaur, the Managing Director and Chief Executive of Jaypee Sports International, The name ‘Buddh International Circuit’ has been chosen with reference to the area where the racetrack is situated – Gautam Budh Nagar district (near Greater Noida). Because of its location, naming the circuit ‘Buddh International Circuit’ was a logical choice for the company.The Buddh International circuit logo consists of a ‘B’ which also resembles a heart.The BIC logo is a stylized ‘B,’ the letter that stands for ‘Buddh’ and for ‘Bharat.’ The orange, green and white colours used in the logo are representative of the Indian flag, while the curves in the stylized ‘B’ in the logo represent the lines of a racetrack";
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
            var a = new MainPage();
            Window.Current.Content = a;
            Window.Current.Activate();

        }
    }
}
