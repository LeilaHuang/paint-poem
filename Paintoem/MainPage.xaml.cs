using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Paintoem
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class MainPage : Page
    {
        int level=0;
        int levelPart=0;
        Point hand;
        int pointOffset;
        DispatcherTimer timer;


        public MainPage()
        {
            this.InitializeComponent();

            
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.05);
            timer.Tick += new EventHandler<object>(timer_Tick);

        }

        private void timer_Tick(object sender, object e)
        {
           
         


        }

        private void image_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            PointerPoint point = e.GetCurrentPoint(image);
            textBox.Text = point.Position.X.ToString();
        }
    }



    public class DrawPoint
    {

        Image image;
        bool finished=false;
        Point[] points;
        int[] process;
        int pointNum;

   

    }
}
