using System;
using System.Collections.Generic;
using Contracting.Models;
using Contracting.Repositories;

namespace Contracting.Services
{
  public class JobsService
  {
    private readonly JobsRepository _repo;
    public JobsService(JobsRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Job> GetAll()
    {
      return _repo.GetAll();
    }

    internal Job GetById(int id)
    {
      var data = _repo.GetById(id);
      if (data == null)
      {
        throw new Exception("Invalid dId");
      }
      return data;
    }

    internal Job Create(Job newJob)
    {
      return _repo.Create(newJob);
    }

    internal Job Edit(Job updated)
    {
      var data = GetById(updated.Id);

      if (data.CreatorId != updated.CreatorId)
      {
        throw new Exception("Invalid Edit Permissions");
      }

      updated.Location = updated.Location != null ? updated.Location : data.Location;
      updated.Description = updated.Description != null ? updated.Description : data.Description;
      updated.Contact = updated.Contact != null ? updated.Contact : data.Contact;

      return _repo.Edit(updated);
    }

    internal string Delete(int id, string userId)
    {
      var data = GetById(id);

      if (data.CreatorId != userId)
      {
        throw new Exception("Invalid Delete Permissions");
      }

      _repo.Delete(id);
      return "DELETED";
    }


    internal IEnumerable<JobBidViewModel> GetJobsByContractorId(int id)
    {
      return _repo.GetJobsByContractorId(id);
    }
  }
}