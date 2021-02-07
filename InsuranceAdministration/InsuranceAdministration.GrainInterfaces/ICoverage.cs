using System;

namespace InsuranceAdministration.GrainInterfaces
{
    public interface ICoverage
    {
        Guid Id { get; }
        string CoverageCode { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        IOwnRisk OwnRisk { get; }
        string InsuredPerson { get; }
    }
}