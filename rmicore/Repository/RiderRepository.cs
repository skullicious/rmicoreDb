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

        public bool AddAddressToDatabase(Address address)
        {
            bool blSuccess = true;
            try
            {
                if (address == null)
                    return false;
                else
                    _db.Address.Add(address);
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

        public bool AddEmailToDatabase(Email email)
        {
            bool blSuccess = true;
            try
            {
                if (email == null)
                    return false;
                else
                    _db.Email.Add(email);  // KEY ISSUE HERE TAKE A LOOK
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

        public bool AddOccupationToDatabase(RiderOccupation occupation)
        {
            bool blSuccess = true;
            try
            {
                if (occupation == null)
                    return false;
                else
                    _db.RiderOccupations.Add(occupation);  // KEY ISSUE HERE TAKE A LOOK
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


        public bool AddPhoneNumberToDatabase(PhoneNumber phoneNumber)
        {
            bool blSuccess = true;
            try
            {
                if (phoneNumber == null)
                    return false;
                else
                {
                   
                    _db.PhoneNumbers.Add(phoneNumber);
                  
                    _db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //Logger.Error("Failed AddIndividualToDatabase\n" + ex);
                //Logger.Error(ex.GetAllMessages());
                blSuccess = false;
            }
            return blSuccess;
        }


        public bool AddRiderCycleUseToDatabase(RiderCycleUse cycleUse)
        {
            bool blSuccess = true;
            try
            {
                if (cycleUse == null)
                    return false;
                else
                {

                    _db.RiderCycleUse.Add(cycleUse);

                    _db.SaveChanges();
                }
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


        public Address GetAddressById(int riderId)
        {
            return _db.Address.FirstOrDefault(s => s.UserId == riderId);
        }

        public Email GetEmailById(int riderId)
        {
            return _db.Email.FirstOrDefault(s => s.UserId == riderId);

         
        }

        public PhoneNumber GetPhoneNumberById(int riderId)
        {
           
            return _db.PhoneNumbers.FirstOrDefault(s => s.UserId == riderId);

         

        }

        public RiderOccupation GetOccupationById(int riderId)
        {

            return _db.RiderOccupations.FirstOrDefault(s => s.UserId == riderId);



        }

        public RiderCycleUse GetCycleUseById(int riderId)
        {

            return _db.RiderCycleUse.FirstOrDefault(s => s.UserId == riderId);



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
