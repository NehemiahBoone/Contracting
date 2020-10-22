using System;
using System.Collections.Generic;
using System.Data;
using Contracting.Models;
using Dapper;

namespace Contracting.Repositories
{
  public class ReviewsRepository
  {
    private readonly IDbConnection _db;
    public ReviewsRepository(IDbConnection db)
    {
      _db = db;
    }

    internal Review GetById(int id)
    {
      string sql = "SELECT * FROM reviews WHERE id = @id LIMIT 1";
      return _db.QueryFirstOrDefault<Review>(sql, new { id });
    }

    internal IEnumerable<Review> GetReviewsByContractorId(int id)
    {
      string sql = "SELECT * FROM reviews WHERE contractorId = @id";

      return _db.Query<Review>(sql, new { id });
    }
  }
}