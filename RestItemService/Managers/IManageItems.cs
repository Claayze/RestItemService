using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestItemService.Managers;
using ModelLib.Model;



namespace RestItemService.Managers
{
    public interface IManageItems
    {
        IEnumerable<FootBallPlayer> Get();
        FootBallPlayer Get(int id);
        bool Create(FootBallPlayer value);
        bool Update(int id, FootBallPlayer value);
        FootBallPlayer Delete(int id);
    }
}
