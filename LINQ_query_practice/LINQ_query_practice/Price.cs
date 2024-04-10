﻿

namespace LINQ_query_practice
{
    public readonly struct Price(decimal amount, CurrencyEnum currency)
    {
        
        public readonly decimal Amount { get; init; } = amount;
        public readonly CurrencyEnum Currency { get; init; } = currency;
        public override string ToString()
        => $"{Amount} {Currency}";

        

    }


}
