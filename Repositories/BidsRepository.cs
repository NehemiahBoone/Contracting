using System;
using System.Collections.Generic;
using System.Data;
using Contracting.Models;
using Dapper;

namespace Contracting.Repositories
{
  public class BidsRepository
  {
    private readonly IDbConnection _db;
    public BidsRepository(IDbConnection db)
    {
      _db = db;
    }
    internal void Create(Bid newBid)
    {
      string sql = @"
      INSERT INTO bids
      (bidId, jobId, contractorId, bidRate)
      VALUES
      (@BidId, @JobId, @ContractorId, @BidRate);";
      _db.Execute(sql, newBid);
    }

    internal void Delete(int id)
    {
      string sql = "DELETE FROM bids WHERE id = @id LIMIT 1;";
      _db.Execute(sql, new { id });
    }


    // ONLY USED AS A CHECK FOR DELETE BID IN THE SERVICE
    internal Bid GetById(int id)
    {
      string sql = "SELECT * FROM bids WHERE id = @id;";
      return _db.QueryFirstOrDefault<Bid>(sql, new { id });
    }

  }
}