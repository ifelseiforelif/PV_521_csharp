using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10_generics;

internal class Player:IComparable<Player>
{
    public string? Name { get; set; }
    public int Number { get; set; }
    public Player()
    {
        
    }
    public Player(string name, int num)
    {
        Name = name;
        Number = num;
    }
    public override string ToString()
    {
        return $"Player - {Number}:{Name} ";
    }

    public int CompareTo(Player? other)
    {
        if(other == null) return 1 ;
        return string.Compare(other.Name, this.Name, StringComparison.OrdinalIgnoreCase); //Alex alex -> 0
    }
}
//Додати у Shop метод сортування продуктів за назвою