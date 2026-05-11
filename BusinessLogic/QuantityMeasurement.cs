using QuantityMeasurementApp.BusinessLogic;

namespace QuantityMeasurementApp.BusinessLogic
{

public class Feet
    {
        private readonly double feetValue;

        public Feet(double value)
        {
            feetValue = value;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            if(obj.GetType()!= this.GetType()) return false;
            
            Feet newobje = (Feet)obj;

            return newobje.feetValue == this.feetValue;

        }


        public override int GetHashCode()
        {
            return feetValue.GetHashCode();
        }


        public double GetFeetValue() {
            return feetValue;
        }


    }

// feet class end


public class Inch
    {
        private readonly double inchValue;

        public Inch(double value)
        {
            inchValue = value;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj.GetType() != this.GetType()) return false;

            Inch newobje = (Inch)obj;

            return newobje.inchValue == this.inchValue;

        }
    }



    public class QuantityMeasurement
    {
        public QuantityMeasurement() { }


        public void GetInputAndCheckFeetEquality()
        {
            Console.WriteLine("Enter first input");
            double input1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second input");
            double input2 = double.Parse(Console.ReadLine());


            Feet feet1 = new Feet(input1);

            Feet feet2 = new Feet(input2);


            bool result = feet1.Equals(feet2);

            Console.WriteLine("Result Equal is: " + result);




        }




public void GetInputAndCheckInchEquality()
        {
            Console.WriteLine("Enter first input");
            double input1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second input");
            double input2 = double.Parse(Console.ReadLine());


            Inch inch1 = new Inch(input1);

            Inch inch2 = new Inch(input2);


            bool result = inch1.Equals(inch2);

            Console.WriteLine("Result Equal is: " + result);

        }

        public void QuantityMeasurementAppMainMethod()
        {

            // GetInputAndCheckFeetEquality();
            GetInputAndCheckInchEquality();
        }

    }
}
