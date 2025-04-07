int[] cards = [3, 5, 7, 8, 9];
int query = 7;
var result = FindCardLocation(cards, query);
Console.WriteLine(result);

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
        index++; // index = index +1;

    }
    return -1;
}