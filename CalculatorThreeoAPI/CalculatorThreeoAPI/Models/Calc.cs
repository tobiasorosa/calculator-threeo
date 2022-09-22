namespace CalculatorThreeoAPI.Models
{
    public class Calc
    {
        public float Add(float firstValue, float secondValue)
        {
            return firstValue + secondValue;
        }

        public float Sub(float firstValue, float secondValue)
        {
            return firstValue - secondValue;
        }

        public float Mult(float firstValue, float secondValue)
        {
            return firstValue * secondValue;
        }

        public float Div(float firstValue, float secondValue)
        {
            return firstValue / secondValue;
        }
    }
}
