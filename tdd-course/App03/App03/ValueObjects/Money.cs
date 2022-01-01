using System;

namespace App03.ValueObjects
{
    public class Money : IEquatable<Money>
    {
        public int Value { get; }

        public Money(int value)
        {
            this.Value = value;
        }

        public Money Add(Money target)
        {
            var newValue = this.Value + target.Value;
            return new Money(newValue);
        }

        public Money Subtract(Money money)
        {
            var newValue = this.Value - money.Value;
            return new Money(newValue);
        }

        public bool Equals(Money other)
        {
            if (other is null) { return false; }
            if (this.Value.Equals(other.Value))
            {
                return true;
            }
            return false;
        }
    }
}
