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
            var products = GetProducts();

            var results = new Results();

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
                                                long sutorian = SS * (long)Math.Pow(UU, TT) + (OO + RR + II) * AA + NN;
                                                long dinostar = (DD * II - NN * OO) * (SS + TT) * AA + RR;
                                                //long trinodus = ((TT / RR) * Math.Pow(II, NN) * (OO * DD * UU + SS)); this doesn't work ! T/R = 3/2
                                                long tinodusRearr = (long)(TT * (long)Math.Pow(II, NN) * (OO * DD * UU + SS) / RR);
                                                long tundras = (TT * (long)Math.Pow(UU, NN) * (DD + RR) + AA) * SS;
                                                long intrados = -(long)Math.Sqrt(II) * NN + TT * RR * AA * DD * OO + SS;

                                                // Down
                                                long durations2 = (-DD + UU * (RR + AA) * ((long)Math.Pow(TT, II) + OO * (long)Math.Pow(NN, SS)));
                                                long dinosaur = DD * II * ((long)Math.Pow(NN, OO) * SS + AA + UU) * RR;
                                                long around = ((AA * RR * OO * UU + NN) * DD);
                                                long auditors = AA * (UU + DD) + (II + TT + OO) * (long)Math.Pow(RR, SS);
                                                long sautoir = SS - AA + (long)Math.Pow(UU, TT) * (OO + II - RR);
                                                long sudation = (SS * (UU + DD - AA) - TT) * II * OO + NN;
                                                long rainouts = RR - (AA + II + NN + OO - (long)Math.Pow(UU, TT)) * SS;
                                                long nutrisoda = ((long)Math.Pow((NN + UU), TT) + RR * II + SS + OO + DD) * AA;
                                                long rodaustin = RR * (OO * ((long)Math.Sqrt(DD) - AA + UU * SS * TT) - II + NN);
                                                long astound = AA * ((long)Math.Pow(SS, TT) + OO * UU + NN) + DD;

                                                if (results.AddAnswer(new Result("durations1", durations1))) continue;
                                                if (IsInvalidNumber(rotunda)) continue;
                                                if (IsInvalidNumber(sitaround)) continue;
                                                if (IsInvalidNumber(unitards)) continue;
                                                if (IsInvalidNumber(astroid)) continue;
                                                if (IsInvalidNumber(sutorian)) continue;
                                                if (IsInvalidNumber(dinostar)) continue;
                                                if (IsInvalidNumber(tinodusRearr)) continue;
                                                if (IsInvalidNumber(tundras)) continue;
                                                if (IsInvalidNumber(intrados)) continue;

                                                if (IsInvalidNumber(durations2)) continue;
                                                if (IsInvalidNumber(dinosaur)) continue;
                                                if (IsInvalidNumber(around)) continue;
                                                if (IsInvalidNumber(auditors)) continue;
                                                if (IsInvalidNumber(sautoir)) continue;
                                                if (IsInvalidNumber(sudation)) continue;
                                                if (IsInvalidNumber(rainouts)) continue;
                                                if (IsInvalidNumber(nutrisoda)) continue;
                                                if (IsInvalidNumber(rodaustin)) continue;
                                                if (IsInvalidNumber(astound)) continue;

                                                Console.WriteLine("\n d u r a t i o n s");
                                                Console.WriteLine($" {DD} {UU} {RR} {AA} {TT} {II} {OO} {NN} {SS}");

                                                Console.WriteLine("\nAcross\n");
                                                Console.WriteLine($" b - {products.GetString(durations1)}");
                                                Console.WriteLine($" i - {products.GetString(rotunda)}");
                                                Console.WriteLine($" k - {products.GetString(sitaround)}");
                                                Console.WriteLine($" n - {products.GetString(unitards)}");
                                                Console.WriteLine($" o - {products.GetString(astroid)}");
                                                Console.WriteLine($" p - {products.GetString(sutorian)}");
                                                Console.WriteLine($" s - {products.GetString(dinostar)}");
                                                Console.WriteLine($" v - {products.GetString(tinodusRearr)}");
                                                Console.WriteLine($" w - {products.GetString(tundras)}");
                                                Console.WriteLine($" y - {products.GetString(intrados)}");
                                                Console.WriteLine("\nDown\n");
                                                Console.WriteLine($" c - {products.GetString(durations2)}");
                                                Console.WriteLine($" d - {products.GetString(dinosaur)}");
                                                Console.WriteLine($" e - {products.GetString(around)}");
                                                Console.WriteLine($" f - {products.GetString(auditors)}");
                                                Console.WriteLine($" j - {products.GetString(sautoir)}");
                                                Console.WriteLine($" m - {products.GetString(sudation)}");
                                                Console.WriteLine($" q - {products.GetString(rainouts)}");
                                                Console.WriteLine($" r - {products.GetString(nutrisoda)}");
                                                Console.WriteLine($" t - {products.GetString(rodaustin)}");
                                                Console.WriteLine($" u - {products.GetString(astound)}");

                                                foreach (var r in products.Prods.Where(x => $"{x.BCEF}{x.G}".OrderBy(z => z).ToString() == "13456789"))
                                                {
                                                    Console.WriteLine($"{r.BCEF} {r.G}");
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
        }

        private static Products GetProducts()
        {
            var products = new Products();
            var unique = new Products();

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

                                        if (IsInvalidNumber((long)G)) continue;

                                        int BCEF = B * 1000 + C * 100 + E * 10 + F;
                                        products.Add(BCEF, G);

                                        {
                                            var all = $"{BCEF}{G}".OrderBy(z => z).ToArray();
                                            bool valid = true;
                                            for (int i = 1; i < all.Length; i++)
                                            {
                                                if (all[i - 1] == all[i])
                                                {
                                                    valid = false;
                                                    break;
                                                }
                                            }
                                            if (valid)
                                            {
                                                unique.Add(BCEF, G);
                                                Console.WriteLine($"{BCEF}, {G}");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return products;
        }

        private static bool IsInvalidNumber(long lng)
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