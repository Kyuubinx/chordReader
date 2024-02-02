List<string> NotesSharp = new List<string> { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
List<string> NotesFlat = new List<string> { "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B" };
List<string> Intervals = new List<string> { "", "2m", "2", "m", "3", "4", "4+", "5", "5+", "6", "7", "7+", };

string Note1, Note2, Note3, OutNote2, OutNote3;
int AltFunc, AltFunc2, AltFunc3;

Console.WriteLine("Power Chord reader");
Console.WriteLine();
Console.WriteLine("Input the 1st note of the Power Chord");
Note1 = Console.ReadLine().ToUpper();
Console.WriteLine("Input the 2nd note of the Power Chord");
Note2 = Console.ReadLine().ToUpper();
Console.WriteLine("Input the 3nd note of the Power Chord");
Note3 = Console.ReadLine().ToUpper();

AltFunc = NotesSharp.IndexOf(Note1);

if (AltFunc == -1)
{
    AltFunc = NotesFlat.IndexOf(Note1);
}

AltFunc2 = NotesSharp.IndexOf(Note2);

if (AltFunc2 == -1)
{
    AltFunc2 = NotesFlat.IndexOf(Note2);
}

if (AltFunc2 < AltFunc)

    AltFunc2 = 12 - (11 - AltFunc2);

AltFunc3 = NotesSharp.IndexOf(Note3);

if (AltFunc3 == -1)
{
    AltFunc3 = NotesFlat.IndexOf(Note3);
}

if (AltFunc3 < AltFunc)

    AltFunc3 = 12 - (11 - AltFunc3);

OutNote2 = Intervals[AltFunc2];
OutNote3 = Intervals[AltFunc3];

Console.WriteLine();
if (OutNote3 == Intervals[0])
{
    Console.WriteLine("Power Chord: " + Note1 + OutNote2 + OutNote3);
}

else
{
    Console.WriteLine("Power Chord: " + Note1 + OutNote2 + "(" + OutNote3 + ")");
}

Console.ReadKey();
