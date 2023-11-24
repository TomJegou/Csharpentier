namespace TrafficLight
{
    public class TrafficLight
    {
        public ListTrafficLight Color { get; set; }
        public int Duration { get; set; }


        public TrafficLight(ListTrafficLight color, int duration)
        {
            Color = color;
            Duration = duration;
        }

        public void ChangeColor()
        {
            if (Color == ListTrafficLight.Red && Duration == 13)
            {
                Color = ListTrafficLight.Green;
                Duration = 0;
            }
            else if (Color == ListTrafficLight.Green && Duration == 7)
            {
                Color = ListTrafficLight.Orange;
                Duration = 0;
            }
            else if (Color == ListTrafficLight.Orange && Duration == 10)
            {
                Color = ListTrafficLight.Red;
                Duration = 0;
            }
            else{
                Duration++;
            }
        }


        public ListTrafficLight GetCurrentState()
        {
            return Color;
        }


}

}