using Core.Domain.Entities;
using System;

namespace Domain.Entities.CourtAggregate
{
    public class CourtImage: IEntity<int>
    {
        #region Properties
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int CourtId { get; set; }
        public Court Court { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } 
        #endregion
    }
}
