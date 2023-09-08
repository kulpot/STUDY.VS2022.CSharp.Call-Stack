using System;

//ref link:https://www.youtube.com/watch?v=s9rFgc6vGrc&list=PLRwVmtr-pp07XP8UBiUJ0cyORVCmCgkdA&index=42
// LIFO -- last in first out
// Stack -- LIFO 
// GC(garbageCollection) -- work only on heap but stack is immune

struct CountingClass
{
    static short counter = 0;
    short id;
    char c;
    public CountingClass()
    {
        id = counter;
        c = (char)(((short)'a') + counter);
        counter++;
    }
}

class MainClass
{
    static void Main()
    {
        Recurse(3);


        //GC.Collect();
        //var c1 = new CountingClass();
        //var c2 = new CountingClass();
        //var c3 = new CountingClass();
        //var c4 = new CountingClass();
        //var c5 = new CountingClass();
        //GC.Collect();
        //c4 = null; // error for value type stack
    }
    static void Recurse(int i)      //recursions - good for tree data structures
    {
        CountingClass c = new CountingClass();
        if (i == 0)
            return;
        Recurse(i - 1);
    }
}