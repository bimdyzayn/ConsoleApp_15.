using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();

            GeomProgression geom = new GeomProgression();

            Console.ReadLine();

        }
    }

    public interface ISeries
    {
        void setStart(int x);

        int getNext();
        void reset();
    }


    public class ArithProgression : ISeries
    {

        public void setStart(int x)
        {
            return;

        }
        public int getNext()
        {

            return 1;
        }
        public void reset()
        {

        }
        public ArithProgression()
        {

            int i, Sn, y;
            y = 80;
            Sn = 1;
            for (i = 1; i <= y; i++)
            {
                Sn += i;
                Console.WriteLine(Sn);
            }


        }
    }
    public class GeomProgression : ISeries
    {
        public void setStart(int x)
        {
            return;
        }
        public int getNext()
        {
            return 1;
        }

        public void reset()
        {
            throw new NotImplementedException();
        }
        public GeomProgression()
        {

            int i, Sn, y;
            y = 80;
            Sn = 1;
            for (i = 1; i <= y; i++)
            {
                Sn *= i;
                Console.WriteLine(Sn);
            }



        }
    }
}
