using Core.Domain.Entities;
using Domain.Entities.CourtAggregate;
using Domain.Entities.UserAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.GameAggregate
{
    public class Booking : IEntitySoft<int>
    {
        #region Properties
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int CourtScheduleId { get; set; }
        public CourtSchedule Schedule { get; set; }
        public string PaymentToken { get; set; }
        public string PaymentDescription { get; set; }
        public int CardId { get; set; }
        public Card Card { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Disabled { get; set; } 
        #endregion
    }
}
