using System;
using InsuranceAdministration.GrainInterfaces;

namespace InsuranceAdministration.Grains
{
    internal class Coverage : ICoverage
    {
        public Guid Id { get; set; }
        public string CoverageCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IOwnRisk OwnRisk { get; set; }
        public string InsuredPerson { get; set; }
    }
}