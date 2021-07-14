using BLLInterfaces;
using DALInterfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLCLasses
{
    public class LotLogic : ILotLogic
    {
        private readonly ILotRepo _lotRepository;
        public LotLogic(ILotRepo lotRepository)
        {
            _lotRepository = lotRepository;
        }

        public void CreateLot(Lot lot)
        {
            _lotRepository.CreateLot(lot);
        }

        public void DeleteLot(int lotId)
        {
            _lotRepository.DeleteLot(lotId);

        }

        public Lot GetLotById(int lotId)
        {
            return _lotRepository.GetLotById(lotId);
        }

        public ICollection<Lot> GetLotsByBet(double bet)
        {
            return _lotRepository.GetLotsByBet(bet);
        }

        public void UpdateLot(int lotId, string description, double startingPrice, DateTime expirationDate)
        {
            _lotRepository.UpdateLot(lotId, description, startingPrice, expirationDate);
        }
    }
}
