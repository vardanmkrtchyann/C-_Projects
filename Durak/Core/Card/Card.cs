using System;

namespace Durak.Core.Card
{
    public sealed class Card : IComparable
    {
        public sealed class Suit
        {
            public enum Color
            {
                Red,
                Black
            }

            public enum Symbol
            {
                Heart,
                Diamond,
                Club,
                Spade
            }

            public Color SuitColor { get; }
            public Symbol SuitSymbol { get; }

            public Suit(Symbol symbol)
            {
                SuitSymbol = symbol;
                SuitColor = IdentifyColor(symbol);
            }

            public Color IdentifyColor(Symbol symbol)
            {
                switch (symbol)
                {
                    case Symbol.Heart: return Color.Red;
                    case Symbol.Diamond: return Color.Red;
                    case Symbol.Club: return Color.Black;
                    default: return Color.Black;
                }
            }
            public override string ToString()
            {
                return SuitSymbol.ToString();
            }
        }

        public enum Value
        {
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }

        public Suit CardSuit { get; }
        public Value CardValue { get; }

        public Card(Suit suit, Value value)
        {
            CardSuit = suit;
            CardValue = value;
        }

        public int CompareTo(Object other)
        {
            return 0;
        }
        public override string ToString()
        {
            return $"{CardValue} of {CardSuit}s";
        }
    }
}
