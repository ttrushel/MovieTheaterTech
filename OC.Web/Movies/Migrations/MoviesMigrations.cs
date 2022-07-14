using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;

namespace Movies.Migrations
{
    public class MoviesMigrations : DataMigration
    {
        IContentDefinitionManager _contentDefinitionManager;

        public MoviesMigrations(IContentDefinitionManager contentDefinitionManager)
        {
            _contentDefinitionManager = contentDefinitionManager;
        }

        public int Create()
        {
            _contentDefinitionManager.AlterPartDefinition("MoviePart", builder => builder
                .Attachable()
                .WithDescription("Provides a Movie part for your content item."));

            return 1;
        }
    }
}
