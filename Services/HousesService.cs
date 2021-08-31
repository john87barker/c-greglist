using System;
using System.Collections.Generic;
using c_greglist.Model;

namespace c_greglist.Services
{
    public class HousesService
    {
        internal IEnumerable<House> Get()
    {
      return FakeDB.Houses;
    }
    internal House Get(string id)
    {
      House found = FakeDB.Houses.Find(c => c.Id == id);
      if(found == null)
      {
        throw new Exception("invalid ID");
      }
      return found;
    }
    internal House Create(House newHouse)
    {
      FakeDB.Houses.Add(newHouse);
      return newHouse;
    }

    internal void Delete(string id)
    {
      int deleted = FakeDB.Houses.RemoveAll(h => h.Id == id);
      if(deleted == 0)
      {
        throw new Exception("invalid ID");
      }
    }



    }
}