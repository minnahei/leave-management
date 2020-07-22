﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using leave_management.Contracts;
using leave_management.Data;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public Task<bool> CheckAllocation(int leavetypeid, string employeeid)
        {
            throw new NotImplementedException();
        }

        public bool Create(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            throw new NotImplementedException();
        }

        public LeaveAllocation FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<LeaveAllocation>> GetLeaveAllocationsByEmployee(string employeeid)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> GetLeaveAllocationsByEmployeeAndType(string employeeid, int leavetypeid)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}
