using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlightBookingApp.Behaviors
{
    public class AutoCloseSwipeBehavior : Behavior<SwipeView>
    {
        SwipeView associatedObject;

        public static readonly BindableProperty DelayProperty =
            BindableProperty.Create(nameof(Delay), typeof(int), typeof(AutoCloseSwipeBehavior));

        public int Delay
        {
            get { return (int)GetValue(DelayProperty); }
            set { SetValue(DelayProperty, value); }
        }

        protected override void OnAttachedTo(SwipeView swipeView)
        {
            associatedObject = swipeView;
            swipeView.SwipeEnded += OnSwipeEnded;

            base.OnAttachedTo(swipeView);
        }

        protected override void OnDetachingFrom(SwipeView swipeView)
        {
            swipeView.SwipeEnded -= OnSwipeEnded;
            associatedObject = null;

            base.OnDetachingFrom(swipeView);
        }

        private async void OnSwipeEnded(object sender, SwipeEndedEventArgs e)
        {
            await Task.Delay(Delay);

            if (e.SwipeDirection == SwipeDirection.Down)
                associatedObject.Close();
        }
    }
}