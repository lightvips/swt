using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNPower
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Game HANOI POWER!!!\n");

            //int num = Int32.Parse(Console.ReadLine());
            string num = "1";
            ThapHN hn = new ThapHN(num);
            Console.WriteLine("Node Path => " + hn.NodePath);
            Console.WriteLine(hn.NumOfMove);
            //Console.WriteLine(hn.StringOutput);
            Console.ReadKey();
        }
    }

    public class ThapHN
    {
        public int NumOfMove { get; set; }
        public Boolean[] Node { get; set; }
        public string NodeName { get; set; }
        public string NodePath { get; set; }
        public string StringOutput { get; set; }

        public void Swap(int n, char x, char y)
        {
            //E
            if (Node[4])
            {
                //After add E to Node [] => NodeName them after that don't add D into Node []
                NodeName += "E";
                Node[4] = false;
            }
            NodePath += "E";
            NumOfMove++;
            StringOutput += String.Format("Move disk {0} from {1} to {2}\n", n, x, y);
        }
        public void Recursive(int n, char a, char c, char b)
        {
            //After add D => NodeName them after that don't add D
            if (Node[3])
            {
                Node[3] = false;
                NodeName += "D";
            }
            NodePath += "D"; //every time call Recursive then check n =1 => Call D
            //D
            if (n == 1) Swap(1, a, c);
            else
            {
                Recursive(n - 1, a, b, c);
                Swap(n, a, c);
                Recursive(n - 1, b, c, a);
            }

        }

        public void MainProcess(int n)
        {   //Node A is the first Node.
            NodeName += "A";
            NodePath += "A";
            if (n < 1)//Node A
            {
                //Node B
                NodeName += "B";
                NodePath += "B";
                StringOutput += "Error! Invalid input";
            }
            else Recursive(n, 'A', 'B', 'C');

            //Node C
            NodeName += "C";
            NodePath += "C";
        }
        public ThapHN()
        {

        }

        public ThapHN(string n)
        {
            try
            {
                int num = Int32.Parse(n);
                if (num >= 15) throw new Exception();
                StringOutput = "";
                NodeName = "";
                NumOfMove = 0;
                NodePath = "";
                Node = new Boolean[5];
                // Init 5 node A,B,C,D,E
                // If Program stop at a Node?
                // => All Node after that node = false.
                for (int i = 0; i < 5; i++)
                {
                    Node[i] = true;
                }
                MainProcess(num);
                Console.WriteLine(StringOutput);
            }
            catch (Exception)
            {
                StringOutput += "Error! Invalid input";
                //Console.WriteLine(StringOutput);        
            }
            
        }
    }
}
