# CastleNonOptionalProperty
Instead of constructor injection pattern, when you use property injection, public property injection does not throw any exceptions when it cannot find any component and leaves the property with a null value, which then causes nullreference exceptions. 

Using this NonOptional attribute on properties, we will ensure injection for the specific component.


        public IRepository<CalculationMaster, long> CalculationMasterRepository { get; set; }
        [Mandatory] 
        public IRepository<CalculationVaultDailyLiquid, long> CalculationVaultDailyLiquidRepository { get; set; }
