using System;
using System.Collections.Generic;
using System.Text;

namespace prjXAML.Models
{
    public class lottop
    {
        public string getnum()
        {
            Random rand = new Random();
            int count = 0;
            int[] number = new int[6];
            while (count < 6)
            {
                int temp = rand.Next(1, 50);
                bool IsSelect = false;
                for (int k = 0; k < number.Length; k++)
                {
                    if (temp == number[k])
                    {
                        IsSelect = true;
                        break;
                    }                   
                }
                if (!IsSelect)
                {
                    number[count] = temp;
                    count++;
                }
            }

            //泡沫排序(演算法)
            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length - 1; j++)
                {
                    if (number[j] > number[j+ 1] )
                    {
                        int big = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = big;
                    }
                }
            }


            string s = "";
            foreach (int i in number)
                s += i.ToString() + " ";
            return s;

            
           
        } 
    }
}
