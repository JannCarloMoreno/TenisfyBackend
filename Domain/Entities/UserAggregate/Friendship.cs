using Core.Domain.Entities;
using Domain.Enums;
using System;

namespace Domain.Entities.UserAggregate
{
    public class Friendship : IEntity<int>
    {
        #region Properties
        public int Id { get; set; }
        public int UserAId { get; set; }
        public int UserBId { get; set; }
        public User UserA { get; set; }
        public User UserB { get; set; }
        public Relation Relation { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } 
        #endregion

    }
}
