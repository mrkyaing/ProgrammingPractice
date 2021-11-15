namespace GenericDemo
{
    public class Point<T>
    {
        private T xPositon;
        private T yPositon;

        public Point(T x,T y)
        {
            this.xPositon = x;
            this.yPositon = y;
        }
        public T X
        {
            get { return xPositon; }
            set { xPositon = value; }
        }
        public T Y
        {
            get { return yPositon; }
            set { yPositon = value; }
        }

        public void ReSet()
        {
            xPositon=default(T);
            yPositon=default(T);
        }

        public override string ToString()
        {
            return $"[{xPositon},{yPositon}]";
        }
    }
}
