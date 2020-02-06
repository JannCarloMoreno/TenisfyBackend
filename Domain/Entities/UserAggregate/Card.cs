using Core.Domain.Entities;
using Domain.Enums;
using System;

namespace Domain.Entities.UserAggregate
{
    public class Card : IEntitySoft<int>
    {
        #region Properties
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string LastDigits { get; set; }
        public CardType Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Disabled { get; set; }
        #endregion
    }
}
