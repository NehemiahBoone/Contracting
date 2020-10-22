using System;
using Contracting.Repositories;

namespace Contracting.Services
{
  public class ReviewsService
  {
    private readonly ReviewsRepository _repo;
    private readonly ContractorsRepository _contractorsRepo;
    public ReviewsService(ReviewsRepository repo, ContractorsRepository contractorsRepo)
    {
      _repo = repo;
      _contractorsRepo = contractorsRepo;
    }
    internal object GetById(int id)
    {
      var data = _repo.GetById(id);

      if (data == null)
      {
        throw new Exception("Invalid Id");
      }

      return data;
    }
  }
}