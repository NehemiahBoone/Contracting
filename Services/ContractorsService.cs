using System;
using System.Collections.Generic;
using Contracting.Models;
using Contracting.Repositories;

namespace Contracting.Services
{
  public class ContractorsService
  {
    private readonly ContractorsRepository _repo;
    public ContractorsService(ContractorsRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Contractor> GetAll()
    {
      return _repo.GetAll();
    }

    internal Contractor GetById(int id)
    {
      var data = _repo.GetById(id);
      if (data == null)
      {
        throw new Exception("Invalid Id");
      }
      return data;
    }

    internal Contractor Create(Contractor newContractor)
    {
      return _repo.Create(newContractor);
    }

    internal Contractor Edit(Contractor updated)
    {
      var data = GetById(updated.Id);

      updated.Name = updated.Name != null ? updated.Name : data.Name;
      updated.Address = updated.Address != null ? updated.Address : data.Address;
      updated.Contact = updated.Contact != null ? updated.Contact : data.Contact;
      updated.Skills = updated.Skills != null ? updated.Skills : data.Skills;

      return _repo.Edit(updated);
    }

    internal string Delete(int id)
    {
      var data = GetById(id);
      _repo.Delete(id);
      return "DELETED";
    }
  }
}