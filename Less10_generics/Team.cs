using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less10_generics;

internal class Team:IEnumerable<Player>
{
    public string? Name { get; set; }
    private List<Player> players = new List<Player>();
    public void AddPlayer(Player player)
    {
        players.Add(player);
    }

    public void Sorting()
    {
        players.Sort();
    }

    public IEnumerator<Player> GetEnumerator()
    {
        return players.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Team(string name)
    {
        Name = name;
    }
}
