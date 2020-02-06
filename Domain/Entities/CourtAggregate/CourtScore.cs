using Core.Domain.Entities;
using Domain.Enums;
using System;

namespace Domain.Entities.CourtAggregate
{
    public class CourtScore : IEntity<int>
    {
        #region Properties
        public int Id { get; set; }
        public CourtScoreRank Value { get; set; }
        public string Comment { get; set; }
        public int CourtId { get; set; }
        public Court Court { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } 
        #endregion
    }
}
