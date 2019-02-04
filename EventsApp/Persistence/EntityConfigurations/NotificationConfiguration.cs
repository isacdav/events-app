using EventsApp.Core.Models;
using System.Data.Entity.ModelConfiguration;

namespace EventsApp.Persistence.EntityConfigurations
{
    public class NotificationConfiguration : EntityTypeConfiguration<Notification>
    {
        public NotificationConfiguration()
        {
            HasRequired(n => n.Gig);
        }
    }
}