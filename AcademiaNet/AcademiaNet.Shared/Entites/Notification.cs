﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaNet.Shared.Entites
{
    public class Notification
    {
        [Key]
        public int NotificationID { get; set; }

        [Required]
        public int UserID { get; set; }

        public User User { get; set; } = null!;

        [Required]
        public int PeriodID { get; set; }

        public EnrollmentPeriod EnrollmentPeriod { get; set; } = null!;
    }
}