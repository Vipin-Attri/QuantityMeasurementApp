using QuantityMeasurementApp.BusinessLogic;

namespace QuantityMeasurementApp.BusinessLogic
{
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


        public void QuantityMeasurementAppMainMethod()
        {

            GetInputAndCheckFeetEquality();
        }

    }
}
