using System;

class Item
{
    string Name;

    public Item(string name) { this.Name = name; }

    public override string ToString() { return Name; }
}