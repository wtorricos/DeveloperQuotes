using System.Security.Cryptography;

namespace DeveloperQuotes.Domain.Quotes;

public sealed class QuoteFactory
{
    public QuoteModel GetRandomQuote()
    {
        int number = RandomNumberGenerator.GetInt32(InMemoryQuoteList.Quotes.Count);
        return InMemoryQuoteList.Quotes[number];
    }
}
