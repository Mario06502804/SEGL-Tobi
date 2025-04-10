using BenchmarkDotNet.Attributes;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsWPF;

public class Algorithms
{
    int[] cards; // Deklaration
    int[] unsortedArray;
    public Algorithms()
    {
        cards = new int[50_000_000]; // Initialisierung
        for (int i = 0; i < cards.Length; i++)
        {
            cards[i] = i + 1;
        }
        // create large unsorted array with random numbers
        Random random = new Random();
        unsortedArray = new int[5_000];
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            unsortedArray[i] = random.Next(1, 100_000);
        }
    }
    [Benchmark]
    public void TestInsertionSort()
    {
        InsertionSort(unsortedArray); // O(n^2)
    }
    // Binary Search => O(log(n))
    [Benchmark]
    public void TestBinarySearch()
    {
        FindCardLocationBinarySearch(cards, 49_942_069); // 49_942_068
    }
    [Benchmark]
    public void TestLinearSearch()
    {
        FindCardLocationLinearSearch(cards, 49_942_069); // 49_942_068
    }
    public static int[] InsertionSort(int[] unsortedArray)
    {
        /*
        Definiere Variable "i" und initialisiere mit Wert 1
        Wiederhole bis "i" gleich "unsortedArray" length:
            Definiere Variable "j" und initialisiere mit Wert i - 1
            Definiere Variable "key" und initialisiere mit Wert "unsortedArray" an "i"
            Wiederhole bis "j" größer oder gleich 0 und "unsortedArray" an "j" größer als "key":
                Setze "unsortedArray" an "j + 1" gleich "unsortedArray" an "j"
                Dekrementiere j um 1
            Setze "unsortedArray" an "j + 1" gleich key
            Inkrementiere i um 1
        */
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

}
