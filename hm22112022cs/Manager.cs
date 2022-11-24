using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm22112022cs
{
    internal class Manager
    { 
        private Manager(){}
        private static readonly Manager _INSTANCE = new Manager();
        public static Manager INSTANCE
        {
            get
            {
                return _INSTANCE;
            }
        }

        private Hashtable td = new Hashtable();

        public void LoadTable()
        {
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int rnd = r.Next(100, 10000);
                if (rnd%2 == 0)
                {
                    Falafel hold = new Falafel(rnd,r.Next(1,6));
                    if(!td.ContainsKey(rnd))
                    {
                        td.Add(rnd, hold);
                    }

                }
                else
                {
                    IceCream hold = new IceCream(rnd, r.Next(1, 6));
                    if(td[rnd] == null)
                    {
                        if (!td.ContainsKey(rnd))
                        {
                            td.Add(rnd, hold);
                        }
                    }
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("please enter a number from 100 to 9999");
                int userNum = int.Parse(Console.ReadLine());
                if (td.ContainsKey(userNum))
                {
                    if (td[userNum] is Falafel)
                    {
                        Falafel F = (Falafel)td[userNum];
                        Console.WriteLine("#" + F.Id + " - you got a falafel with " + F.ballCount + " balls\n");
                    }
                    else
                    {
                        IceCream I = (IceCream)td[userNum];
                        Console.WriteLine("#" + I.Id + " - you got a IceCream with " + I.ballCount + " balls\n");
                    }
                }
                else
                {
                    Console.WriteLine("invalid KEY\n");
                }

            }
        }
    }
}
