
using BenchmarkDotNet.Attributes;
public class Algorithms
{
    int[] cards; //deklaratione
    public Algorithms()
    {
        cards = new int[50000000]; // inizialisierung
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = i + 1;
        }
    }
    // Binary Search => O(log(n))
    [Benchmark]
    public void TestBinarySearch()
    {
        FindCardLocationBinarySearch(cards, 49_942_069); // 49_942_068
    }
    [Benchmark]
    public void TestLinearySearch()
    {
        FindCardLocationLinearSearch(cards, 49_942_069); // 49_942_068
    }
    public static int FindCardLocationBinarySearch(int[] cards, int query)
    {
        int min = 0;
        int max = cards.Length - 1;

        while (min <= max)
        {
            int mid = (min + max) / 2;

            if (query == cards[mid])
            {
                return mid;
            }
            else if (query < cards[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return -1;
    }

    // Linear Search => O(n)

    public static int FindCardLocationLinearSearch(int[] cards, int query)
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





