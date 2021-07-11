using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALInterfaces
{
    public interface ILotRepo
    {
        Lot GetLotById(int lotId);
        ICollection<Lot> GetLotsByPrice(double price);
        void CreateLot(Lot lot);
        void DeleteLot(int lotId);
        void UpdateLot(int lotId);

        ICollection<Lot> GetPurchasedLots(double price);
        ICollection<Lot> GetSelledLots(double price);


    }
}
