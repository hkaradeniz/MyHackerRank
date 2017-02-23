namespace JimAndTheOrders
{
    class Order
    {
        public int Sequence { get; set; }
        public int pTime { get; set; }
        public int oTime { get; set; }

        public Order()
        {
            pTime = 0;
            oTime = 0;
            Sequence = 0;
        }

        public int TotalTime()
        {
            return pTime + oTime;
        }
    }
}
