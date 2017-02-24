namespace UtopianTree
{
    class MyTree
    {
        int Height;

        public MyTree()
        {
            Height = 1;
        }

        public void GrowSpring()
        {
            Height = Height * 2;
        }

        public void GrowSummer()
        {
            Height = Height + 1;
        }

        public int GetTreeHeight()
        {
            return Height;
        }
    }
}
