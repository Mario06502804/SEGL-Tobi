# Einführung in Klassen in CSharp

## 1. Was sind Klassen?

- **Klassen als Baupläne:**
  Eine Klasse ist wie ein Bauplan, mit dem man Objekte (Instanzen) erstellt. Im Beispiel der Todo App definieren wir mit der `TodoItem`-Klasse, wie ein Todo aussehen soll (also welche Daten es enthält, z. B. Beschreibung und Priorität).

- **Abstraktion:**
  Klassen helfen dabei, komplexe Programme in handhabbare Teile zu zerlegen. So kannst du die Logik für die Benutzer-Interaktion (in `Program.cs`) und die Datenstruktur (in `TodoItem.cs`) sauber trennen.

## 2. Klassenmitglieder (Member)

Innerhalb einer Klasse kannst du verschiedene Elemente definieren:

- **Felder (Fields):**
  Diese speichern Daten, sind aber oft **privat** und nur innerhalb der Klasse sichtbar.
  Beispiel:
  ```csharp
  private int id;
  ```
  Felder kannst du nutzen, wenn du direkte Kontrolle über die Speicherung der Daten haben möchtest und keine zusätzliche Logik beim Lesen/Schreiben brauchst.

- **Properties:**
  Properties sind wie „Torwächter“ für Felder. Sie sind typischerweise **öffentlich** und erlauben dir, beim Zugriff auf die Daten Logik einzubauen (z. B. Validierungen).
  Beispiel aus der TodoItem-Klasse:
  ```csharp
  public string Description { get; set; }
  public int Prio { get; set; }
  ```
  Dadurch können andere Teile deines Programms (wie die Eingabe-/Ausgabe-Logik in `Program.cs`) sicher auf diese Daten zugreifen und diese bei Bedarf ändern.

- **Methoden:**
  Methoden sind Funktionen, die in der Klasse definiert werden. Sie kapseln Verhalten und Funktionalität. Zum Beispiel könntest du später in `TodoItem` eine Methode hinzufügen, um den Status eines Todos zu ändern.

## 3. Warum Properties statt direkter Felder?

- **Sicherheit und Kontrolle:**
  Mit Properties kannst du kontrollieren, wie auf die Daten zugegriffen wird. Du kannst z. B. sicherstellen, dass der Wert nie negativ ist oder automatisch zusätzliche Aktionen auslösen.
- **Lesbarkeit und Wartbarkeit:**
  Du kannst die interne Darstellung ändern, ohne dass der Aufrufer (der Code, der die Klasse nutzt) etwas anpassen muss.

## 4. Instanziierung (Objekte erstellen) und Konstruktoren

- **Instanziierung:**
  Um ein Objekt zu nutzen, musst du es instanziieren.
  Beispiel:
  ```csharp
  TodoItem meinTodo = new TodoItem();
  meinTodo.Description = "Hausaufgaben machen";
  meinTodo.Prio = 1;
  ```
- **Konstruktoren:**
  Konstruktoren sind spezielle Methoden, die beim Erstellen eines Objekts aufgerufen werden. Du kannst sie nutzen, um Objekte direkt initialisiert zu erstellen.
  Beispiel:
  ```csharp
  public class TodoItem
  {
      public string Description { get; set; }
      public int Prio { get; set; }

      // Konstruktor
      public TodoItem(string description, int prio)
      {
          Description = description;
          Prio = prio;
      }
  }
  // Instanziierung mit Konstruktor:
  TodoItem meinTodo = new TodoItem("Hausaufgaben machen", 1);
  ```

## 5. Statische vs. Instanz-Mitglieder

- **Instanz-Mitglieder:**
  Jedes Objekt einer Klasse hat seine eigenen Werte für Instanz-Mitglieder. Beispiel: Jedes erstellte `TodoItem`-Objekt hat seine eigene Beschreibung und Priorität.

- **Statische Mitglieder:**
  Diese gehören zur Klasse selbst und nicht zu einzelnen Objekten. Sie sind nützlich, wenn alle Objekte den gleichen gemeinsamen Wert oder die gleiche Logik teilen sollen.
  Beispiel:
  ```csharp
  public class TodoItem
  {
      public static int TotalTodos;
      // Bei jedem Erstellen eines TodoItems könntest du TotalTodos erhöhen.
  }
  ```

## 6. Zusammenfassung

- **Klassen:**
  Dienen als Bauplan für Objekte und helfen dabei, Daten und Verhalten zu strukturieren.
- **Felder & Properties:**
  Felder speichern intern Daten, während Properties den kontrollierten Zugriff auf diese Daten ermöglichen.
- **Methoden:**
  Erlauben es, Verhalten in der Klasse zu kapseln.
- **Instanziierung & Konstruktor:**
  Durch Instanziierung werden Objekte erstellt; Konstruktoren sorgen für die anfängliche Einrichtung dieser Objekte.
- **Statisch vs. Instanz:**
  Statische Mitglieder gehören zur Klasse als Ganzes, während Instanz-Mitglieder zu jedem einzelnen Objekt gehören.
