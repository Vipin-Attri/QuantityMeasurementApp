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
}
