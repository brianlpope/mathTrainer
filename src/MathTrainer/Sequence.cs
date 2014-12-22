using System;
using System.Collections.Generic;

namespace MathTrainer
{

    public class Sequence : Question
    {
        private int _countBy = 2;
        private int _minNumber = 1;
        private int _maxNumber = 100;
        private int _numbersInSequence = 8;
        private int _startNumber = 1;
        private int _endNumber = 10;
        private List<int> _beforeMissingList = null;
        private List<int> _afterMissingList = null;
        public WriteTimeHandler TimeWriter { get; set; }
        private Random _random = null;

        public Sequence(Random random) : this(1,100, 2, random)
        {

        }

        public Sequence(int minNumber, int maxNumber, int countBy, Random random)
        {
            _startNumber = random.Next(_minNumber, _maxNumber);
            _endNumber = _startNumber + (_numbersInSequence * _countBy);
            _maxNumber = _endNumber;
            _countBy = countBy;
            _random = random;

            GetQuestion();
        }

        public int MissingNumber { get; set; }

        private List<int> BeforeMissingList
        {
            get
            {
                return _beforeMissingList;
            }
        }

        private List<int> AfterMissingList
        {
            get
            {
                return _afterMissingList;
            }
        }

        public string BeforeMissingAsString 
        {
            get
            {
                return string.Join(", ", _beforeMissingList.ToArray());
            }
        }

        public string AfterMissingAsString
        {
            get
            {
                return string.Join(", ", _afterMissingList.ToArray());
            }
        }

        public void GetQuestion()
        {
            _beforeMissingList = new List<int>();
            _afterMissingList = new List<int>();

            int missingItemIndex = _random.Next(1, _numbersInSequence);
            for (int i = 1; i < _numbersInSequence; i++)
            {
                int nextNumber = _startNumber + (i * _countBy);
                if (i < missingItemIndex)
                    _beforeMissingList.Add(nextNumber);
                else if (i == missingItemIndex)
                    MissingNumber = nextNumber;
                else
                    _afterMissingList.Add(nextNumber);
            }

        }

        public override bool CheckAnswer(int answer)
        {
            return MissingNumber == answer;
        }

        public override string QuestionText
        {
            get
            {
                return BeforeMissingAsString + ", _____ ," + AfterMissingAsString;
            }
        }
    }
}
