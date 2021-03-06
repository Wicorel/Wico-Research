namespace WicoResearch
{
	public enum TechGroup
	{
        // thrusters
		AtmoThrusters=100,
        IonThrusters,
        HydrogenThrusters,

        // Gas generation
        OxygenGenerators=200,
		OxygenFarm,

        // Gas storage
        OxygenStorage=300,
        HydrogenStorage,

        // weapons
        BasicWeapons=400,
        Rockets,

        // production
        SurvivalKit=500,
        BasicRefineries,
        AdvancedRefineries,
        BasicAssemblers,
        AdvancedAssemblers,

        // gyros
        Gyros=600,

        // wheels
        SmallWheels=700,
        LargeWheels,

        // Rotors
        SmallRotors=800,
        LargeRotors,

        // Tools
        Drills=900,
        Welders,
        Grinders,

        //  power
        WindTurbines=1000,
        Batteries,
        SolarPanels,
        HydrogenEngines,
        SmallReactors,
        LargeReactors,

        // detection
        RadioAntennas = 1100,
        LaserAntennas,
        Beacons,
        Sensors,
        Cameras,

        // Advanced blocks
        Projectors = 2000,
        JumpDrives,

        //  Safezone and economy release
        SafeZone=2500,
        Economy,

        // gravity
        GravityGens=3000,
        ArtificialMass,

        ProgrammableBlock=4000,
        Timers,

        SgLightArmor=5000,
        SgHeavyArmor,
        LgLightArmor,
        LgHeavyArmor,

        // MOD (2020 Update!) Star Wars Weapons https://steamcommunity.com/sharedfiles/filedetails/?id=598138548
        StarWarsWeapons=9000,
        // MOD: Defense Shields - v1.91(3) https://steamcommunity.com/sharedfiles/filedetails/?id=1365616918
        DefenseShields,
        // Energy Shields. https://steamcommunity.com/sharedfiles/filedetails/?id=484504816
        EnergyShields,

        Permabanned = 9999 // Leave as last!
	}
}
 