using System;
using System.Collections.Generic;
using System.Text;

namespace HealthMgr
{
   public class BmiCalculator
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public float BMI
        {
            get
            {
                return Calculate();
            }
        }


        public float Calculate()
        {
            // Calculate BMI using floating point division to avoid
            // truncation from integer math.
            float height = (float)Height / 100f;
            float result = Weight / (height * height);
            return result;
        }
    }
}
