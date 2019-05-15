using System.Linq;
using Castle.Core;
using Castle.MicroKernel;
using Castle.MicroKernel.ModelBuilder;

namespace CastleNonOptionalProperty
{
    internal class NonOptionalPropertyComponentModelHelper : IContributeComponentModelConstruction
    {
        public void ProcessModel(IKernel kernel, ComponentModel model)
        {
            foreach(var property in model.Properties)
            {
                if(property.Property.GetCustomAttributes(inherit: true).Any(x => x is NonOptionalAttribute))
                {
                    property.Dependency.IsOptional = false;
                }
            }
        }
    }
}