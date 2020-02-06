using Core.Domain.Entities;
using Domain.Entities.UserAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.GameAggregate
{
    public class Game : IEntitySoft<int>
    {
        #region Properties
        public int Id { get; set; }
        public int Host1Id { get; set; }
        public User Host1 { get; set; }
        public int Host2Id { get; set; }
        public User Host2 { get; set; }
        public int Guest1Id { get; set; }
        public User Guest1 { get; set; }
        public int Guest2Id { get; set; }
        public User Guest2 { get; set; }
        public IEnumerable<Result> UsersMatchScore { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Disabled { get; set; } 
        #endregion
    }
}
