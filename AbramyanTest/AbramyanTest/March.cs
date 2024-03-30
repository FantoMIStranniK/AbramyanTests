using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbramyanTest
{
    public class March
    {
        public int Integer26(int K)
        {
            int leftover = K % 7;

            return 2 + leftover;
        }

        public bool Boolean14(int A, int B, int C)
        {
            if (A > 0 && B < 0 && C < 0)
                return true;
            else if (A < 0 && B > 0 && C < 0)
                return true;
            else if (A < 0 && B < 0 && C > 0)
                return true;

            return false;
        }

        public bool Boolean31(int A, int B, int C)
        {
            if (A == B && B == C)
                return false;

            if (A == B && B != C)
                return true;
            else if (A == C && C != B)
                return true;
            else if (B == C && C != A)
                return true;

            return false;
        }

        public (int, int) If10(int A, int B)
        {
            if(A != B)
            {
                int sum = A + B;

                A = sum;
                B = sum;
            }
            else
            {
                A = 0; 
                B = 0;
            }

            return (A, B);
        }

        public int If27(float X)
        {
            if(X < 0)
                return 0;

            int integerX = (int)X;

            if (integerX % 2 == 0)
                return 1;
            else
                return -1;
        }

        public (int Day, int Month) Case9(int D, int M)
        {
            D++;

            switch (M)
            {
                case 1 or 3 or 5 or 7 or 8 or 10 or 12:
                    if(D + 1 > 31)
                    {
                        D = 1;
                        M += 1;
                    }
                    break;
                case 4 or 6 or 9 or 11:
                    if(D + 1 > 30)
                    {
                        D = 1;
                        M += 1;
                    }
                    break;
                case 2:
                    if(D + 1 > 28)
                    {
                        D = 1;
                        M += 1;
                    }
                    break;
            }

            if (M > 12)
                M = 1;

            return (D, M);
        }

        public float For12(int N)
        {
            float mult = 1.1f;
            float result = 1f;

            for(int i = 0; i < N; i++)
            {
                result *= mult;
                mult += 0.1f;
            }

            return result;
        }

        public int For38(int N)
        {
            int Power = N - 1;
            int result = 1;

            for(int i = 2; i <= N; i++)
            {
                result += (int)MathF.Pow(i, Power);

                Power--;
            }

            return result;
        }

        public int While25(int N)
        {
            int FOne = 1;
            int FTwo = 1;
            int newF = 0;

            while (newF < N)
            {
                newF = FOne + FTwo;

                FTwo = FOne;
                FOne = newF;
            }

            return FOne > N ? FOne : FTwo;
        }

        //Proc 26
        public bool IsPower(int K)
        {
            int temp = 1;

            while(temp < K)
            {
                temp *= 5;
            }

            return temp == K;
        }

        public bool IsPalindrom(int K)
        {
            string number = K.ToString();

            for(int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] != number[^(i + 1)])
                    return false;
            }

            return true;
        }

        public (int, int) MinMax7(int[] N)
        {
            int maxIndex = 0;
            int minIndex = 0;

            for(int i = 0; i < N.Length; i++)
            {
                if (N[i] > N[maxIndex])
                    maxIndex = i;
                else if (N[i] <= N[minIndex])
                    minIndex = i;
            }

            return (maxIndex, minIndex);
        }

        public int MinMax19(int[] N)
        {
            int minIndex = 0;
            int countOfMin = 1;

            for(int i = 0; i < N.Length; i++)
            {
                if (N[i] < N[minIndex])
                {
                    minIndex = i;
                    countOfMin = 1;
                }
                else if (N[i] == N[minIndex])
                {
                    countOfMin++;
                }
            }

            return countOfMin;
        }

        public List<int> Array119(List<int> N)
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < N.Count; i++)
            {
                numbers.Add(N[i]);

                if (i + 1 >= N.Count)
                    break;

                if (N[i] != N[i + 1])
                    numbers.Add(N[i]);
            }

            numbers.Add(numbers[^1]);

            return numbers;
        }

        public string String16(string word)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < word.Length; i++)
            {
                char letter = word[i];

                if(char.IsUpper(letter))
                    letter = char.ToLower(letter);

                stringBuilder.Append(char.ToLower(letter));
            }

            return stringBuilder.ToString();
        }
    }
}
