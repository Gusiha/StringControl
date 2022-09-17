#define PRINT
using StringControl;

StringList Example = new("random");
Example.Insert("Shall I Say");
Example.Delete(2);
Example.Update(2, "Changed");
Console.WriteLine(Example.GetAt(10));

#if PRINT
    for (int i = 0; i < Example.strings.Length; i++)
    {
        Console.WriteLine($"[{i}]: {Example.strings[i]}");
    }
#endif



