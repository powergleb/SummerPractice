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
        Task<Lot> GetLotById(int lotId);
        Task<ICollection<Lot>> GetLotsByPrice(double price);
        Task CreateLot(Lot lot);
        Task DeleteLot(int lotId);
        Task UpdateLot(int lotId);
    }
}
