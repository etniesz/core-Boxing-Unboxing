List<object> objectsArray = new List<object>();
objectsArray.Add(7);
objectsArray.Add(28);
objectsArray.Add(-1);
objectsArray.Add(true);
objectsArray.Add("chair");

foreach (object obj in objectsArray)
{
    Console.WriteLine(obj);
}

int temp = 0;
for (int i = 0; i < objectsArray.Count; i++)
{
    if (objectsArray[i] is int)
    {
        temp = temp + (int)objectsArray[i];
    }

}

Console.WriteLine($"La suma total es: {temp}");
