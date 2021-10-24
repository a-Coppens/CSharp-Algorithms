using System;

namespace CSharp_Algos
{
    class StringReverser
    {
        private string _stringToReverse;
        private string _reversedString;
        public StringReverser(string s)
        {
            this._stringToReverse = s;

            if (validateString(_stringToReverse))
            {
                _reversedString = reverseString(_stringToReverse);
            }
        }

        private string reverseString(string nonReversedString)
        {
            String reverseString = "";
            for (int i = nonReversedString.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + nonReversedString[i];
            }
            return reverseString;
        }

        private bool validateString(String s)
        {
            if (s == null || s.Length == 0)
            {
                throw new NullReferenceException("String is Empty or Null");
            }

            return true;

        }

        public string reversed
        {
            get => _reversedString;
        }


    }

}
