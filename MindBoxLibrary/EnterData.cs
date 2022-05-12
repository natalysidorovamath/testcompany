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
            if (mPart == 3)  CorrectValue(res, preRes);
                Console.WriteLine("результат вычислений [{0}]", string.Join(", ", arr));
        }
        private void CorrectValue(int res, int preRes)
        {
            int otl = 0;
            for (int i = arr.Length-3; i< arr.Length; i++){
                if(arr[i] != res && arr[i] != preRes)
                otl =  arr[i];
            }
            arr[arr.Length - 1] = res; arr[arr.Length - 2] = preRes; arr[arr.Length-3] = otl;
        }
    }
}
