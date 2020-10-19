using System;
using System.Collections.Generic;
using System.Data;
using Contracting.Models;

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
      throw new NotImplementedException();
    }

    internal object GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal Job Create(Job newJob)
    {
      throw new NotImplementedException();
    }

    internal Job Edit(Job updated)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}