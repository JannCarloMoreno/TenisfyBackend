using Core.Domain.Entities;
using System;


namespace Domain.Entities.CourtAggregate
{
    public class CourtSchedule: IEntity<int>
    {
        #region Properties
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime BeginHour { get; set; }
        public DateTime EndHour { get; set; }
        public string Price { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } 
        #endregion
    }
}
