using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turingTest
{
    class Program
    {

        static void Main(string[] args)
        {
         while (true)
            {
                Console.WriteLine("Please enter numbers to add with space ex : 3 4 5");
              String s=  Console.ReadLine();
                char[] space = new char[] { ' ' };
                String[] ops = s.Split(space);
                int output = calcPoints(ops);
                Console.WriteLine(output);

            } 

        }

static int calcPoints(String[] s)
        {
            
            List<int> il = new List<int>();
            for (int count =0; count < s.Length; count++)
            {
                String cs = s.ElementAt(count);

                switch (cs)
                {
                    case "c":
                        {
                            il.RemoveAt(il.Count - 1);
                        }
                        break;
                    case "d":
                        {
                            il.Add(il.ElementAt(il.Count - 1) * 2);
                        }
                        break;
                    case "+":
                        {
                            il.Add(il.ElementAt(il.Count - 2) + il.ElementAt(il.Count - 1));

                        }
                        break;
                    default:
                        int temp = 0;
                        try { il.Add(int.Parse(cs)); }
                        catch { }

                   
                        break;


                }


            }

            return il.Sum();

        }


        static void Main2(string[] args)
        {
           // Program p = new Program();
           while (true)
            {

           
            if (Program.IsValid(Console.ReadLine()))
                Console.WriteLine("valid");
            else
                Console.WriteLine("not valid");
            }

        }

        private static bool IsValid(String s)
        {
            bool valid = true;
           // char[] space = new char[] { ' ' };
            //String[] ops = s.Split(space);
            char[] ops = s.ToCharArray();
            List<char> listchar = new List<char>();
            for (int count =0; count < ops.Length; count++)
            {
                char c = ops[count];
                switch (c)
                {
                    case   '(':
                        listchar.Add(c);
                        break;
                    case '{':
                        listchar.Add(c);
                        break;
                    case '[':
                        listchar.Add(c);
                        break;
                    case ')':
                        {
                            char cprev = listchar.ElementAt(listchar.Count - 1);
                            if (cprev != '(') { return false; }
                            else
                            {
                                listchar.RemoveAt(listchar.Count - 1);
                              
                            }
                        }
                        break;
                    case '}':
                        {
                            char cprev = listchar.ElementAt(listchar.Count - 1);
                            if (cprev != '{') { return false; }
                            else
                            {
                                listchar.RemoveAt(listchar.Count - 1);

                            }
                        }
                        break;
                    case ']':
                        {
                            char cprev = listchar.ElementAt(listchar.Count - 1);
                            if (cprev != '[') { return false; }
                            else
                            {
                                listchar.RemoveAt(listchar.Count - 1);

                            }
                        }
                        break;


                }

            }

            return valid;

        }




    }
}
