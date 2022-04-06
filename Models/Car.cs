namespace Models
{
    public class Car
    {
        string make = "";
        string model = "";
        int price = 0;

        public Car(string s, string ss, int p)
        {
            this.make = s;
            this.model = ss;
            this.price = p;
        }

        public string toString(Car c)
        {
            return ($"{this.make}" + " " + $"{this.model}" + " " + $"{this.price}");
        }
    }
}