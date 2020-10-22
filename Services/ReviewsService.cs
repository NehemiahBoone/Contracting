using System;
using System.Collections.Generic;
using Contracting.Models;
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
    internal Review GetById(int id)
    {
      var data = _repo.GetById(id);

      if (data == null)
      {
        throw new Exception("Invalid Id");
      }

      return data;
    }

    internal IEnumerable<Review> GetReviewsByContractorId(int id)
    {
      var contractor = _contractorsRepo.GetById(id);

      if (contractor == null)
      {
        throw new Exception("Invalid Id");
      }

      return _repo.GetReviewsByContractorId(id);
    }
  }
}