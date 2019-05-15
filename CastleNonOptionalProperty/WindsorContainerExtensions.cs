using System;
using System.Collections.Generic;
using System.Text;
using Castle.Windsor;

namespace CastleNonOptionalProperty
{
    public static class WindsorContainerExtensions
    {
        /// <inheritdoc cref="NonOptionalAttribute"/>
        public static IWindsorContainer EnforceNonOptionalProperties(this IWindsorContainer container)
        {
            container.AddFacility<NonOptionalPropertiesFacility>();
            return container;
        }
    }
}
