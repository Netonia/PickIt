namespace PickIt.Services;

public class DrawService
{
    private readonly Random _random = new();

    public string? DrawRandom(IList<string> items)
    {
        if (items == null || items.Count == 0)
            return null;

        var index = _random.Next(items.Count);
        return items[index];
    }

    public List<string> ParseItems(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return new List<string>();

        // Split by comma or newline, trim whitespace, and remove empty entries
        var items = input
            .Split(new[] { ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(item => item.Trim())
            .Where(item => !string.IsNullOrWhiteSpace(item))
            .ToList();

        return items;
    }
}