using System.Collections.Generic;
using Duckroll;
using Sandbox.Game;
using Sandbox.ModAPI;
using VRage.Game;
using VRage.Game.ModAPI;

namespace WicoResearch
{
    internal class ResearchControl
    {
        readonly bool bNewResearch = true;
        public readonly bool bDebugLocations = false;
        public readonly bool bVanillaBlocks = false;


        private readonly MyDefinitionId SpaceBallLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_SpaceBall", "SpaceBallLarge");
        private readonly MyDefinitionId SpaceBallSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_SpaceBall", "SpaceBallSmall");

        private readonly MyDefinitionId VirtualMassLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_VirtualMass", "VirtualMassLarge");
        private readonly MyDefinitionId VirtualMassSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_VirtualMass", "VirtualMassSmall");

        private readonly MyDefinitionId GravityGenerator = MyVisualScriptLogicProvider.GetDefinitionId(
           "MyObjectBuilder_GravityGenerator", "");
        private readonly MyDefinitionId GravityGeneratorSphere = MyVisualScriptLogicProvider.GetDefinitionId(
           "MyObjectBuilder_GravityGeneratorSphere", "");

        private readonly MyDefinitionId LargeProgrammableBlock = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_MyProgrammableBlock", "LargeProgrammableBlock");


        private readonly MyDefinitionId LargeCameraBlock = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_CameraBlock", "LargeCameraBlock");
        private readonly MyDefinitionId SmallCameraBlock = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_CameraBlock", "SmallCameraBlock");

        private readonly MyDefinitionId LargeBlockSensor = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_SensorBlock", "LargeBlockSensor");
        private readonly MyDefinitionId SmallBlockSensor = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_SensorBlock", "SmallBlockSensor");
        
            private readonly MyDefinitionId LargeBlockGyro = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Gyro", "LargeBlockGyro");
        private readonly MyDefinitionId SmallBlockGyro = MyVisualScriptLogicProvider.GetDefinitionId(
        "MyObjectBuilder_Gyro", "SmallBlockGyro");

        private readonly MyDefinitionId LargeBlockSolarPanel = MyVisualScriptLogicProvider.GetDefinitionId(
            "SolarPanel", "LargeBlockSolarPanel");
        private readonly MyDefinitionId SmallBlockSolarPanel = MyVisualScriptLogicProvider.GetDefinitionId(
            "SolarPanel", "SmallBlockSolarPanel");

        private readonly MyDefinitionId LargeBlockLargeGenerator = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Reactor", "LargeBlockLargeGenerator");
        private readonly MyDefinitionId LargeBlockSmallGenerator = MyVisualScriptLogicProvider.GetDefinitionId(
             "MyObjectBuilder_Reactor", "LargeBlockSmallGenerator");
        private readonly MyDefinitionId SmallBlockSmallGenerator = MyVisualScriptLogicProvider.GetDefinitionId(
             "MyObjectBuilder_Reactor", "SmallBlockSmallGenerator");
        private readonly MyDefinitionId SmallBlockLargeGenerator = MyVisualScriptLogicProvider.GetDefinitionId(
             "MyObjectBuilder_Reactor", "SmallBlockLargeGenerator");

        private readonly MyDefinitionId SmallBlockBatteryBlock = MyVisualScriptLogicProvider.GetDefinitionId(
             "MyObjectBuilder_BatteryBlock", "SmallBlockBatteryBlock");
        private readonly MyDefinitionId LargeBlockBatteryBlock = MyVisualScriptLogicProvider.GetDefinitionId(
             "MyObjectBuilder_BatteryBlock", "LargeBlockBatteryBlock");

        private readonly MyDefinitionId LargeBlockRadioAntennaDish = MyVisualScriptLogicProvider.GetDefinitionId(
             "MyObjectBuilder_RadioAntenna", "LargeBlockRadioAntennaDish");

        private readonly MyDefinitionId LargeBlockBeacon = MyVisualScriptLogicProvider.GetDefinitionId(
         "MyObjectBuilder_Beacon", "LargeBlockBeacon");
        private readonly MyDefinitionId SmallBlockBeacon = MyVisualScriptLogicProvider.GetDefinitionId(
         "MyObjectBuilder_Beacon", "SmallBlockBeacon");

        private readonly MyDefinitionId LargeBlockLaserAntenna = MyVisualScriptLogicProvider.GetDefinitionId(
             "MyObjectBuilder_LaserAntenna", "LargeBlockLaserAntenna");
        private readonly MyDefinitionId SmallBlockLaserAntenna = MyVisualScriptLogicProvider.GetDefinitionId(
             "MyObjectBuilder_LaserAntenna", "SmallBlockLaserAntenna");

        
        // Start of original list
        private readonly MyDefinitionId refinery = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Refinery", "LargeRefinery");

        private readonly MyDefinitionId blastFurnace = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Refinery", "Blast Furnace");

        private readonly MyDefinitionId jumpDrive = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_JumpDrive", "LargeJumpDrive");

        private readonly MyDefinitionId radioAntennaLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_RadioAntenna", "LargeBlockRadioAntenna");

        private readonly MyDefinitionId radioAntennaSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_RadioAntenna", "SmallBlockRadioAntenna");

        private readonly MyDefinitionId largeMissileTurret = MyVisualScriptLogicProvider.GetDefinitionId(
            "LargeMissileTurret", null);

        private readonly MyDefinitionId smallMissileTurret = MyVisualScriptLogicProvider.GetDefinitionId(
            "LargeMissileTurret", "SmallMissileTurret");

        private readonly MyDefinitionId rocketLauncher = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallMissileLauncher", null);

        private readonly MyDefinitionId largeRocketLauncher = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallMissileLauncher", "LargeMissileLauncher");

        private readonly MyDefinitionId smallReloadableRocketLauncher =
            MyVisualScriptLogicProvider.GetDefinitionId("SmallMissileLauncherReload", "SmallRocketLauncherReload");


        private readonly MyDefinitionId LargeGatlingTurret = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_LargeGatlingTurret", null);

        private readonly MyDefinitionId InteriorTurret = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_InteriorTurret", "LargeInteriorTurret");

        private readonly MyDefinitionId SmallRocketLauncherReload = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_SmallMissileLauncherReload", "SmallRocketLauncherReload");

        private readonly MyDefinitionId SmallGatlingTurret = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_LargeGatlingTurret", "SmallGatlingTurret");


        private readonly MyDefinitionId ionThrusterSmallShipSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "SmallBlockSmallThrust");

        private readonly MyDefinitionId ionThrusterSmallShipLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "SmallBlockLargeThrust");

        private readonly MyDefinitionId ionThrusterLargeShipSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "LargeBlockSmallThrust");

        private readonly MyDefinitionId ionThrusterLargeShipLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "LargeBlockLargeThrust");

        private readonly MyDefinitionId hydroThrusterSmallShipSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "SmallBlockSmallHydrogenThrust");

        private readonly MyDefinitionId hydroThrusterSmallShipLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "SmallBlockLargeHydrogenThrust");

        private readonly MyDefinitionId hydroThrusterLargeShipSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "LargeBlockSmallHydrogenThrust");

        private readonly MyDefinitionId hydroThrusterLargeShipLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "LargeBlockLargeHydrogenThrust");

        private readonly MyDefinitionId atmoThrusterSmallShipSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "SmallBlockSmallAtmosphericThrust");

        private readonly MyDefinitionId atmoThrusterSmallShipLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "SmallBlockLargeAtmosphericThrust");

        private readonly MyDefinitionId atmoThrusterLargeShipSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "Thrust", "LargeBlockSmallAtmosphericThrust");

        private readonly MyDefinitionId atmoThrusterLargeShipLarge = MyVisualScriptLogicProvider.GetDefinitionId("Thrust",
            "LargeBlockLargeAtmosphericThrust");

        private readonly MyDefinitionId oxygenFarm = MyVisualScriptLogicProvider.GetDefinitionId(
            "OxygenFarm", "LargeBlockOxygenFarm");

        private readonly MyDefinitionId oxygenGeneratorLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_OxygenGenerator", null);

        private readonly MyDefinitionId oxygenGeneratorSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_OxygenGenerator", "OxygenGeneratorSmall");

        private readonly MyDefinitionId oxygenTankLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "OxygenTank", null);

        private readonly MyDefinitionId oxygenTankSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "OxygenTank", "OxygenTankSmall");

        private readonly MyDefinitionId hydrogenTankLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "OxygenTank", "LargeHydrogenTank");

        private readonly MyDefinitionId hydrogenTankSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "OxygenTank", "SmallHydrogenTank");

        private readonly MyDefinitionId projectorLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Projector", "LargeProjector");

        private readonly MyDefinitionId projectorSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Projector", "SmallProjector");

        private readonly MyDefinitionId EngineLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_HydrogenEngine", "LargeHydrogenEngine");

        private readonly MyDefinitionId WindTurbineLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_WindTurbine", "LargeBlockWindTurbine");

        private readonly MyDefinitionId SkLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_SurvivalKit", "SurvivalKitLarge");

        private readonly MyDefinitionId BasicAssembler = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Assembler", "BasicAssembler");

        private readonly MyDefinitionId SmallBattery = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_BatteryBlock", "SmallBlockSmallBatteryBlock");

        private readonly MyDefinitionId EngineSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_HydrogenEngine", "SmallHydrogenEngine");

        private readonly MyDefinitionId SkSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_SurvivalKit", "SurvivalKit");


        // Armor
        private readonly MyDefinitionId LargeBlockArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorBlock");

// variants
//          <SubtypeId>LargeBlockArmorSlope</SubtypeId>
//          <SubtypeId>LargeBlockArmorCorner</SubtypeId>
//          <SubtypeId>LargeBlockArmorCornerInv</SubtypeId>
//          <SubtypeId>LargeHalfArmorBlock</SubtypeId>
//          <SubtypeId>LargeHalfSlopeArmorBlock</SubtypeId>

        private readonly MyDefinitionId LargeBlockArmorSlope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorSlope");

        private readonly MyDefinitionId LargeBlockArmorCorner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorCorner");

        private readonly MyDefinitionId LargeBlockArmorCornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorCornerInv");

        private readonly MyDefinitionId LargeRoundArmor_Slope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeRoundArmor_Slope");

        private readonly MyDefinitionId LargeRoundArmor_Corner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeRoundArmor_Corner");

        private readonly MyDefinitionId LargeRoundArmor_CornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeRoundArmor_CornerInv");

        private readonly MyDefinitionId LargeHalfArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHalfArmorBlock");

        private readonly MyDefinitionId LargeHalfSlopeArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHalfSlopeArmorBlock");



        private readonly MyDefinitionId LargeHeavyBlockArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyBlockArmorBlock");
        // variants
        //          <SubtypeId>LargeHeavyBlockArmorSlope</SubtypeId>
        //          <SubtypeId>LargeHeavyBlockArmorCorner</SubtypeId>
        //          <SubtypeId>LargeHeavyBlockArmorCornerInv</SubtypeId>
        //          <SubtypeId>LargeHeavyHalfArmorBlock</SubtypeId>
        //          <SubtypeId>LargeHeavyHalfSlopeArmorBlock</SubtypeId>


        private readonly MyDefinitionId LargeHeavyBlockArmorSlope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyBlockArmorSlope");

        private readonly MyDefinitionId LargeHeavyBlockArmorCorner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyBlockArmorCorner");

        private readonly MyDefinitionId LargeHeavyBlockArmorCornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyBlockArmorCornerInv");

        private readonly MyDefinitionId LargeHeavyHalfArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyHalfArmorBlock");

        private readonly MyDefinitionId LargeHeavyHalfSlopeArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyHalfSlopeArmorBlock");


        // SMALL GRID BLOCKS

        private readonly MyDefinitionId SmallBlockArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallBlockArmorBlock");
        // variants
        //          <SubtypeId>SmallBlockArmorSlope</SubtypeId>
        //          <SubtypeId>SmallBlockArmorCorner</SubtypeId>
        //          <SubtypeId>SmallBlockArmorCornerInv</SubtypeId>
        //          <SubtypeId>HalfArmorBlock</SubtypeId>
        //          <SubtypeId>HalfSlopeArmorBlock</SubtypeId>

        private readonly MyDefinitionId SmallBlockArmorSlope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallBlockArmorSlope");

        private readonly MyDefinitionId SmallBlockArmorCorner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallBlockArmorCorner");

        private readonly MyDefinitionId SmallBlockArmorCornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallBlockArmorCorner");

        private readonly MyDefinitionId SmallHeavyBlockArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallHeavyBlockArmorBlock");
        // block variants
//          <SubtypeId>SmallHeavyBlockArmorSlope</SubtypeId>
//          <SubtypeId>SmallHeavyBlockArmorCorner</SubtypeId>
//          <SubtypeId>SmallHeavyBlockArmorCornerInv</SubtypeId>
//          <SubtypeId>HeavyHalfArmorBlock</SubtypeId>
//          <SubtypeId>HeavyHalfSlopeArmorBlock</SubtypeId>


        private readonly MyDefinitionId SmallHeavyBlockArmorSlope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallHeavyBlockArmorSlope");

        private readonly MyDefinitionId SmallHeavyBlockArmorCorner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallHeavyBlockArmorCorner");

        private readonly MyDefinitionId SmallHeavyBlockArmorCornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallHeavyBlockArmorCornerInv");




        // SMALL GRID HALF ARMOR
        private readonly MyDefinitionId HalfArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "HalfArmorBlock");

        private readonly MyDefinitionId HeavyHalfArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "HeavyHalfArmorBlock");

        private readonly MyDefinitionId HalfSlopeArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "HalfSlopeArmorBlock");

        private readonly MyDefinitionId HeavyHalfSlopeArmorBlock = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "HeavyHalfSlopeArmorBlock");


        // BEGIN ROUND ARMOR
        private readonly MyDefinitionId LargeBlockArmorRoundSlope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorRoundSlope");
        //block variants
//        <SubtypeId>LargeBlockArmorRoundCorner</SubtypeId>
//        <SubtypeId>LargeBlockArmorRoundCornerInv</SubtypeId>

        private readonly MyDefinitionId LargeBlockArmorRoundCorner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorRoundCorner");

        private readonly MyDefinitionId LargeBlockArmorRoundCornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorRoundCornerInv");

        // large heavy
        private readonly MyDefinitionId LargeHeavyBlockArmorRoundSlope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyBlockArmorRoundSlope");
        // block variants
        //          <SubtypeId>LargeHeavyBlockArmorRoundCorner</SubtypeId>
        //          <SubtypeId>LargeHeavyBlockArmorRoundCornerInv</SubtypeId>


        private readonly MyDefinitionId LargeHeavyBlockArmorRoundCorner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyBlockArmorRoundCorner");

        private readonly MyDefinitionId LargeHeavyBlockArmorRoundCornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyBlockArmorRoundCornerInv");

        // small light

        private readonly MyDefinitionId SmallBlockArmorRoundSlope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallBlockArmorRoundSlope");
        // block variants
        //          <SubtypeId>SmallBlockArmorRoundCorner</SubtypeId>
        //          <SubtypeId>SmallBlockArmorRoundCornerInv</SubtypeId>


        private readonly MyDefinitionId SmallBlockArmorRoundCorner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeHeavyBlockArmorRoundCorner");

        private readonly MyDefinitionId SmallBlockArmorRoundCornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallBlockArmorRoundCornerInv");

        // small heavy
        private readonly MyDefinitionId SmallHeavyBlockArmorRoundSlope = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallHeavyBlockArmorRoundSlope");
        // block variants
//        <SubtypeId>SmallHeavyBlockArmorRoundCorner</SubtypeId>
//          <SubtypeId>SmallHeavyBlockArmorRoundCornerInv</SubtypeId>

        private readonly MyDefinitionId SmallHeavyBlockArmorRoundCorner = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallHeavyBlockArmorRoundCorner");

        private readonly MyDefinitionId SmallHeavyBlockArmorRoundCornerInv = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "SmallBlockArmorRoundCornerInv");


        // non-deforming sloped armor
        private readonly MyDefinitionId LargeBlockArmorSlope2Base = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorSlope2Base");
        //          <SubtypeId>LargeBlockArmorSlope2Tip</SubtypeId>


        private readonly MyDefinitionId LargeBlockArmorSlope2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorSlope2Tip");

        // 2x1x1 corner
        private readonly MyDefinitionId LargeBlockArmorCorner2Base = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorCorner2Base");
        //           <SubtypeId>LargeBlockArmorCorner2Tip</SubtypeId>


        private readonly MyDefinitionId LargeBlockArmorCorner2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
           "CubeBlock", "LargeBlockArmorCorner2Tip");

        private readonly MyDefinitionId LargeBlockArmorInvCorner2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "LargeBlockArmorCorner2Base");
        //           <SubtypeId>LargeBlockArmorInvCorner2Tip</SubtypeId>


        private readonly MyDefinitionId LargeBlockArmorInvCorner2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "LargeBlockArmorInvCorner2Tip");


        private readonly MyDefinitionId LargeHeavyBlockArmorSlope2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "LargeHeavyBlockArmorSlope2Base");
        //           <SubtypeId>LargeHeavyBlockArmorSlope2Tip</SubtypeId>


        private readonly MyDefinitionId LargeHeavyBlockArmorSlope2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "LargeHeavyBlockArmorSlope2Tip");

        private readonly MyDefinitionId LargeHeavyBlockArmorCorner2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "LargeHeavyBlockArmorCorner2Base");
        //           <SubtypeId>LargeHeavyBlockArmorCorner2Tip</SubtypeId>


        private readonly MyDefinitionId LargeHeavyBlockArmorCorner2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "LargeHeavyBlockArmorCorner2Tip");

        private readonly MyDefinitionId LargeHeavyBlockArmorInvCorner2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "LargeHeavyBlockArmorInvCorner2Base");
        //          <SubtypeId>LargeHeavyBlockArmorInvCorner2Tip</SubtypeId>

        private readonly MyDefinitionId LargeHeavyBlockArmorInvCorner2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "LargeHeavyBlockArmorInvCorner2Tip");


        //

        private readonly MyDefinitionId SmallBlockArmorSlope2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallBlockArmorSlope2Base");

        private readonly MyDefinitionId SmallBlockArmorSlope2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallBlockArmorSlope2Tip");

        private readonly MyDefinitionId SmallBlockArmorCorner2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallBlockArmorCorner2Base");

        private readonly MyDefinitionId SmallBlockArmorCorner2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallBlockArmorCorner2Tip");

        private readonly MyDefinitionId SmallBlockArmorInvCorner2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallBlockArmorInvCorner2Base");

        private readonly MyDefinitionId SmallBlockArmorInvCorner2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallBlockArmorInvCorner2Tip");

        private readonly MyDefinitionId SmallHeavyBlockArmorSlope2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallHeavyBlockArmorSlope2Base");

        private readonly MyDefinitionId SmallHeavyBlockArmorSlope2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallHeavyBlockArmorSlope2Tip");

        private readonly MyDefinitionId SmallHeavyBlockArmorCorner2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallHeavyBlockArmorCorner2Base");

        private readonly MyDefinitionId SmallHeavyBlockArmorCorner2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallHeavyBlockArmorCorner2Tip");

        private readonly MyDefinitionId SmallHeavyBlockArmorInvCorner2Base = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallHeavyBlockArmorInvCorner2Base");

        private readonly MyDefinitionId SmallHeavyBlockArmorInvCorner2Tip = MyVisualScriptLogicProvider.GetDefinitionId(
            "CubeBlock", "SmallHeavyBlockArmorInvCorner2Tip");

        /// //////////////////////////////////

        // Economy.  V1.192
        private readonly MyDefinitionId SafeZoneBlock = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_SafeZoneBlock", "SafeZoneBlock");

        private readonly MyDefinitionId StoreBlock = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_StoreBlock", "StoreBlock");

        private readonly MyDefinitionId ContractBlock = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_ContractBlock", "ContractBlock");

        //V1.193


        /*TyepID=MyObjectBuilder_VendingMachine
        SubtyepID=FoodDispenser
        */
        private readonly MyDefinitionId FoodDispenser = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_VendingMachine", "FoodDispenser");

        /*TyepID=MyObjectBuilder_Cockpit    
SubtyepID=OpenCockpitSmall
*/
        private readonly MyDefinitionId OpenCockpitSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Cockpit", "OpenCockpitSmall");

        /*TyepID=MyObjectBuilder_Cockpit
SubtyepID=OpenCockpitLarge
*/
        private readonly MyDefinitionId OpenCockpitLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Cockpit", "OpenCockpitLarge");

        /*TyepID=MyObjectBuilder_TextPanel
SubtyepID=TransparentLCDSmall*/
        private readonly MyDefinitionId TransparentLCDSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_TextPanel", "TransparentLCDSmall");

        /*TyepID=MyObjectBuilder_ReflectorLight
SubtyepID=RotatingLightSmall*/
        private readonly MyDefinitionId RotatingLightSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_ReflectorLight", "RotatingLightSmall");


        /*TyepID=MyObjectBuilder_LCDPanelsBlock
SubtyepID=LabEquipment*/
        private readonly MyDefinitionId LabEquipment = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_LCDPanelsBlock", "LabEquipment");

        /*TyepID=MyObjectBuilder_TextPanel
SubtyepID=TransparentLCDLarge*/
        private readonly MyDefinitionId TransparentLCDLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_TextPanel", "TransparentLCDLarge");

        /*TyepID=MyObjectBuilder_ReflectorLight
SubtyepID=RotatingLightLarge*/
        private readonly MyDefinitionId RotatingLightLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_ReflectorLight", "RotatingLightLarge");

        /*TyepID=MyObjectBuilder_LCDPanelsBlock
SubtyepID=MedicalStation*/
        private readonly MyDefinitionId MedicalStation = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_LCDPanelsBlock", "MedicalStation");

        /*TyepID=MyObjectBuilder_Jukebox
SubtyepID=Jukebox*/
        private readonly MyDefinitionId Jukebox = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Jukebox", "Jukebox");


        // V1.194
        /* TyepID=MyObjectBuilder_OxygenTank
SubtyepID=LargeHydrogenTankSmall */
        private readonly MyDefinitionId LargeHydrogenTankSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_OxygenTank", "LargeHydrogenTankSmall");

        /* TyepID=MyObjectBuilder_OxygenTank
SubtyepID=SmallHydrogenTankSmall
*/
        private readonly MyDefinitionId SmallHydrogenTankSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_OxygenTank", "SmallHydrogenTankSmall");

        // V1.192

        /*TyepID=MyObjectBuilder_VendingMachine
        SubtyepID=VendingMachine
        */
        private readonly MyDefinitionId VendingMachine = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_VendingMachine", "VendingMachine");

        /*TyepID=MyObjectBuilder_StoreBlock
        SubtyepID=AtmBlock
        */
        private readonly MyDefinitionId AtmBlock = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_StoreBlock", "AtmBlock");


        // V1.195
        /* SG 
         * Sc-fi sliding door
         * TyepID=MyObjectBuilder_Door
        SubtyepID=SmallSideDoor
        */
        private readonly MyDefinitionId SmallSideDoor = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Door", "SmallSideDoor");
        /* SG medium hinge
         * TyepID=MyObjectBuilder_MotorAdvancedStator
        SubtyepID = MediumHinge
        */
        private readonly MyDefinitionId MediumHinge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_MotorAdvancedStator", "MediumHinge");


        /* SG Small hinge
         * TyepID=MyObjectBuilder_MotorAdvancedStator
        SubtyepID=SmallHinge
        */
        private readonly MyDefinitionId SmallHinge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_MotorAdvancedStator", "SmallHinge");

        /* Small hinge head
         * TyepID=MyObjectBuilder_MotorStator
        SubtyepID=SmallStator
        */
        private readonly MyDefinitionId SmallStator = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_MotorStator", "SmallStator");

        // Sparks of the Future DLC

        /* SG
         * Sci-Fi Ion Thruster
        TyepID=MyObjectBuilder_Thrust
        SubtyepID=SmallBlockSmallThrustSciFi
        */
        private readonly MyDefinitionId SmallBlockSmallThrustSciFi = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Thrust", "SmallBlockSmallThrustSciFi");


        /* SG
         * Sci-Fi Large Ion Thruster
        TyepID=MyObjectBuilder_Thrust
        SubtyepID=SmallBlockLargeThrustSciFi
        */
        private readonly MyDefinitionId SmallBlockLargeThrustSciFi = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Thrust", "SmallBlockLargeThrustSciFi");

        /* SG
         * Sci-Fi Atmospheric Thruster
        TyepID=MyObjectBuilder_Thrust
        SubtyepID=SmallBlockSmallAtmosphericThrustSciFi
        */
        private readonly MyDefinitionId SmallBlockSmallAtmosphericThrustSciFi = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Thrust", "SmallBlockSmallAtmosphericThrustSciFi");

        /*
         * SG
         * Sci-Fi Large Atmospheric Thruster
        TyepID=MyObjectBuilder_Thrust
        SubtyepID=SmallBlockLargeAtmosphericThrustSciFi
        */
        private readonly MyDefinitionId SmallBlockLargeAtmosphericThrustSciFi = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Thrust", "SmallBlockLargeAtmosphericThrustSciFi");


        /* LG
         * Hinge
        TyepID=MyObjectBuilder_MotorAdvancedStator
        SubtyepID=LargeHinge
        */
        private readonly MyDefinitionId LargeHinge = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_MotorAdvancedStator", "LargeHinge");


        /* LG
         * Sci-Fi Terminal Panel
        TyepID=MyObjectBuilder_TerminalBlock
        SubtyepID=LargeBlockSciFiTerminal
        */
        private readonly MyDefinitionId LargeBlockSciFiTerminal = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_TerminalBlock", "LargeBlockSciFiTerminal");

        /* LG
         * Sci-Fi One-Button Terminal
        TyepID=MyObjectBuilder_ButtonPanel
        SubtyepID=LargeSciFiButtonTerminal
        */
        private readonly MyDefinitionId LargeSciFiButtonTerminal = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_ButtonPanel", "LargeSciFiButtonTerminal");

        /* LG
         * Sci-Fi Four-Button Panel
        TyepID=MyObjectBuilder_ButtonPanel
        SubtyepID=LargeSciFiButtonPanel
        (4 surfaces)
        */
        private readonly MyDefinitionId LargeSciFiButtonPanel = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_ButtonPanel", "LargeSciFiButtonPanel");

        /* LG
         * Sci-Fi Large Ion Thruster
        TyepID=MyObjectBuilder_Thrust
        SubtyepID=LargeBlockLargeThrustSciFi
        */
        private readonly MyDefinitionId LargeBlockLargeThrustSciFi = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Thrust", "LargeBlockLargeThrustSciFi");


        /* LG 
         * Sci-Fi Ion Thruster
        TyepID=MyObjectBuilder_Thrust
        SubtyepID=LargeBlockSmallThrustSciFi
        */
        private readonly MyDefinitionId LargeBlockSmallThrustSciFi = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Thrust", "LargeBlockSmallThrustSciFi");


        /* LG
         * Sci-Fi Large Atmospheric Thruster
        TyepID=MyObjectBuilder_Thrust
        SubtyepID=LargeBlockLargeAtmosphericThrustSciFi
        */
        private readonly MyDefinitionId LargeBlockLargeAtmosphericThrustSciFi = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Thrust", "LargeBlockLargeAtmosphericThrustSciFi");

        /* LG
         * Sci-Fi Atmospheric Thruster
        TyepID=MyObjectBuilder_Thrust
        SubtyepID=LargeBlockSmallAtmosphericThrustSciFi
        */
        private readonly MyDefinitionId LargeBlockSmallAtmosphericThrustSciFi = MyVisualScriptLogicProvider.GetDefinitionId(
            "MyObjectBuilder_Thrust", "LargeBlockSmallAtmosphericThrustSciFi");


        /* LG
         * Sci-Fi LCD Panel 3x3
        TyepID=MyObjectBuilder_TextPanel
        SubtyepID=LargeLCDPanel3x3
        */

        /* LG
         * Sci-Fi LCD Panel 5x3
        TyepID=MyObjectBuilder_TextPanel
        SubtyepID=LargeLCDPanel5x3
        */

        /* LG
         * Sci-Fi LCD Panel 5x5
        TyepID=MyObjectBuilder_TextPanel
        SubtyepID=LargeLCDPanel5x5
        */

        /* Energy Shields. https://steamcommunity.com/sharedfiles/filedetails/?id=484504816
         * 

         <TypeId>Refinery</TypeId>
        <SubtypeId>LargeShipSmallShieldGeneratorBase</SubtypeId>
        <TypeId>Refinery</TypeId>
        <SubtypeId>LargeShipLargeShieldGeneratorBase</SubtypeId>
        <TypeId>Refinery</TypeId>
        <SubtypeId>SmallShipSmallShieldGeneratorBase</SubtypeId>
        <TypeId>Refinery</TypeId>
        <SubtypeId>SmallShipMicroShieldGeneratorBase</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>ShieldCapacitor</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>ShieldFluxCoil</SubtypeId>
         */
        private readonly MyDefinitionId LargeShipSmallShieldGeneratorBase = MyVisualScriptLogicProvider.GetDefinitionId(
            "Refinery", "LargeShipSmallShieldGeneratorBase");
        private readonly MyDefinitionId LargeShipLargeShieldGeneratorBase = MyVisualScriptLogicProvider.GetDefinitionId(
            "Refinery", "LargeShipLargeShieldGeneratorBase");
        private readonly MyDefinitionId SmallShipSmallShieldGeneratorBase = MyVisualScriptLogicProvider.GetDefinitionId(
            "Refinery", "SmallShipSmallShieldGeneratorBase");
        private readonly MyDefinitionId SmallShipMicroShieldGeneratorBase = MyVisualScriptLogicProvider.GetDefinitionId(
            "Refinery", "SmallShipMicroShieldGeneratorBase");
        private readonly MyDefinitionId ShieldCapacitor = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "ShieldCapacitor");
        private readonly MyDefinitionId ShieldFluxCoil = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "ShieldFluxCoil");


        /* MOD: Defense Shields - v1.91(3) https://steamcommunity.com/sharedfiles/filedetails/?id=1365616918
         * 
         * 
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>DSControlTable</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>DSControlLarge</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>DSControlSmall</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>NPCControlLB</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>NPCControlSB</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>NPCEmitterLB</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>NPCEmitterSB</SubtypeId>
        <TypeId>OxygenGenerator</TypeId>
        <SubtypeId>DSSupergen</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>EmitterL</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>EmitterS</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>EmitterST</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>LargeShieldModulator</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>SmallShieldModulator</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>LargeEnhancer</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>SmallEnhancer</SubtypeId>
          <TypeId>UpgradeModule</TypeId>
          <SubtypeId>EmitterLA</SubtypeId>
        <TypeId>UpgradeModule</TypeId>
        <SubtypeId>EmitterSA</SubtypeId>
         */
        private readonly MyDefinitionId DSControlTable = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "DSControlTable");
        private readonly MyDefinitionId DSControlLarge = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "DSControlLarge");
        private readonly MyDefinitionId DSControlSmall = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "DSControlSmall");
        private readonly MyDefinitionId NPCControlLB = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "NPCControlLB");
        private readonly MyDefinitionId NPCControlSB = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "NPCControlSB");
        private readonly MyDefinitionId NPCEmitterLB = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "NPCEmitterLB");
        private readonly MyDefinitionId NPCEmitterSB = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "NPCEmitterSB");
        private readonly MyDefinitionId DSSupergen = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "DSSupergen");
        private readonly MyDefinitionId EmitterL = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "EmitterL");
        private readonly MyDefinitionId EmitterS = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "EmitterS");
        private readonly MyDefinitionId EmitterST = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "EmitterST");
        private readonly MyDefinitionId LargeShieldModulator = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "LargeShieldModulator");
        private readonly MyDefinitionId SmallShieldModulator = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "SmallShieldModulator");
        private readonly MyDefinitionId LargeEnhancer = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "LargeEnhancer");
        private readonly MyDefinitionId SmallEnhancer = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "SmallEnhancer");
        private readonly MyDefinitionId EmitterLA = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "EmitterLA");
        private readonly MyDefinitionId EmitterSA = MyVisualScriptLogicProvider.GetDefinitionId(
            "UpgradeModule", "EmitterSA");

        /* MOD (2020 Update!) Star Wars Weapons https://steamcommunity.com/sharedfiles/filedetails/?id=598138548
         * 
         * 
         * 
         * 
         *
        
        *Stationary Large Ship Heavy Turbolasers + Ammo
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Heavy_Clone_Turbolaser</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Heavy_Rebel_Cannon_Large</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Heavy_Red_Turbolaser</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Heavy_Turbolaser</SubtypeId>
        
        
        *Stationary Large Ship Mega Laser Cannons + Ammo
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Large_AAT_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Large_ATAT_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Large_Blue_SW_Starship_Laser_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Large_Falcon_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Large_Green_SW_Starship_Laser_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Large_LAAT_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Large_Red_SW_Starship_Laser_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Large_Slave_1_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Large_Vulture_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
	    <SubtypeId>Large_XWing_Cannon</SubtypeId>
       
        
        *Stationary Other + Ammo
        <TypeId>SmallGatlingGun</TypeId>
	    <SubtypeId>CIS_Flak_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>CIS_Flak_Cannon_Small</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Clone_Blaster</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Clone_Flak_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Clone_Flak_Cannon_Small</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
		<SubtypeId>Death_Star_Explosive_Superlaser</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
		<SubtypeId>Death_Star_Superlaser</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Green_Rotary_Blaster_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Hypervelocity_Gun</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Imperial_Flak_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
		<SubtypeId>Imperial_Flak_Cannon_Small</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
        <SubtypeId>LAAT_Beam</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Proton_Beam</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Red_Rotary_Blaster_Cannon</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
		<SubtypeId>SPHA_Weapon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>TIE_Cannon</SubtypeId>
        

        *Stationary Small Ship Laser Cannons + Ammo
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>AAT_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>ATAT_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Blue_SW_Starship_Laser_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Falcon_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Green_SW_Starship_Laser_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>LAAT_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Red_SW_Starship_Laser_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Slave_1_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Vulture_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>XWing_Cannon</SubtypeId>
        

        *Stationary Small Ship Light Turbolasers + Ammo
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Clone_Turbolaser</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Heavy_Rebel_Cannon</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Red_Turbolaser</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Turbolaser</SubtypeId>

        
        *Stationary Small Ship Mounted Blasters + Ammo
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>DC15A_Blaster</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>DC15s</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>DC17m</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>DC17m_Sniper</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Droideka_Blaster</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>E5_Blaster</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>E11_Blaster</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>ELG-3A_Blaster</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Han_Solo_Blaster</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Heavy_Blaster</SubtypeId>
        <TypeId>SmallGatlingGun</TypeId>
        <SubtypeId>Westar_Blaster</SubtypeId>
       
            
        *Stationary Torpedo Missile Launchers + Ammo
        <TypeId>SmallMissileLauncher</TypeId>
        <SubtypeId>Heavy_Concussion_Missile</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
        <SubtypeId>Heavy_Energy_Torpedo</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
        <SubtypeId>Large_Compact_Concussion_Missile</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
        <SubtypeId>Large_Compact_Proton_Torpedo</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
        <SubtypeId>Small_Compact_Concussion_Missile</SubtypeId>
        <TypeId>SmallMissileLauncher</TypeId>
        <SubtypeId>Small_Compact_Proton_Torpedo</SubtypeId>

           
         *Turret Large Ship Heavy Turbolasers
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Heavy_Clone_Turbolaser_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Heavy_Rebel_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Heavy_Red_Turbolaser_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Heavy_Turbolaser_Turret</SubtypeId>
         
         *Turret Large Ship Light Turbolasers
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Light_Clone_Turbolaser_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Light_Heavy_Rebel_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Light_Red_Turbolaser_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Light_Turbolaser_Turret</SubtypeId>
         
         *Turret Large Ship Mega Laser Cannons
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>AAT_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>ATAT_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Blue_SW_Starship_Laser_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Falcon_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Green_SW_Starship_Laser_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>LAAT_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Red_SW_Starship_Laser_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Slave_1_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>TIE_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Vulture_Cannon_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>XWing_Cannon_Large_Turret</SubtypeId>
         
            *Turret Other
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>CIS_Flak_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>CIS_Flak_Cannon_Light_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>CIS_Flak_Cannon_Small_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Clone_Blaster_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Clone_Flak_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Clone_Flak_Cannon_Light_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Clone_Flak_Cannon_Small_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Green_Rotary_Blaster_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Hypervelocity_Gun_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Imperial_Flak_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Imperial_Flak_Cannon_Light_Large_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Imperial_Flak_Cannon_Small_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Large_Clone_Blaster_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Large_Green_Rotary_Blaster_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Large_Red_Rotary_Blaster_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Light_Proton_Beam_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Red_Rotary_Blaster_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Proton_Beam_Turret</SubtypeId>

            *Turret Small Ship Lasers
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>AAT_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>ATAT_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Blue_SW_Starship_Laser_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Falcon_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Green_SW_Starship_Laser_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>LAAT_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Red_SW_Starship_Laser_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Slave_1_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>TIE_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Vulture_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>XWing_Cannon_Turret</SubtypeId>
            
         
            *Light Turbolasers
            Clone Turbolasers Turrets
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Clone_Turbolaser_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Heavy_Rebel_Cannon_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Red_Turbolaser_Turret</SubtypeId>
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Turbolaser_Turret</SubtypeId>



         *Turret Small Ship Mounted Blasters
         DC151 Blaster Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>DC15A_Blaster_Turret</SubtypeId>

         DC15s Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>DC15s_Turret</SubtypeId>

        DC15m Sniper Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>DC17m_Sniper_Turret</SubtypeId>

        DC17m Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>DC17m_Turret</SubtypeId>

        Droideka Blaster Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Droideka_Blaster_Turret</SubtypeId>

        E5 Blaster Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>E5_Blaster_Turret</SubtypeId>

        E11 Blaster Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>E11_Blaster_Turret</SubtypeId>

        ELG-3A Blaster Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>ELG-3A_Blaster_Turret</SubtypeId>

        Han Solo Blaster Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Han_Solo_Blaster_Turret</SubtypeId>

        Heavy Blaster Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Heavy_Blaster_Turret</SubtypeId>

        Westar Blaster Turret
        <TypeId>LargeGatlingTurret</TypeId>
        <SubtypeId>Westar_Blaster_Turret</SubtypeId>


         *Turret Torpedo Missile Launchers
         Concussion Missle Turrets
        <TypeId>LargeMissileTurret</TypeId>
        <SubtypeId>Large_Concussion_Missile_Turret</SubtypeId>
        Heavy Concussion Missile Turrets
        <TypeId>LargeMissileTurret</TypeId>
        <SubtypeId>Heavy_Concussion_Missile_Turret</SubtypeId>

        Heavy Energy Torpedo
        <TypeId>LargeMissileTurret</TypeId>
        <SubtypeId>Heavy_Energy_Torpedo_Turret</SubtypeId>

        Proton Torpedo
        <TypeId>LargeMissileTurret</TypeId>
        <SubtypeId>Large_Proton_Torpedo_Turret</SubtypeId>

         Small Concussion Turret
        <TypeId>LargeMissileTurret</TypeId>
        <SubtypeId>Small_Concussion_Missile_Turret</SubtypeId>

         Small Torpedo Turret
        <TypeId>LargeMissileTurret</TypeId>
        <SubtypeId>Small_Proton_Torpedo_Turret</SubtypeId>

          */
        private readonly MyDefinitionId Heavy_Clone_Turbolaser = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Heavy_Clone_Turbolaser");
        private readonly MyDefinitionId Heavy_Rebel_Cannon_Large = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Heavy_Rebel_Cannon_Large");
        private readonly MyDefinitionId Heavy_Red_Turbolaser = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Heavy_Red_Turbolaser");
        private readonly MyDefinitionId Heavy_Turbolaser = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Heavy_Turbolaser");

        private readonly MyDefinitionId Large_AAT_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_AAT_Cannon");
        private readonly MyDefinitionId Large_ATAT_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_ATAT_Cannon");
        private readonly MyDefinitionId Large_Blue_SW_Starship_Laser_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_Blue_SW_Starship_Laser_Cannon");
        private readonly MyDefinitionId Large_Falcon_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_Falcon_Cannon");
        private readonly MyDefinitionId Large_Green_SW_Starship_Laser_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_Green_SW_Starship_Laser_Cannon");
        private readonly MyDefinitionId Large_LAAT_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_LAAT_Cannon");
        private readonly MyDefinitionId Large_Red_SW_Starship_Laser_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_Red_SW_Starship_Laser_Cannon");
        private readonly MyDefinitionId Large_Slave_1_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_Slave_1_Cannon");
        private readonly MyDefinitionId Large_Vulture_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_Vulture_Cannon");
        private readonly MyDefinitionId Large_XWing_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
            "SmallGatlingGun", "Large_XWing_Cannon");

        private readonly MyDefinitionId CIS_Flak_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "CIS_Flak_Cannon");
        private readonly MyDefinitionId CIS_Flak_Cannon_Small = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "CIS_Flak_Cannon_Small");
        private readonly MyDefinitionId Clone_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Clone_Blaster");
        private readonly MyDefinitionId Clone_Flak_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Clone_Flak_Cannon");
        private readonly MyDefinitionId Clone_Flak_Cannon_Small = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Clone_Flak_Cannon_Small");
        private readonly MyDefinitionId Death_Star_Explosive_Superlaser = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "Death_Star_Explosive_Superlaser");
        private readonly MyDefinitionId Death_Star_Superlaser = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "Death_Star_Superlaser");
        private readonly MyDefinitionId Green_Rotary_Blaster_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Green_Rotary_Blaster_Cannon");
        private readonly MyDefinitionId Hypervelocity_Gun = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Hypervelocity_Gun");
        private readonly MyDefinitionId Imperial_Flak_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Imperial_Flak_Cannon");
        private readonly MyDefinitionId Imperial_Flak_Cannon_Small = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Imperial_Flak_Cannon_Small");
        private readonly MyDefinitionId LAAT_Beam = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "LAAT_Beam");
        private readonly MyDefinitionId Proton_Beam = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Proton_Beam");
        private readonly MyDefinitionId SPHA_Weapon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "SPHA_Weapon");
        private readonly MyDefinitionId TIE_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "TIE_Cannon");

        private readonly MyDefinitionId AAT_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "AAT_Cannon");
        private readonly MyDefinitionId ATAT_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "ATAT_Cannon");
        private readonly MyDefinitionId Blue_SW_Starship_Laser_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Blue_SW_Starship_Laser_Cannon");
        private readonly MyDefinitionId Falcon_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Falcon_Cannon");
        private readonly MyDefinitionId Green_SW_Starship_Laser_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Green_SW_Starship_Laser_Cannon");
        private readonly MyDefinitionId LAAT_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "LAAT_Cannon");
        private readonly MyDefinitionId Red_SW_Starship_Laser_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Red_SW_Starship_Laser_Cannon");
        private readonly MyDefinitionId Slave_1_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Slave_1_Cannon");
        private readonly MyDefinitionId Vulture_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Vulture_Cannon");
        private readonly MyDefinitionId XWing_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "XWing_Cannon");

        private readonly MyDefinitionId Clone_Turbolaser = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Clone_Turbolaser");
        private readonly MyDefinitionId Heavy_Rebel_Cannon = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Heavy_Rebel_Cannon");
        private readonly MyDefinitionId Red_Turbolaser = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Red_Turbolaser");
        private readonly MyDefinitionId Turbolaser = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Turbolaser");

        private readonly MyDefinitionId DC15A_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "DC15A_Blaster");
        private readonly MyDefinitionId DC15s = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "DC15s");
        private readonly MyDefinitionId DC17m = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "DC17m");
        private readonly MyDefinitionId DC17m_Sniper = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "DC17m_Sniper");
        private readonly MyDefinitionId Droideka_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Droideka_Blaster");
        private readonly MyDefinitionId E5_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "E5_Blaster");
        private readonly MyDefinitionId E11_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "E11_Blaster");
        private readonly MyDefinitionId ELG3A_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "ELG-3A_Blaster");
        private readonly MyDefinitionId Han_Solo_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Han_Solo_Blaster");
        private readonly MyDefinitionId Heavy_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Heavy_Blaster");
        private readonly MyDefinitionId Westar_Blaster = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallGatlingGun", "Westar_Blaster");

        private readonly MyDefinitionId Heavy_Concussion_Missile = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "Heavy_Concussion_Missile");
        private readonly MyDefinitionId Heavy_Energy_Torpedo = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "Heavy_Energy_Torpedo");
        private readonly MyDefinitionId Large_Compact_Concussion_Missile = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "Large_Compact_Concussion_Missile");
        private readonly MyDefinitionId Large_Compact_Proton_Torpedo = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "Large_Compact_Proton_Torpedo");
        private readonly MyDefinitionId Small_Compact_Concussion_Missile = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "Small_Compact_Concussion_Missile");
        private readonly MyDefinitionId Small_Compact_Proton_Torpedo = MyVisualScriptLogicProvider.GetDefinitionId(
           "SmallMissileLauncher", "Small_Compact_Proton_Torpedo");

        private readonly MyDefinitionId Heavy_Clone_Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Heavy_Clone_Turbolaser_Turret");
        private readonly MyDefinitionId Heavy_Rebel_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Heavy_Rebel_Cannon_Large_Turret");
        private readonly MyDefinitionId Heavy_Red_Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Heavy_Red_Turbolaser_Turret");
        private readonly MyDefinitionId Heavy_Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Heavy_Turbolaser_Turret");

        private readonly MyDefinitionId Light_Clone_Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Light_Clone_Turbolaser_Turret");
        private readonly MyDefinitionId Light_Heavy_Rebel_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Light_Heavy_Rebel_Cannon_Turret");
        private readonly MyDefinitionId Light_Red_Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Light_Red_Turbolaser_Turret");
        private readonly MyDefinitionId Light_Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Light_Turbolaser_Turret");

        private readonly MyDefinitionId AAT_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "AAT_Cannon_Large_Turret");
        private readonly MyDefinitionId ATAT_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "ATAT_Cannon_Large_Turret");
        private readonly MyDefinitionId Blue_SW_Starship_Laser_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Blue_SW_Starship_Laser_Cannon_Large_Turret");
        private readonly MyDefinitionId Falcon_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Falcon_Cannon_Large_Turret");
        private readonly MyDefinitionId Green_SW_Starship_Laser_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Green_SW_Starship_Laser_Cannon_Large_Turret");
        private readonly MyDefinitionId LAAT_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "LAAT_Cannon_Large_Turret");
        private readonly MyDefinitionId Red_SW_Starship_Laser_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Red_SW_Starship_Laser_Cannon_Large_Turret");
        private readonly MyDefinitionId Slave_1_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Slave_1_Cannon_Large_Turret");
        private readonly MyDefinitionId TIE_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "TIE_Cannon_Large_Turret");
        private readonly MyDefinitionId Vulture_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Vulture_Cannon_Large_Turret");
        private readonly MyDefinitionId XWing_Cannon_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "XWing_Cannon_Large_Turret");

        private readonly MyDefinitionId CIS_Flak_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "CIS_Flak_Cannon_Turret");
        private readonly MyDefinitionId CIS_Flak_Cannon_Light_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "CIS_Flak_Cannon_Light_Large_Turret");
        private readonly MyDefinitionId CIS_Flak_Cannon_Small_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "CIS_Flak_Cannon_Small_Turret");
        private readonly MyDefinitionId Clone_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Clone_Blaster_Turret");
        private readonly MyDefinitionId Clone_Flak_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Clone_Flak_Cannon_Turret");
        private readonly MyDefinitionId Clone_Flak_Cannon_Light_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Clone_Flak_Cannon_Light_Large_Turret");
        private readonly MyDefinitionId Clone_Flak_Cannon_Small_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Clone_Flak_Cannon_Small_Turret");
        private readonly MyDefinitionId Green_Rotary_Blaster_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Green_Rotary_Blaster_Cannon_Turret");
        private readonly MyDefinitionId Hypervelocity_Gun_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Hypervelocity_Gun_Turret");
        private readonly MyDefinitionId Imperial_Flak_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Imperial_Flak_Cannon_Turret");
        private readonly MyDefinitionId Imperial_Flak_Cannon_Light_Large_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Imperial_Flak_Cannon_Light_Large_Turret");
        private readonly MyDefinitionId Imperial_Flak_Cannon_Small_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Imperial_Flak_Cannon_Small_Turret");
        private readonly MyDefinitionId Large_Clone_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Large_Clone_Blaster_Turret");
        private readonly MyDefinitionId Large_Green_Rotary_Blaster_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Large_Green_Rotary_Blaster_Cannon_Turret");
        private readonly MyDefinitionId Large_Red_Rotary_Blaster_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Large_Red_Rotary_Blaster_Cannon_Turret");
        private readonly MyDefinitionId Light_Proton_Beam_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Light_Proton_Beam_Turret");
        private readonly MyDefinitionId Red_Rotary_Blaster_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Red_Rotary_Blaster_Cannon_Turret");
        private readonly MyDefinitionId Proton_Beam_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Proton_Beam_Turret");

        private readonly MyDefinitionId AAT_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "AAT_Cannon_Turret");
        private readonly MyDefinitionId ATAT_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "ATAT_Cannon_Turret");
        private readonly MyDefinitionId Blue_SW_Starship_Laser_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Blue_SW_Starship_Laser_Cannon_Turret");
        private readonly MyDefinitionId Falcon_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Falcon_Cannon_Turret");
        private readonly MyDefinitionId Green_SW_Starship_Laser_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Green_SW_Starship_Laser_Cannon_Turret");
        private readonly MyDefinitionId LAAT_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "LAAT_Cannon_Turret");
        private readonly MyDefinitionId Red_SW_Starship_Laser_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Red_SW_Starship_Laser_Cannon_Turret");
        private readonly MyDefinitionId Slave_1_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Slave_1_Cannon_Turret");
        private readonly MyDefinitionId TIE_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "TIE_Cannon_Turret");
        private readonly MyDefinitionId Vulture_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Vulture_Cannon_Turret");
        private readonly MyDefinitionId XWing_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "XWing_Cannon_Turret");

        private readonly MyDefinitionId Clone_Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Clone_Turbolaser_Turret");
        private readonly MyDefinitionId Heavy_Rebel_Cannon_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Heavy_Rebel_Cannon_Turret");
        private readonly MyDefinitionId Red_Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Red_Turbolaser_Turret");
        private readonly MyDefinitionId Turbolaser_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Turbolaser_Turret");

        private readonly MyDefinitionId DC15A_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "DC15A_Blaster_Turret");

        private readonly MyDefinitionId DC15s_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "DC15s_Turret");

        private readonly MyDefinitionId DC17m_Sniper_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "DC17m_Sniper_Turret");

        private readonly MyDefinitionId DC17m_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "DC17m_Turret");

        private readonly MyDefinitionId Droideka_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Droideka_Blaster_Turret");

        private readonly MyDefinitionId E5_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "E5_Blaster_Turret");

        private readonly MyDefinitionId E11_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "E11_Blaster_Turret");

        private readonly MyDefinitionId ELG3A_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "ELG-3A_Blaster_Turret");

        private readonly MyDefinitionId Han_Solo_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Han_Solo_Blaster_Turret");

        private readonly MyDefinitionId Heavy_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Heavy_Blaster_Turret");

        private readonly MyDefinitionId Westar_Blaster_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeGatlingTurret", "Westar_Blaster_Turret");

        private readonly MyDefinitionId Large_Concussion_Missile_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeMissileTurret", "Large_Concussion_Missile_Turret");
        private readonly MyDefinitionId Heavy_Concussion_Missile_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeMissileTurret", "Heavy_Concussion_Missile_Turret");

        private readonly MyDefinitionId Heavy_Energy_Torpedo_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeMissileTurret", "Heavy_Energy_Torpedo_Turret");

        private readonly MyDefinitionId Large_Proton_Torpedo_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeMissileTurret", "Large_Proton_Torpedo_Turret");

        private readonly MyDefinitionId Small_Concussion_Missile_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeMissileTurret", "Small_Concussion_Missile_Turret");

        private readonly MyDefinitionId Small_Proton_Torpedo_Turret = MyVisualScriptLogicProvider.GetDefinitionId(
           "LargeMissileTurret", "Small_Proton_Torpedo_Turret");


        private readonly Dictionary<TechGroup, HashSet<MyDefinitionId>> techsForGroup =
new Dictionary<TechGroup, HashSet<MyDefinitionId>>();

private readonly QueuedAudioSystem audioSystem;

internal ResearchControl(QueuedAudioSystem audioSystem)
{
this.audioSystem = audioSystem;
}

internal HashSet<TechGroup> UnlockedTechs { get; set; } = new HashSet<TechGroup>();

        internal void InitResearchRestrictions()
        {
            if (bNewResearch)
            {
                MyVisualScriptLogicProvider.ResearchListClear();
            }

            if (bVanillaBlocks)
            {
                NeedsResearch(largeMissileTurret, TechGroup.Rockets);
                NeedsResearch(smallMissileTurret, TechGroup.Rockets);
                NeedsResearch(rocketLauncher, TechGroup.Rockets);
                NeedsResearch(largeRocketLauncher, TechGroup.Rockets);
                NeedsResearch(smallReloadableRocketLauncher, TechGroup.Rockets);

                NeedsResearch(atmoThrusterSmallShipSmall, TechGroup.AtmoThrusters);
                NeedsResearch(atmoThrusterSmallShipLarge, TechGroup.AtmoThrusters);
                NeedsResearch(atmoThrusterLargeShipSmall, TechGroup.AtmoThrusters);
                NeedsResearch(atmoThrusterLargeShipLarge, TechGroup.AtmoThrusters);

                // V1.195 DLC
                NeedsResearch(SmallBlockSmallAtmosphericThrustSciFi, TechGroup.AtmoThrusters);
                NeedsResearch(SmallBlockLargeAtmosphericThrustSciFi, TechGroup.AtmoThrusters);
                NeedsResearch(LargeBlockSmallAtmosphericThrustSciFi, TechGroup.AtmoThrusters);
                NeedsResearch(LargeBlockLargeAtmosphericThrustSciFi, TechGroup.AtmoThrusters);

                // Power
                NeedsResearch(WindTurbineLarge, TechGroup.WindTurbines); // 1.194

                NeedsResearch(LargeBlockSolarPanel, TechGroup.SolarPanels);
                NeedsResearch(SmallBlockSolarPanel, TechGroup.SolarPanels);

                NeedsResearch(SmallBattery, TechGroup.Batteries);
                NeedsResearch(SmallBlockBatteryBlock, TechGroup.Batteries);
                NeedsResearch(LargeBlockBatteryBlock, TechGroup.Batteries);

                NeedsResearch(LargeBlockLargeGenerator, TechGroup.LargeReactors);
                NeedsResearch(LargeBlockSmallGenerator, TechGroup.SmallReactors);
                NeedsResearch(SmallBlockSmallGenerator, TechGroup.SmallReactors);
                NeedsResearch(SmallBlockLargeGenerator, TechGroup.LargeReactors);

                NeedsResearch(EngineLarge, TechGroup.HydrogenEngines);
                NeedsResearch(EngineSmall, TechGroup.HydrogenEngines);

                NeedsResearch(oxygenFarm, TechGroup.OxygenFarm);

                NeedsResearch(oxygenGeneratorLarge, TechGroup.OxygenGenerators);
                NeedsResearch(oxygenGeneratorSmall, TechGroup.OxygenGenerators);

                NeedsResearch(oxygenTankLarge, TechGroup.OxygenStorage);
                NeedsResearch(oxygenTankSmall, TechGroup.OxygenStorage);

                NeedsResearch(hydrogenTankLarge, TechGroup.HydrogenStorage);
                NeedsResearch(hydrogenTankSmall, TechGroup.HydrogenStorage);
                NeedsResearch(LargeHydrogenTankSmall, TechGroup.HydrogenStorage);// 1.194
                NeedsResearch(SmallHydrogenTankSmall, TechGroup.HydrogenStorage);// 1.194

                NeedsResearch(SmallGatlingTurret, TechGroup.BasicWeapons);
                NeedsResearch(SmallRocketLauncherReload, TechGroup.BasicWeapons);
                NeedsResearch(InteriorTurret, TechGroup.BasicWeapons);
                NeedsResearch(LargeGatlingTurret, TechGroup.BasicWeapons);

                NeedsResearch(LargeBlockArmorBlock, TechGroup.LgLightArmor);
                NeedsResearch(LargeBlockArmorCorner, TechGroup.LgLightArmor);
                NeedsResearch(LargeBlockArmorCornerInv, TechGroup.LgLightArmor);
                NeedsResearch(LargeRoundArmor_Slope, TechGroup.LgLightArmor);
                NeedsResearch(LargeRoundArmor_Corner, TechGroup.LgLightArmor);
                NeedsResearch(LargeRoundArmor_CornerInv, TechGroup.LgLightArmor);
                NeedsResearch(LargeHalfArmorBlock, TechGroup.LgLightArmor);
                NeedsResearch(LargeHalfSlopeArmorBlock, TechGroup.LgLightArmor);

                NeedsResearch(LargeHeavyBlockArmorBlock, TechGroup.LgHeavyArmor);
                NeedsResearch(LargeHeavyBlockArmorSlope, TechGroup.LgHeavyArmor);
                NeedsResearch(LargeHeavyBlockArmorCorner, TechGroup.LgHeavyArmor);
                NeedsResearch(LargeHeavyBlockArmorCornerInv, TechGroup.LgHeavyArmor);
                NeedsResearch(LargeHeavyHalfArmorBlock, TechGroup.LgHeavyArmor);
                NeedsResearch(LargeHeavyHalfSlopeArmorBlock, TechGroup.LgHeavyArmor);

                NeedsResearch(ionThrusterSmallShipSmall, TechGroup.IonThrusters);
                NeedsResearch(ionThrusterSmallShipLarge, TechGroup.IonThrusters);
                NeedsResearch(ionThrusterLargeShipSmall, TechGroup.IonThrusters);
                NeedsResearch(ionThrusterLargeShipLarge, TechGroup.IonThrusters);

                NeedsResearch(hydroThrusterSmallShipSmall, TechGroup.HydrogenThrusters);
                NeedsResearch(hydroThrusterSmallShipLarge, TechGroup.HydrogenThrusters);
                NeedsResearch(hydroThrusterLargeShipSmall, TechGroup.HydrogenThrusters);
                NeedsResearch(hydroThrusterLargeShipLarge, TechGroup.HydrogenThrusters);

                NeedsResearch(refinery, TechGroup.AdvancedRefineries);
                NeedsResearch(blastFurnace, TechGroup.BasicRefineries);
                NeedsResearch(BasicAssembler, TechGroup.BasicAssemblers);

                NeedsResearch(jumpDrive, TechGroup.JumpDrives);

                NeedsResearch(projectorLarge, TechGroup.Projectors);
                NeedsResearch(projectorSmall, TechGroup.Projectors);

                NeedsResearch(SkLarge, TechGroup.SurvivalKit);
                NeedsResearch(SkSmall, TechGroup.SurvivalKit);

                NeedsResearch(LargeBlockGyro, TechGroup.Gyros);
                NeedsResearch(SmallBlockGyro, TechGroup.Gyros);

                // detection
                NeedsResearch(radioAntennaLarge, TechGroup.RadioAntennas);
                NeedsResearch(radioAntennaSmall, TechGroup.RadioAntennas);
                NeedsResearch(LargeBlockRadioAntennaDish, TechGroup.RadioAntennas);

                NeedsResearch(LargeBlockLaserAntenna, TechGroup.LaserAntennas);
                NeedsResearch(SmallBlockLaserAntenna, TechGroup.LaserAntennas);

                NeedsResearch(LargeBlockBeacon, TechGroup.Beacons);
                NeedsResearch(SmallBlockBeacon, TechGroup.Beacons);

                NeedsResearch(LargeBlockSensor, TechGroup.Sensors);
                NeedsResearch(SmallBlockSensor, TechGroup.Sensors);
                NeedsResearch(LargeCameraBlock, TechGroup.Cameras);
                NeedsResearch(SmallCameraBlock, TechGroup.Cameras);

                // gravity
                NeedsResearch(GravityGenerator, TechGroup.GravityGens);
                NeedsResearch(GravityGeneratorSphere, TechGroup.GravityGens);

                NeedsResearch(SpaceBallLarge, TechGroup.ArtificialMass);
                NeedsResearch(SpaceBallSmall, TechGroup.ArtificialMass);
                NeedsResearch(VirtualMassLarge, TechGroup.ArtificialMass);
                NeedsResearch(VirtualMassSmall, TechGroup.ArtificialMass);

                // Programmable Block
                NeedsResearch(LargeProgrammableBlock, TechGroup.ProgrammableBlock);

                // V1.192
                NeedsResearch(SafeZoneBlock, TechGroup.SafeZone);
                NeedsResearch(StoreBlock, TechGroup.Economy);
                NeedsResearch(ContractBlock, TechGroup.Economy);

                // SE 1.192 Economy DLC
                NeedsResearch(VendingMachine, TechGroup.Economy);
                NeedsResearch(AtmBlock, TechGroup.Economy);

                // V1.193
                NeedsResearch(FoodDispenser, TechGroup.Economy);

                // V1.195 DLC
                NeedsResearch(SmallBlockSmallThrustSciFi, TechGroup.IonThrusters);
                NeedsResearch(SmallBlockLargeThrustSciFi, TechGroup.IonThrusters);
                NeedsResearch(LargeBlockSmallThrustSciFi, TechGroup.IonThrusters);
                NeedsResearch(LargeBlockLargeThrustSciFi, TechGroup.IonThrusters);
            }
            // Energy Shields. https://steamcommunity.com/sharedfiles/filedetails/?id=484504816
            NeedsResearch(LargeShipSmallShieldGeneratorBase, TechGroup.EnergyShields);
            NeedsResearch(LargeShipLargeShieldGeneratorBase, TechGroup.EnergyShields);
            NeedsResearch(SmallShipSmallShieldGeneratorBase, TechGroup.EnergyShields);
            NeedsResearch(SmallShipMicroShieldGeneratorBase, TechGroup.EnergyShields);
            NeedsResearch(ShieldCapacitor, TechGroup.EnergyShields);
            NeedsResearch(ShieldFluxCoil, TechGroup.EnergyShields);

            // MOD: Defense Shields - v1.91(3) https://steamcommunity.com/sharedfiles/filedetails/?id=1365616918
            NeedsResearch(DSControlTable, TechGroup.DefenseShields);
            NeedsResearch(DSControlLarge, TechGroup.DefenseShields);
            NeedsResearch(DSControlSmall, TechGroup.DefenseShields);
            NeedsResearch(NPCControlLB, TechGroup.DefenseShields);
            NeedsResearch(NPCControlSB, TechGroup.DefenseShields);
            NeedsResearch(NPCEmitterLB, TechGroup.DefenseShields);
            NeedsResearch(NPCEmitterSB, TechGroup.DefenseShields);
            NeedsResearch(DSSupergen, TechGroup.DefenseShields);
            NeedsResearch(EmitterL, TechGroup.DefenseShields);
            NeedsResearch(EmitterS, TechGroup.DefenseShields);
            NeedsResearch(EmitterST, TechGroup.DefenseShields);
            NeedsResearch(LargeShieldModulator, TechGroup.DefenseShields);
            NeedsResearch(SmallShieldModulator, TechGroup.DefenseShields);
            NeedsResearch(LargeEnhancer, TechGroup.DefenseShields);
            NeedsResearch(SmallEnhancer, TechGroup.DefenseShields);
            NeedsResearch(EmitterLA, TechGroup.DefenseShields);
            NeedsResearch(EmitterSA, TechGroup.DefenseShields);

            // MOD (2020 Update!) Star Wars Weapons https://steamcommunity.com/sharedfiles/filedetails/?id=598138548
            NeedsResearch(Heavy_Clone_Turbolaser, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Rebel_Cannon_Large, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Red_Turbolaser, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Turbolaser, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_AAT_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_ATAT_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Blue_SW_Starship_Laser_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Falcon_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Green_SW_Starship_Laser_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_LAAT_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Red_SW_Starship_Laser_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Slave_1_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Vulture_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_XWing_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(CIS_Flak_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(CIS_Flak_Cannon_Small, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Flak_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Flak_Cannon_Small, TechGroup.StarWarsWeapons);
            NeedsResearch(Death_Star_Explosive_Superlaser, TechGroup.StarWarsWeapons);
            NeedsResearch(Death_Star_Superlaser, TechGroup.StarWarsWeapons);
            NeedsResearch(Green_Rotary_Blaster_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Hypervelocity_Gun, TechGroup.StarWarsWeapons);
            NeedsResearch(Imperial_Flak_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Imperial_Flak_Cannon_Small, TechGroup.StarWarsWeapons);
            NeedsResearch(LAAT_Beam, TechGroup.StarWarsWeapons);
            NeedsResearch(Proton_Beam, TechGroup.StarWarsWeapons);
            NeedsResearch(SPHA_Weapon, TechGroup.StarWarsWeapons);
            NeedsResearch(TIE_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(AAT_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(ATAT_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Blue_SW_Starship_Laser_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Falcon_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Green_SW_Starship_Laser_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(LAAT_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Red_SW_Starship_Laser_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Slave_1_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Vulture_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(XWing_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Turbolaser, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Rebel_Cannon, TechGroup.StarWarsWeapons);
            NeedsResearch(Red_Turbolaser, TechGroup.StarWarsWeapons);
            NeedsResearch(Turbolaser, TechGroup.StarWarsWeapons);
            NeedsResearch(DC15A_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(DC15s, TechGroup.StarWarsWeapons);
            NeedsResearch(DC17m, TechGroup.StarWarsWeapons);
            NeedsResearch(DC17m_Sniper, TechGroup.StarWarsWeapons);
            NeedsResearch(Droideka_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(E5_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(E11_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(ELG3A_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(Han_Solo_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(Westar_Blaster, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Concussion_Missile, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Energy_Torpedo, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Compact_Concussion_Missile, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Compact_Proton_Torpedo, TechGroup.StarWarsWeapons);
            NeedsResearch(Small_Compact_Concussion_Missile, TechGroup.StarWarsWeapons);
            NeedsResearch(Small_Compact_Proton_Torpedo, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Clone_Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Rebel_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Red_Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Light_Clone_Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Light_Heavy_Rebel_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Light_Red_Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Light_Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(AAT_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(ATAT_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Blue_SW_Starship_Laser_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Falcon_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Green_SW_Starship_Laser_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(LAAT_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Red_SW_Starship_Laser_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Slave_1_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(TIE_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Vulture_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(XWing_Cannon_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(CIS_Flak_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(CIS_Flak_Cannon_Light_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(CIS_Flak_Cannon_Small_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Flak_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Flak_Cannon_Light_Large_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Flak_Cannon_Small_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Green_Rotary_Blaster_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Hypervelocity_Gun_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Imperial_Flak_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Imperial_Flak_Cannon_Small_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Clone_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Green_Rotary_Blaster_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Red_Rotary_Blaster_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Light_Proton_Beam_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Red_Rotary_Blaster_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Proton_Beam_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(AAT_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(ATAT_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Blue_SW_Starship_Laser_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Falcon_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Green_SW_Starship_Laser_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(LAAT_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Red_SW_Starship_Laser_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Slave_1_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(TIE_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Vulture_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(XWing_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Clone_Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Rebel_Cannon_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Red_Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Turbolaser_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(DC15A_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(DC15s_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(DC17m_Sniper_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(DC17m_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Droideka_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(E5_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(E11_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(ELG3A_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Han_Solo_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Westar_Blaster_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Concussion_Missile_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Concussion_Missile_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Heavy_Energy_Torpedo_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Large_Proton_Torpedo_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Small_Concussion_Missile_Turret, TechGroup.StarWarsWeapons);
            NeedsResearch(Small_Proton_Torpedo_Turret, TechGroup.StarWarsWeapons);


        }
        public void AllowUnlockedTechs()
{
UnlockTechsSilently(0, UnlockedTechs);
}

private void NeedsResearch(MyDefinitionId techDef, TechGroup techgroup)
{
if (techDef == null) return;

MyVisualScriptLogicProvider.ResearchListAddItem(techDef);

HashSet<MyDefinitionId> techsInGroup;
if (!techsForGroup.TryGetValue(techgroup, out techsInGroup))
{
    techsInGroup = new HashSet<MyDefinitionId>();
    techsForGroup.Add(techgroup, techsInGroup);
}
techsInGroup.Add(techDef);
}

// Untested
public void KeepTechsLocked()
{
//            ModLog.Info("KeepTechsLocked()");

foreach (var techGroup in techsForGroup)
{
    var group = techGroup.Key;
//                ModLog.Info("KTL: Group=" + group.ToString());
    if (UnlockedTechs.Contains(group))
    {
//                    ModLog.Info(" UNLOCKED");
        // OK to unlock
        var technologies = techsForGroup[group];
        foreach (var technology in technologies)
        {
            MyVisualScriptLogicProvider.ResearchListRemoveItem(technology); 
        }
    }
    else
    {
//                    ModLog.Info(" LOCKED");
        // block should be locked
        var technologies = techsForGroup[group];
        if (technologies == null)
        {
            ModLog.Error("No technologies for group: " + techGroup);
            continue;
        }
//                    ModLog.Info(" # blocks=" + technologies.Count.ToString());
        foreach (var technology in technologies)
        {
            MyVisualScriptLogicProvider.ResearchListAddItem(technology);
        }
    }
}
}

internal void UnlockTechGroupForAllPlayers(TechGroup techGroup)
{
if (UnlockedTechs.Contains(techGroup))
{
    return; // Already unlocked
}

HashSet<MyDefinitionId> technologies;
if (!techsForGroup.TryGetValue(techGroup, out technologies))
{
    ModLog.Error("No technologies for group: " + techGroup);
    return;
}
var players = new List<IMyPlayer>();
MyAPIGateway.Players.GetPlayers(players);
foreach (var player in players)
{
    foreach (var technology in technologies)
    {
        if (bNewResearch)
            MyVisualScriptLogicProvider.ResearchListRemoveItem(technology); // SE 1.189
        else
            MyVisualScriptLogicProvider.PlayerResearchUnlock(player.IdentityId, technology);
    }
}
UnlockedTechs.Add(techGroup);
audioSystem.PlayAudio(GetAudioClipForTechGroup(techGroup));
}

private static AudioClip GetAudioClipForTechGroup(TechGroup techGroup)
{
switch (techGroup)
{
    case TechGroup.Permabanned:
        return AudioClip.AllTechUnlocked;
    case TechGroup.AtmoThrusters:
        return AudioClip.UnlockAtmospherics;
    case TechGroup.Rockets:
        return AudioClip.UnlockedMissiles;
    case TechGroup.OxygenGenerators:
        return AudioClip.OxygenGeneratorUnlocked;
    case TechGroup.OxygenFarm:
        return AudioClip.OxygenFarmUnlocked;
    case TechGroup.OxygenStorage:
        return AudioClip.GasStorageUnlocked;
    case TechGroup.HydrogenStorage:
        return AudioClip.GasStorageUnlocked;
    case TechGroup.BasicWeapons:
        return AudioClip.BasicWeaponsUnlocked;
    default:
        return AudioClip.TechUnlocked;
}
}

public void UnlockTechsSilently(long playerId, HashSet<TechGroup> techGroups)
{
foreach (var techGroup in techGroups)
{
    var technologies = techsForGroup[techGroup];
    if (technologies == null)
    {
        ModLog.Info("No technologies for group: " + techGroup);
        return;
    }

    foreach (var technology in technologies)
    {

        if (bNewResearch)
            // unknown: does this work for ALL players?
            MyVisualScriptLogicProvider.ResearchListRemoveItem(technology); // SE 1.189
        else
            MyVisualScriptLogicProvider.PlayerResearchUnlock(playerId, technology);
    }
}
}

public void UnlockTechForJoiningPlayer(long playerId)
{
foreach (var techGroup in UnlockedTechs)
{
    var technologies = techsForGroup[techGroup];
    if (technologies == null)
    {
        ModLog.Error("No technologies for group: " + techGroup);
        return;
    }

    foreach (var technology in technologies)
    {
        if (bNewResearch)
            MyVisualScriptLogicProvider.ResearchListRemoveItem(technology); // SE 1.189
        else
            MyVisualScriptLogicProvider.PlayerResearchUnlock(playerId, technology);
    }
}
}
}
}

