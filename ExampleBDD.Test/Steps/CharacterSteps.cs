using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ExampleBDD.Test.Steps
{
    [Binding]
    public class CharacterSteps
    {
        private Character character;

        [Given(@"A new character")]
        public void GivenANewCharacter()
        {
            character = new Character();
        }

        [Then(@"the health starting at (.*)")]
        public void ThenTheHealthStartingAt(int health)
        {
            Assert.AreEqual(health, character.Health);
        }

        [Then(@"the level starting at (.*)")]
        public void ThenTheLevelStartingAt(int level)
        {
            Assert.AreEqual(level, character.Level);
        }

        [Then(@"starting alive")]
        public void ThenStartingAlive()
        {
            Assert.IsTrue(character.IsAlive);
        }
    }
}
