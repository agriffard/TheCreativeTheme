using Microsoft.Extensions.Options;
using OrchardCore.ResourceManagement;

namespace TheCreativeTheme
{
    public class ResourceManagementOptionsConfiguration : IConfigureOptions<ResourceManagementOptions>
    {
        private static ResourceManifest _manifest;

        static ResourceManagementOptionsConfiguration()
        {
            _manifest = new ResourceManifest();

            _manifest
                .DefineScript("Creative")
                .SetDependencies("bootstrap") //, jQuery.easing
                .SetUrl("~/TheCreativeTheme/js/scripts.min.js", "~/TheCreativeTheme/js/scripts.js")
                .SetVersion("6.0.0");

            _manifest
                .DefineStyle("Creative")
                .SetUrl("~/TheCreativeTheme/css/styles.min.css", "~/TheCreativeTheme/css/styles.css")
                .SetVersion("6.0.0");
        }

        public void Configure(ResourceManagementOptions options)
        {
            options.ResourceManifests.Add(_manifest);
        }
    }
}
