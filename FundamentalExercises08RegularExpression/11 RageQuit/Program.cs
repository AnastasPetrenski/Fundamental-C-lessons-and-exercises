using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace _11_RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternSplit = new Regex(@"(([\D]+)(\d+))");
            //e-!btI17z=E:DMJ19U1Tvg VQ>11P"qCmo.-0YHYu~o%/%b.}a[=d15fz^"{0^/pg.Ft{W12`aD<l&$W&)*yF1WLV9_GmTf(d0($!$`e/{D'xi]-~17 *%p"%|N>zq@ %xBD18<Y(fHh`@gu#Z#p"Z<v13fI]':\Iz.17*W:\mwV`z-15g@hUYE{_$~}+X%*nytkW15
            string input = Console.ReadLine();
            var pairs = patternSplit.Matches(input);
            StringBuilder result = new StringBuilder();
            foreach (Match item in pairs)
            {

                int repeat = int.Parse(item.Groups[3].Value);
                if (repeat <= 0)
                {
                    continue;
                }
                for (int i = 0; i < repeat; i++)
                {
                    result.Append(item.Groups[2].Value.ToUpper());
                }

            }

            var unique = result.ToString().Distinct();
            Console.WriteLine($"Unique symbols used: {unique.Select(x => x).Count()}");
            Console.WriteLine(result);
        }
    }
}
