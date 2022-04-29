﻿using DevFreela.Core.Enums;
using System;
using System.Collections.Generic;

namespace DevFreela.Core.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreelancer, decimal totalCost)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;

            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnums.Created;
            Comments = new List<ProjectComment>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? StartedAt { get; private set; }
        public DateTime? FinishedAt { get; private set; }
        public ProjectStatusEnums Status { get; set; }
        public List<ProjectComment> Comments { get; set; }

        public void Cancel()
        {
            if (Status == ProjectStatusEnums.InProgress || Status == ProjectStatusEnums.InProgress)
            {
                Status = ProjectStatusEnums.Cancelled;
            }
        }

        public void Finish()
        {
            if(Status == ProjectStatusEnums.InProgress)
            {
                Status = ProjectStatusEnums.Finished;
                FinishedAt = DateTime.Now;
            }
        }

        public void Start()
        {
            if (Status == ProjectStatusEnums.Created)
            {
                Status = ProjectStatusEnums.InProgress;
                StartedAt = DateTime.Now;
            }
        }

        public void Update(string title, string description, decimal totalCost)
        {
            Title = title;
            Description = description;
            TotalCost = totalCost;
        }


    }
}
