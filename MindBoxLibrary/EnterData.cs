using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MindBoxLibrary
{
    public class EnterData
    {
        int[] arr;
        private int mPart;
        public EnterData(int nLength, int _mPart)
        {
            arr = new int[nLength];
            mPart = _mPart;
            SetArray();
        }
        private void SetArray()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
        }

        public void Calculate()
        {
            int len = 0, res = arr[mPart-1], preRes= arr[mPart-2];
            for (int i = 0; i < arr.Length - mPart; i++)
            {
                if (i == mPart) break;
                int k = arr[i];
                arr[i] = arr[mPart + i];
                if (i < mPart) arr[mPart + i] = k;
            }

            for (int i = mPart; i < arr.Length - mPart; i++)
            {
                int k = arr[i];
                arr[i] = arr[2 * mPart + len];
                arr[2 * mPart + len] = k;
                len++;
            }
            if (arr.Length % mPart != 0)
                for (int i = arr.Length - mPart; i < arr.Length; i++)
                {
                    var min = i;
                    for (var j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[min] > arr[j])
                        {
                            min = j;
                        }
                    }
                    if (min != i)
                    {
                        var lowerValue = arr[min];
                        arr[min] = arr[i];
                        arr[i] = lowerValue;
                    }
                }
                Console.WriteLine("результат вычислений [{0}]", string.Join(", ", arr));
        }
    }
}
