using System.Collections.Generic;

namespace CLRViaCsharp.Indexer
{
    public class IndexerTest
    {
        private readonly IList<int> _nums;
        private readonly string _text;

        public int this[int numPos]
        {
            get
            {
                if (numPos < 0 || numPos > _nums.Count - 1)
                    return 0;
                return _nums[numPos];

            }
            set => _nums[numPos] = value;
        }

        public bool this[char charToFind] => _text.Contains(charToFind.ToString());


        public IndexerTest()
        {
            _text = "testtesttesttesttetstets";
            _nums = new[] { 1, 5, 4, 3, 678, 4 };
        }
    }
}
