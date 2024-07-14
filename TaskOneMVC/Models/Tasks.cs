﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskOneMVC.Models
{
    public class Tasks
    {

        public int TasksId { get; set; }

        public string Title { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        public string ImportanceLevel { get; set; }

        public int? EmployeeID { get; set; }

        [ForeignKey("EmployeeID")]
        public Employees Employee { get; set; }
    }
}