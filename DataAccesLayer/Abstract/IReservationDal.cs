using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {

        List<Reservation> GetListWithReservationAwaitByApproval(int id);
        List<Reservation> GetListWithReservationAwaitByAccepted(int id);
        List<Reservation> GetListWithReservationAwaitByPrevious(int id);

    }
}
