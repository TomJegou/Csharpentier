namespace NPC
{
    // Create a class Human that inherits from the NPC class
    public class Human : NPC
    {
        // Properties of the Human class
        public bool AsCrossed { get; set; } = false; // Property to track if the human has crossed the road
        public string Name { get; set; } // Property to store the name of the human

        // Constructor for the Human class that initializes its properties along with the base class properties
        public Human(int age, int speed, string name) : base(age, speed)
        {
            Age = age; // Set the age of the human
            Speed = speed; // Set the speed of the human
            Name = name; // Set the name of the human
        }

        // Override the ToString() method to provide a formatted string representation of the Human object
        public override string ToString()
        {
            return string.Format("Human:\n*   {0}\n*   {1}\n*   {2}\n", Age, Speed, Name); // Return a formatted string with human details
        }

        // Method to simulate the human crossing the road
        public void CrossRoad()
        {
            Console.WriteLine(string.Format("Human : My name is {0} and I'm crossing the road !", Name)); // Display a message indicating the human is crossing
            AsCrossed = true; // Set the AsCrossed property to true, indicating that the human has crossed the road
        }
    }
}
