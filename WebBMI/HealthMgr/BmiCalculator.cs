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
            float result = 0;
            // 避免整數除法造成計算錯誤，將 Height 轉為 float
            float height = (float)Height / 100;
            result = Weight / (height * height);

            return result;
        }
    }
}
