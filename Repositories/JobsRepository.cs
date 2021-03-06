using System;
using System.Collections.Generic;
using System.Data;
using Contracting.Models;
using Dapper;

namespace Contracting.Repositories
{
  public class JobsRepository
  {
    private readonly IDbConnection _db;
    public JobsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal IEnumerable<Job> GetAll()
    {
      string sql = @"
      SELECT
      j.*,
      prof.*
      FROM jobs j
      JOIN profiles prof ON j.creatorId = prof.id";
      return _db.Query<Job, Profile, Job>(sql, (job, profile) =>
      {
        job.Creator = profile;
        return job;
      }, splitOn: "id");
    }

    internal Job GetById(int id)
    {
      string sql = "SELECT * FROM jobs WHERE id = @id";
      return _db.QueryFirstOrDefault<Job>(sql, new { id });
    }

    internal Job Create(Job newJob)
    {
      string sql = @"
      INSERT INTO jobs
      (location, description, contact, hourlyPay, creatorId)
      VALUES
      (@Location, @Description, @Contact, @HourlyPay, @CreatorId);
      SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newJob);
      newJob.Id = id;
      return newJob;
    }

    internal Job Edit(Job updated)
    {
      string sql = @"
      UPDATE jobs
      SET
        contact = @Contact,
        location = @Location,
        description = @Description,
        hourlyPay = @HourlyPay,
        creatorId = @CreatorId
      WHERE id = @Id;";
      _db.Execute(sql, updated);
      return updated;
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM jobs WHERE id = @id";
      _db.Execute(sql, new { id });
    }

    internal IEnumerable<JobBidViewModel> GetJobsByContractorId(int id)
    {
      string sql = @"
      SELECT j.*, jb.id AS BidId
      FROM bids jb
      JOIN jobs j ON j.id = jb.jobId
      WHERE contractorId = @id
      ";
      return _db.Query<JobBidViewModel>(sql, new { id });
    }
  }
}