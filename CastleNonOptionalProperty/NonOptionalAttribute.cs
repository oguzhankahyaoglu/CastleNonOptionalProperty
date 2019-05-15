using System;

namespace CastleNonOptionalProperty
{
    /// <summary>
    /// Property Injection durumunda Castle'ın property'yi inject edemediği durumda hata fırlatmasını sağlar. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=false)]
    public class NonOptionalAttribute : Attribute { }
}