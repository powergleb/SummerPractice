using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLInterfaces
{
    public interface ILotLogic
    {
        Lot GetLotById(int lotId);
        void CreateLot(Lot lot);
        void DeleteLot(int lotId);
        void UpdateLot(int lotId, string description, double startingPrice, DateTime expirationDate);
        ICollection<Lot> GetLotsByBet(Double bet);

    }
}
