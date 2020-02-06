using Core.Domain.Entities;
using Core.Domain.Interfaces;
using Domain.Entities.CourtAggregate;
using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Domain.Entities.UserAggregate
{
    public class User: IEntity<int>, IAggregateRoot
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public PlayerLevel Level { get; set; }
        public IEnumerable<UserScore> OwnScore { get; set; }
        public byte[] Photo { get; set; }
        public string Cellphone { get; set; }
        public DateTime Birthdate { get; set; }
        public Gender Gender { get; set; }
        public UserRole Role { get; set; }
        public IEnumerable<Court>? Courts { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } 
        #endregion
    }
}
