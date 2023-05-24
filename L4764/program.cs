using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace L4764
{
    class Program
    {
        static void Main()
        {
            List<(int, int, int)> products = new List<(int, int, int)>();

            for (int B = 1; B < 10; B++)
            {
                for (int C = 1; C < 10; C++)
                {
                    if (B != C)
                    {
                        for (int E = 1; E < 10; E++)
                        {
                            if (B != E && C != E)
                            {
                                for (int F = 1; F < 10; F++)
                                {
                                    if (B != F && C != F && E != F)
                                    {
                                        int G = B * E + 66 * C * F;
                                        int H = (C * E + B * F);

                                        if (StringIsNotValid((long)G)) continue;

                                        products.Add((B * 1000 + C * 100 + E * 10 + F, G, H));
                                    }
                                }
                            }
                        }
                    }
                }
            }

            {
                int i = 1;
                int j = 1;
                int prev = 0;
                foreach (var x in products.OrderBy(x => x.Item1))
                {
                    if (x.Item2 == prev)
                        System.Console.WriteLine($"{i++,4}  {x.Item1}  -  {x.Item2} ***** {j++,3}");
                    else
                        System.Console.WriteLine($"{i++,4}  {x.Item1}  -  {x.Item2}");
                    prev = x.Item2;
                }
            }

            foreach (int DD in new int[] { 1, 4, 9 })
            {
                for (int UU = 1; UU < 10; UU++)
                {
                    if (UU == DD) continue;
                    for (int RR = 1; RR < 10; RR++)
                    {
                        if (RR == DD || RR == UU) continue;
                        for (int AA = 1; AA < 10; AA++)
                        {
                            if (AA == DD || AA == UU || AA == RR) continue;
                            for (int TT = 1; TT < 10; TT++)
                            {
                                if (TT == DD || TT == UU || TT == RR || TT == AA) continue;
                                foreach (int II in new int[] { 1, 4, 9 })
                                {
                                    if (II == DD || II == UU || II == RR || II == AA || II == TT) continue;
                                    for (int OO = 1; OO < 10; OO++)
                                    {
                                        if (OO == DD || OO == UU || OO == RR || OO == AA || OO == TT || OO == II) continue;
                                        for (int NN = 1; NN < 10; NN++)
                                        {
                                            if (NN == DD || NN == UU || NN == RR || NN == AA || NN == TT || NN == II || NN == OO) continue;
                                            for (int SS = 1; SS < 10; SS++)
                                            {
                                                if (SS == DD || SS == UU || SS == RR || SS == AA || SS == TT || SS == II || SS == OO || SS == NN) continue;

                                                // Across
                                                long durations1 = -DD + UU * (long)Math.Pow(RR, AA + TT) + II + OO * (long)Math.Pow(NN, SS);
                                                long rotunda = RR + OO * (TT * UU + NN) * DD * AA;
                                                long sitaround = (SS + II + (long)Math.Pow(TT, AA) + RR * OO - UU - NN) * DD;
                                                long unitards = UU * ((long)Math.Pow((NN + II), TT) - (AA + RR) * DD) * SS;
                                                long astroid = (AA + SS) * TT * ((long)Math.Pow(RR, OO) - (long)Math.Sqrt(DD * II));
                                                long dinostar = (DD * II - NN * OO) * (SS + TT) * AA + RR;

                                                // Down
                                                long durations2 = (-DD + UU * (RR + AA) * ((long)Math.Pow(TT, II) + OO * (long)Math.Pow(NN, SS)));
                                                long around = ((AA * RR * OO * UU + NN) * DD);

                                                if (StringIsNotValid(durations1)) continue;
                                                if (StringIsNotValid(rotunda)) continue;
                                                if (StringIsNotValid(sitaround)) continue;
                                                if (StringIsNotValid(unitards)) continue;
                                                if (StringIsNotValid(astroid)) continue;
                                                if (StringIsNotValid(dinostar)) continue;

                                                if (StringIsNotValid(durations2)) continue;
                                                if (StringIsNotValid(around)) continue;

                                                Console.WriteLine($"{DD} {UU} {RR} {AA} {TT} {II} {OO} {NN} {SS}");
                                                Console.WriteLine("\nAcross\n");
                                                Console.WriteLine($" b - {OutString(products, durations1)}");
                                                Console.WriteLine($" i - {OutString(products, rotunda)}");
                                                Console.WriteLine($" k - {OutString(products, sitaround)}");
                                                Console.WriteLine($" n - {OutString(products, unitards)}");
                                                Console.WriteLine($" o - {OutString(products, astroid)}");
                                                Console.WriteLine($" s - {OutString(products, dinostar)}");
                                                Console.WriteLine("\nDown\n");
                                                Console.WriteLine($" c - {OutString(products, durations2)}");
                                                Console.WriteLine($" e - {OutString(products, around)}");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private static string OutString(List<(int, int, int)> products, long val)
        {
            return $"{val} BCEF={products.Where(x => x.Item2 == val).FirstOrDefault().Item1,4} G={products.Where(x => x.Item1 == val).FirstOrDefault().Item2,4}";
        }

        private static bool StringIsNotValid(long lng)
        {
            string str = lng.ToString();

            return (str.Length != 4 ||
                    str.Contains('0') ||
                    str[0] == '-' ||
                    str[0] == str[1] || str[0] == str[2] || str[0] == str[3] ||
                    str[1] == str[2] || str[1] == str[3] ||
                    str[2] == str[3]
                    );
        }
    }
}