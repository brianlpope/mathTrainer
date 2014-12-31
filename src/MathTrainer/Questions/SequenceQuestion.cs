using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTrainer
{
    public class SequenceQuestion : Question
    {
        private int[] _items;
        private int _answer;

        public SequenceQuestion() { }

        public SequenceQuestion(int minStartNumber, int maxStartNumber, int sequenceLength, int incrementBy)
        {
            MinStartNumber = minStartNumber;
            MaxStartNumber = maxStartNumber;
            SequenceLength = sequenceLength;
            IncrementBy = incrementBy;

            InitializeSequence();
        }

        public int MinStartNumber { get; set; }
        public int MaxStartNumber { get; set; }
        public int SequenceLength { get; set; }
        public int IncrementBy { get; set; }
        private int _answerIndex { get; set; }

        private void InitializeSequence()
        {
            _items = new int[SequenceLength];

            int startValue = Randomizer.GetValue(MinStartNumber, MaxStartNumber);

            for(int i = 0; i < SequenceLength; i++)
            {
                _items[i] = startValue + (i * IncrementBy);
            }

        }

        public override string DisplayText
        {
            get
            {
                _answerIndex = Randomizer.GetValue(0, SequenceLength);
                _answer = _items[_answerIndex];
                _items[_answerIndex] = -999;
                string fullSequence = string.Join(", ", _items);
                fullSequence = fullSequence.Replace("-999", "____");

                return fullSequence;
            }
        }

        public override int Answer
        {
            get
            {
                return _answer;
            }
        }
    }
}
