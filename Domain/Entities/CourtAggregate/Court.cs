using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Domain.Entities.UserAggregate;
using System;
using System.Collections.Generic;

namespace Domain.Entities.CourtAggregate
{
    public class Court: IEntitySoft<int>, IAggregateRoot
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<CourtImage> Images { get; set; }
        public IEnumerable<CourtScore> Scores { get; set; }
        public int Ownerid { get; set; }
        public User Owner { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool Disabled { get; set; } 
        #endregion

    }
}
