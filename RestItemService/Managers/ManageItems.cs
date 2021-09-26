using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestItemService.Managers;
using ModelLib.Model;





namespace RestItemService.Managers
{

    class ManageItems : IManageItems

    {
    private static List<FootBallPlayer> FBPlayers = new List<FootBallPlayer>()
    {
        new FootBallPlayer("Mike Johnson", 25000, 10, 1),
        new FootBallPlayer("John Doe", 10000, 7, 2),
        new FootBallPlayer("Mike Wasowski", 1000, 24, 3),
        new FootBallPlayer("Tom Brady", 1000000, 1, 4)

    };

    public IEnumerable<FootBallPlayer> Get()
    {
        return new List<FootBallPlayer>(FBPlayers);
    }

    public FootBallPlayer Get(int id)
    {
        return FBPlayers.Find(f => f.Id == id);
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public FootBallPlayer Delete(int id)
    {
        FootBallPlayer footBallPlayer = Get(id);
        FBPlayers.Remove(footBallPlayer);
        return footBallPlayer;
    }


    public bool Update(int id, FootBallPlayer value)
    {
        FootBallPlayer footBallPlayer = Get(id);
        if (footBallPlayer != null)
        {
            footBallPlayer.Id = value.Id;
            footBallPlayer.Name = value.Name;
            footBallPlayer.Price = value.Price;
            footBallPlayer.ShirtNumber = value.ShirtNumber;

            return true;
        }

        return false;
    }

    public bool Create(FootBallPlayer value)
    {
        FBPlayers.Add(value);
        return true;
    }

    }
}
