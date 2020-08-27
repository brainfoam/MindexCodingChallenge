//Written by Joseph Aquiare for the Mindex coding challenge.

using challenge.Models;
using System;

namespace challenge.Services
{
    public interface ICompensationService
    {
        Compensation GetById(String id);
        Compensation Create(Compensation compensation);
        Compensation Replace(Compensation originalCompensation, Compensation newCompensation);
    }
}