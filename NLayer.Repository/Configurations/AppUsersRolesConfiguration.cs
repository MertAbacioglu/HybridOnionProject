using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    public class AppUsersRolesConfiguration : BaseConfiguration<AppUserLanguage>
    {
        public override void Configure(EntityTypeBuilder<AppUserLanguage> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new
            {
                x.LanguageID,
                x.AppUserID
            });
        }
    }
}
