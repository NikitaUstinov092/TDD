using Crafting.Test.Model;
using NUnit.Framework;

namespace Crafting.Test
{
    [TestFixture]
    public class CraftingTest
    {
        private TestInventory _testInventory;
        private ItemCrafter _itemCrafter;

        private readonly ItemReceipt _axeReceipt = new ItemReceipt("Axe",
            new ItemIngredient("Wood", 2),
            new ItemIngredient("Stone", 1)
        );
    
        private readonly ItemReceipt _swordReceipt = new ItemReceipt("Sword",
            new ItemIngredient("Wood", 1),
            new ItemIngredient("Stone", 1),
            new ItemIngredient("Steal", 1)
        );

        [SetUp]
        public void Setup()
        {
            _testInventory = new TestInventory();
            _itemCrafter = new ItemCrafter(_testInventory);
        }

        [Test]
        public void CraftAxeTest()
        {
            //Arrange:
            _testInventory.Setup(
                "Wood",
                "Wood",
                "Wood",
                "Wood",
                "Wood",
                "Stone",
                "Stone"
            );

            //Act:
            _itemCrafter.Craft(_axeReceipt);

            //Assert:
            Assert.True(_testInventory.GetCount("Wood") == 3);
            Assert.True(_testInventory.GetCount("Stone") == 1);
            Assert.True(_testInventory.GetCount("Axe") == 1);
        }


        [Test]
        public void CraftSwordTest()
        {
            //Arrange:
            _testInventory.Setup(
                "Wood",
                "Wood",
                "Wood",
                "Stone",
                "Stone",
                "Steal"
            );

            //Act:
            _itemCrafter.Craft(_swordReceipt);

            //Assert:
            Assert.True(_testInventory.GetCount("Wood") == 2);
            Assert.True(_testInventory.GetCount("Stone") == 1);
            Assert.True(_testInventory.GetCount("Steal") == 0);
            Assert.True(_testInventory.GetCount("Sword") == 1);
        }
    
        [Test]
        public void CanCraftSwordTest()
        {
            //Arrange:
            _testInventory.Setup(
                "Wood",
                "Stone",
                "Steal"
            );

            //Act:
            var canCraft = _itemCrafter.CanCraft(_swordReceipt);

            //Assert:
            Assert.True((bool?)canCraft);
        }
    
        [Test]
        public void CannotCraftSwordTest()
        {
            //Arrange:
            _testInventory.Setup(
                "Steal"
            );

            //Act:
            var canCraft = _itemCrafter.CanCraft(_swordReceipt);

            //Assert:
            Assert.False((bool?)canCraft);
        }

    }
}
