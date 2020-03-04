using Formula1.Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Formula1.Core.Entities
{
    public class Driver : ICompetitor
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Name { get; }
        public string Nationality { get; }


        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
