using Core.Domain.Entities;
using Domain.Entities.UserAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.GameAggregate
{
    public class Result : IEntitySoft<int>
    {
        #region Properties
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int GuestScore { get; set; }
        public int HostScore { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Disabled { get; set; } 
        #endregion
    }
}
