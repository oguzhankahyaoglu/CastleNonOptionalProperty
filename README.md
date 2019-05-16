# CastleNonOptionalProperty
Instead of constructor injection pattern, when you use property injection, public property injection does not throw any exceptions when it cannot find any component and leaves the property with a null value, which then causes nullreference exceptions. 

Using this NonOptional attribute on properties, we will ensure injection for the specific component.


        public IRepository<CalculationMaster, long> CalculationMasterRepository { get; set; }
        [NonOptional] 
        public IRepository<CalculationVaultDailyLiquid, long> CalculationVaultDailyLiquidRepository { get; set; }

# Usage

Depending on the technology (.netcore or .net framework), you should use the extension method like:
        
        IocContainer.EnforceNonOptionalProperties();
        
And that is it! Wherever you define NonOptional attribute on a public property, it will be a requirement to be injected automatically.
