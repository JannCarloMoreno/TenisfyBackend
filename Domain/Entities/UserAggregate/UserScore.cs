using Core.Domain.Entities;
using Domain.Enums;
using System;

namespace Domain.Entities.UserAggregate
{
    public class UserScore : IEntity<int>
    {
        #region Properties
        public int Id { get; set; }
        public UserScoreRank Value { get; set; }
        public string Comment { get; set; }
        public int EvaluatorId { get; set; }
        public User Evaluator { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        #endregion
    }
}
