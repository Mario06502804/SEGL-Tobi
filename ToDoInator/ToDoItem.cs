// Klasse = Eigener Datentyp 
public class ToDoItem
{
    // KLassen definieren Variablen (Daten) und Methoden (Funktionalität)
    // Variablen könne Felder (Fields) oder Eigenschaften (Properties) sein
    // Felder sind Privat  --> Klassenintern
    // Eigenschaften ist public --> Kann von ausen aufgerufen werden 
    public string Description { get; set; }
    public int Prio { get; set; }


    // instanz-Methode => myTodo.ToString();
    public override string ToString()
    {
        return $"{Description} - {Prio}";
    }
}

