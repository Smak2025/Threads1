namespace Threads1
{
    public class SequentialSummator
    {
        public int N
        {
            get => field;
            set => field = Math.Abs(value);
        }

        public long Result
        {
            get => field;
            private set => field = value;
        }

        public SequentialSummator(int n)
        {
            N = n;
        }

        public void CalcSum()
        {
            for (int i = 1; i <= N; i++)
            {
                Result += i;
            }
        }
    }
}
