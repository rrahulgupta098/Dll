namespace Dll
{
    public class Class1
    {
        public int n1, n2, result;
        public int pn1 
      {
            set { n1 = value; }
        }
        public int pn2
        {
            set { n2 = value; }
        }

        public int presult
        {
            get { return result; }
        }

        public void add()
        {
            result = n1 + n2;
        }
        public void sub()
        {
            result = n1 - n2;
        }

        public void mul()
        {
            result = n1*n2;
        }

        public void divide()
        {
            result = n1/n2;
        }
    }
}