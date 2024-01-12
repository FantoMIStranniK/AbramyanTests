using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AbramyanTest
{
    public class January
    {
        public void Test()
        {

        }


        public float N1(Vector2 pointOne, Vector2 pointTwo, Vector2 pointThree)
        {
            var ab = new Vector2(pointOne.X - pointTwo.X, pointOne.Y - pointTwo.Y);
            var bc = new Vector2(pointTwo.X - pointThree.X, pointTwo.Y - pointThree.Y);
            var ac = new Vector2(pointThree.X - pointOne.X, pointThree.Y - pointOne.Y);

            var height = (bc.Length() * ac.Length()) / ab.Length();

            return height;
        }

        public int N2 (List<int> numbers)
        {
            int countOfThreeDigitNum = 0;

            foreach(var number in numbers)
            {
                int hundreds = number / 100;

                if (hundreds == 0)
                    continue;

                int tens = (number % 100) / 10;
                
                int ones = number % 10;

                bool isUprising = hundreds < tens && tens < ones;

                countOfThreeDigitNum += isUprising ? 1 : 0;
            }

            return countOfThreeDigitNum;
        }

        public float For24(float X, int N)
        {
            float result = 0f;
            float fact = 1f;
            float powX = 1f;

            int turn = 1;

            for(int i = 0; i < N * 2; i++)
            {
                fact *= i;

                if(i % 2 == 0)
                {
                    result += (powX / fact) * turn;

                    powX *= X * X;

                    turn = - turn;
                }
            }

            return result;
        }

        public bool While21(int N)
        {
            do
            {
                var number = N % 10;

                N /= 10;

                if (number % 2 != 0)
                    return true;
            }
            while (N != 0);

            return false;
        }

        public void Sort3(out int newA, out int newB, out int newC, int A, int B, int C)
        {
            List<int> numbers = new List<int>() { A, B, C };

            numbers.Sort();

            newA = numbers[0];
            newB = numbers[1];
            newC = numbers[2];
        }

        public (int H, int M, int S) N7((int H, int M, int S) timeOne, (int H, int M, int S) timeTwo)
        {
            int newS = timeOne.S + timeTwo.S;
            int newM = 0;
            int newH = 0;

            if(newS / 60 > 0)
            {
                newM += newS / 60;

                newS %= 60;
            }

            newM += timeOne.M + timeTwo.M;

            if (newM / 60 > 0)
            {
                newH += newM / 60;

                newM %= 60;
            }

            newH += timeOne.H + timeTwo.H;

            if (newH / 24 > 0)
            {
                newH %= 24;
            }


            return (newH, newM, newS);
        }

        public int MinMax20(List<int> N)
        {
            int countOfExtreme = 0;

            for(int i = 1; i < N.Count - 1; i++)
            {
                if (N[i] > N[i - 1] && N[i] < N[i + 1])
                    countOfExtreme++;
                else if(N[i] < N[i - 1] && N[i] > N[i + 1])
                    countOfExtreme++;
            }

            return countOfExtreme;
        }

        public List<int> Array61(List<int> A)
        {
            List<int> B = new();

            for(int i = 0; i < A.Count; i++)
            {
                var numbers = A.Skip(i).Take(A.Count - 1 - i);

                var summ = numbers.Sum(x => x);

                B.Add(summ / numbers.Count());
            }

            return B;
        }
    }
}
