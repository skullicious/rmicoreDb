using Microsoft.AspNetCore.Connections;
using rmicore.Entities;
using rmicore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rmicore.Repository
{
    public class RiderRepository : IRiderRepository
    {

        private readonly RepositoryContext _db;
        public RiderRepository(RepositoryContext connection)
        {
            _db = connection;
        }

        public User GetRiderById(int riderId)
        {
            return _db.Users.Find(riderId);
        }


        public bool AddIndividualToDatabase(Individual individual)
        {
            bool blSuccess = true;
            try
            {
                if (individual == null)
                    return false;
                else
                    _db.Individual.Add(individual);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                //Logger.Error("Failed AddIndividualToDatabase\n" + ex);
                //Logger.Error(ex.GetAllMessages());
                blSuccess = false;
            }
            return blSuccess;
        }

        public Individual GetIndividualById(int riderId)
        {
            return _db.Individual.FirstOrDefault(s => s.UserId == riderId);
        }


        public bool EditObjectInDatabase(object dbValues, object table)
        {
            bool blSuccess = true;
            try
            {
                _db.Entry(dbValues).CurrentValues.SetValues(table);
                if (_db.ChangeTracker.HasChanges())
                    _db.SaveChanges();
            }
            //catch (DbEntityValidationException ex)
            //{
            //Logger.Error("Failed Entities in SaveTableInDatabase\n" + Em.EntityErrorCapture(ex));
            //blSuccess = false;
            //}
            catch (Exception ex)
            {
                //Logger.Error("Failed SaveTableInDatabase\n" + ex);
                //Logger.Error(ex.GetAllMessages());
                //blSuccess = false;
            }
            return blSuccess;
        }
    }
}
