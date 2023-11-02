using System.Security.Cryptography;

namespace DeveloperQuotes.Domain.Quotes;

public sealed class QuoteFactory
{
    public QuoteModel GetRandomQuote()
    {
        int number = RandomNumberGenerator.GetInt32(InMemoryQuoteList.Quotes.Count);
        return InMemoryQuoteList.Quotes[number];
    }

    public QuoteModel GetQuoteById(int id) =>
        InMemoryQuoteList.Quotes.FirstOrDefault(q => q.Id == id)
        ?? throw new ArgumentException($"Quote {id} not found");
}
