using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetListWithReservationAwaitByAccepted(int id)
        {
            return _reservationDal.GetListWithReservationAwaitByAccepted(id);
        }

        public List<Reservation> GetListWithReservationAwaitByApproval(int id)
        {
           return  _reservationDal.GetListWithReservationAwaitByApproval(id);
        }

        public List<Reservation> GetListWithReservationAwaitByPrevious(int id)
        {
            return _reservationDal.GetListWithReservationAwaitByPrevious(id);
        }

        public void TAdd(Reservation t)
        {
             _reservationDal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation tGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
    }
}
