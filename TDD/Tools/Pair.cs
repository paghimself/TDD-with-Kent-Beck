﻿using System;

namespace TDD.Tools
{
    internal class Pair
    {
        internal readonly string from;
        internal readonly string to;

        public Pair(string from, string to)
        {
            this.from = from;
            this.to = to;
        }

        public override bool Equals(object obj)
        {
            Pair pair = (Pair)obj; 
            return from.Equals(pair.from) && to.Equals(pair.to);
        }

        public override int GetHashCode()
        {
            return 0;
            //return HashCode.Combine(From, To);
        }
    }
}
