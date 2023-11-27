
/// Represents a traffic light that can change its color based on a predefined sequence.
namespace TrafficLight
{
    /// Represents a traffic light that can change its color based on a predefined sequence.

    public class TrafficLight
    {

        /// Gets or sets the current color of the traffic light.
    
        public ListTrafficLight Color { get; set; }


        /// Gets or sets the duration of the current color in seconds.
    
        public int Duration { get; set; }


        /// Initializes a new instance of the TrafficLight class with the specified color and duration.
            public TrafficLight(ListTrafficLight color, int duration = 0)
        {
            Color = color;
            Duration = duration;
        }


        /// Changes the color of the traffic light based on the predefined sequence.
    
        public void ChangeColor()
        {
            if (Color == ListTrafficLight.Red && Duration == 10)
            {
                Color = ListTrafficLight.Green;
                Duration = 0;
            }
            else if (Color == ListTrafficLight.Green && Duration == 13)
            {
                Color = ListTrafficLight.Orange;
                Duration = 0;
            }
            else if (Color == ListTrafficLight.Orange && Duration == 7)
            {
                Color = ListTrafficLight.Red;
                Duration = 0;
            }
            else
            {
                Duration++;
            }
        }


        /// Gets the current state of the traffic light.
    
        public ListTrafficLight GetCurrentState()
        {
            return Color;
        }
    }
}