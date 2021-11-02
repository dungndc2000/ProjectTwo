﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Four.Entity
{
    public class BaseEntityIDInt
    {
        public BaseEntityIDInt()
        {
            Status = Status.Active;
            CreateDate = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid? CreateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateBy { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Active = 0,
        UnActive = 1,
        Delete = 2
    }
}
