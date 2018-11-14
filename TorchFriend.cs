using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TorchFriend
{
	class TorchFriend : Mod
	{
		public TorchFriend()
		{
		}

        public override void AddRecipeGroups()
        {
            RecipeGroup torchMaterials = new RecipeGroup(() => Lang.misc[37] + " Block", new int[]
            {
                ItemID.DirtBlock,
                ItemID.SnowBlock,
                ItemID.SlushBlock,
                ItemID.SiltBlock,
                ItemID.SandBlock,
                ItemID.AshBlock,
                ItemID.AsphaltBlock,
                ItemID.BoneBlock,
                ItemID.ClayBlock,
                ItemID.Cloud,
                ItemID.CrimstoneBlock,
                ItemID.CrimsandBlock,
                ItemID.CrystalBlock,
                ItemID.EbonsandBlock,
                ItemID.EbonstoneBlock,
                ItemID.FleshBlock,
                ItemID.GraniteBlock,
                ItemID.HoneyBlock,
                ItemID.IceBlock,
                ItemID.MarbleBlock,
                ItemID.MudBlock,
                ItemID.PearlsandBlock,
                ItemID.PearlstoneBlock,
                ItemID.PinkIceBlock,
                ItemID.RedIceBlock,
                ItemID.SandBlock,
                ItemID.SiltBlock,
                ItemID.SlushBlock,
                ItemID.SnowBlock,
                ItemID.StoneBlock,
                ItemID.TitanstoneBlock
            });
            RecipeGroup.RegisterGroup("TorchFriend:TorchMaterials", torchMaterials);
        }

        public override void AddRecipes()
        {
            addTorchRecipe();
            addWispRecipe();
        }

        private void addTorchRecipe() {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddRecipeGroup("TorchFriend:TorchMaterials", 25);
            recipe.SetResult(ItemID.Torch);
            recipe.AddRecipe();
        }

        private void addWispRecipe() {
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.SetResult(ItemID.WispinaBottle);
            recipe.AddRecipe();
        }
    }
}
