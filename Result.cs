using System;
namespace L4764
{
    public class Result
    {
        public string Str;
        public long Value;
        public bool IsInvalid;
        public Result(string str, long val)
        {
            Str = str;
            Value = val;

            string s = val.ToString();

            IsInvalid =
                (s.Length != 4 ||
                 s.Contains('0') ||
                 s[0] == '-' ||
                 s[0] == s[1] || s[0] == s[2] || s[0] == s[3] ||
                 s[1] == s[2] || s[1] == s[3] ||
                 s[2] == s[3]
                 );
        }
    }
}

