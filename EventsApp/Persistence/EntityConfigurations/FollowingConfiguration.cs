using EventsApp.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace EventsApp.Persistence.EntityConfigurations
{
    public class FollowingConfiguration : EntityTypeConfiguration<Following>
    {
        public FollowingConfiguration()
        {
            HasKey(a => new { a.FollowerId, a.FolloweeId });
        }
    }
}