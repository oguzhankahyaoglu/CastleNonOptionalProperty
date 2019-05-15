using Castle.MicroKernel.Facilities;

namespace CastleNonOptionalProperty
{
    internal class NonOptionalPropertiesFacility : AbstractFacility
    {
        protected override void Init()
        {
            Kernel.ComponentModelBuilder.AddContributor(new NonOptionalPropertyComponentModelHelper());
        }
    }
}
