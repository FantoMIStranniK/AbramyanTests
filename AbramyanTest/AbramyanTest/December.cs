using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AbramyanTest
{
    public class December
    {
        public void RunTest()
        {

        }

        private int For14(int N)
        {
            int result = 0;

            int numberToAdd = 1;

            for(int i = 0; i < N; i++)
            {
                result += numberToAdd;

                numberToAdd+=2;
            }

            return result;
        }

        private float For23(float X, int N)
        {
            float result = 0f;
            float powNumber = X;

            int factorial = 1;
            int turn = 1;

            for(int i = 1; i <= 2 * N + 1; i++)
            {
                result += (powNumber / factorial) * turn;

                turn = -turn;

                powNumber *= X * X;

                factorial *= (i + 1) * (i + 2);
            }

            return result;
        }

        private int While19(int N)
        {
            int result = 0;

            while(N > 0)
            {
                int leftover = N % 10;

                result = result * 10 + leftover;

                N /= 10;
            }

            return result;
        }

        private int Series25(int[] numbers)
        {
            if(!HasTwoZeros(numbers))
            {
                Console.WriteLine("Ты чиво наделал....");
                return -1;
            }

            int summ = 0;

            bool foundFirstZero = false;

            for(int i = 0; i < numbers.Length; i++)
            {
                if (!foundFirstZero)
                {
                    if (numbers[i] == 0)
                        foundFirstZero = true;

                    continue;
                }

                summ += numbers[i];

                if (numbers[i] == 0 && foundFirstZero)
                    break;
            }

            return summ;
        }

        private bool HasTwoZeros(int[] array)
        {
            int countOfZeros = 0;

            foreach(var elem in array)
            {
                if (elem == 0)
                    countOfZeros++;
            }

            return countOfZeros == 2;
        }

        private float MinMax24(float[] numbers)
        {
            float maxSum = float.MinValue;

            for(int i = 1; i < numbers.Length; i++)
            {
                float summ = numbers[i] + numbers[i - 1];

                if(summ > maxSum)
                   maxSum = summ;
            }

            return maxSum;
        }

        private int MinMax26(int[] numbers)
        {
            bool isSequence = false;

            int maxSequnceLength = int.MinValue;
            int sequnceLength = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(!isSequence)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        isSequence = true;
                        sequnceLength++;
                    }

                    continue;
                }

                if (numbers[i] % 2 != 0 || i + 1 == numbers.Length)
                {
                    isSequence = false;
                    
                    if(sequnceLength > maxSequnceLength)
                    {
                        maxSequnceLength = sequnceLength;
                        
                        sequnceLength = 0;
                    }
                }

                sequnceLength++;
            }

            return maxSequnceLength;
        }

        private List<float> Array17(List<float> A)
        {
            List<float> result = new List<float>(); 

            for(int i = 0; i < A.Count - 1; i+=2)
            {
                result.Add(A[i]);
                result.Add(A[i + 1]);
                result.Add(A[^(i + 1)]);
                result.Add(A[^(i + 2)]);
            }

            return result;
        }

        private int Array48(List<int> numbers)
        {
            Dictionary<int, int> distinctNumbers = new();

            foreach(var number in numbers)
            {
                if(!distinctNumbers.ContainsKey(number))
                    distinctNumbers.Add(number, 1);
                else
                    distinctNumbers[number]++;
            }

            int maxCount = int.MinValue;

            foreach(var number in distinctNumbers)
            {
                if(number.Value > maxCount)
                    maxCount = number.Value;
            }

            return maxCount;
        }

        private List<int> Array66(List<int> numbers)
        {
            int? firstEvenNumber = null;

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    if(firstEvenNumber == null)
                    {
                        firstEvenNumber = numbers[i];
                        numbers[i] *= (int)firstEvenNumber;
                        continue;
                    }

                    numbers[i] *= (int)firstEvenNumber;
                }
            }

            return numbers;
        }

        private List<float> Array77(List<float> numbers) 
        { 
            for(int i = 1; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i - 1] && numbers[i] < numbers[i+1])
                    numbers[i] *= numbers[i];
            }

            return numbers;
        }

        private (Vector2 firstPoint, Vector2 secondPoint, float distance) Array134(List<Vector2> vectors)
        {
            float maxDistance = float.MinValue;

            Vector2 firstPoint = new();
            Vector2 secondPoint = new();

            for(int i = 0; i < vectors.Count; i++)
            {
                for(int j = 0; j < vectors.Count; j++)
                {
                    if (vectors[i] == vectors[j])
                        continue;

                    float distance = (vectors[i] - vectors[j]).Length();

                    if(distance > maxDistance)
                    {
                        maxDistance = distance;
                        
                        firstPoint = vectors[i];
                        secondPoint = vectors[j];
                    }
                }
            }

            return (firstPoint, secondPoint, maxDistance);
        }

        private string String10(string line)
        {
            char[] chars = line.ToCharArray();
            string result = string.Empty;

            for(int i = chars.Length - 1; i >= 0; i--)
            {
                result += chars[i];
            }

            return result;
        }
    }
}
