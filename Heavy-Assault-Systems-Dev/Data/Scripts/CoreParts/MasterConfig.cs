﻿
namespace Scripts
{
    partial class Parts
    {
        internal Parts()
        {
            // naming convention: WeaponDefinition Name
            //SA_HMI_ERGaussRF
            // Enable your definitions using the follow syntax:
            // PartDefinitions(Your1stDefinition, Your2ndDefinition, Your3rdDefinition);
            // PartDefinitions includes both weapons and phantoms
            PartDefinitions(

            HAS_Vulcan,

            HAS_Crossfield,
            HAS_CrossfieldOne,
            HAS_CrossfieldTwo,
            HAS_CrossfieldThree,
			
			HAS_Esper,
			HAS_Mammon,
            HAS_Nyx,
            HAS_Thanatos
			
			
            );
            ArmorDefinitions();
            SupportDefinitions();
            UpgradeDefinitions();
        }
    }
}
