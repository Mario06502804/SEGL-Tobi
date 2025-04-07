int[] cards = [3, 5, 7, 8, 9];
int[] cards2 = new int[50000000];
// 50_000_000
// 25_000_000
// 12_500_000
// 6_250_000
for (int i = 0; i < cards2.Length; i++)
{
    cards2[i] = i + 1;
}

// int[] cards = {3, 5, 7, 8, 9};
int query = 7;

var result = FindCardLocation(cards, query);
Console.WriteLine(result);
Console.WriteLine(cards2[10]);
var result2 = FindCardLocation(cards2, 40_942_069);
Console.WriteLine(result2); // 4_942_070

// Binary Search => O(log(n))
//int FindCardLocationBinarySearch(int[] cards, int query)


// Linear Search => O(n)
int FindCardLocation(int[] cards, int query)
{
    /*
    Definiere Variable "index" und initialisiere mit Wert 0
    Wiederhole bis "index" gleich "cards" length:
        Wenn "cards" an "index" gleich "query", dann:
            Gebe "index" zurück
    Inkrementiere "index" um 1
    */
    int index = 0;
    while (index < cards.Length)
    {
        if (cards[index] == query)
            return index;
        index++; // index = index + 1;
    }
    return -1;
}
