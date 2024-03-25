﻿using group8my.Models;


namespace group8my.Services
{
    public interface IJobSeekerRepository
    {
        bool SaveChanges();
        IEnumerable<JobSeekers> GetAllJobSeekers();
        JobSeekers GetJobSeekerById(string SeekerId);
        void CreateJobSeeker(JobSeekers jobSeeker); //POST
        void UpdateJobSeeker(JobSeekers jobSeeker); //PUT
        void DeleteJobSeeker(JobSeekers jobSeeker);

    }
}
