﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeDetailsApp.Models;
using Microsoft.EntityFrameworkCore;
using EmployeeDetailsApp.PostViewModels;

namespace EmployeeDetailsApp.Repository
{
   public  interface IEmpRepository
    {
        public void AddEmployee(EmpDetails emp);
        public void UpdateEmployee(EmpDetails emp);
        EmpDetails GetEmployee(int id);

        public void DeleteEmployee(int id);
    }
}
