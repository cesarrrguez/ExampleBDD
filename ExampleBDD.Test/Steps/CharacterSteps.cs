using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ExampleBDD.Test.Steps
{
    [Binding]
    public class CharacterSteps
    {
        private Character _character;

        [Given(@"A new character")]
        public void GivenANewCharacter()
        {
            _character = new Character();
        }

        [Given(@"A character with (.*) of health")]
        public void GivenACharacterWithOfHealth(int health)
        {
            _character = new Character { Health = health };
        }

        [When(@"is attacked with (.*) of damage")]
        public void WhenIsAttackedWithOfDamage(int attackDamage)
        {
            Character enemy = new Character();
            Character.Attack(_character, attackDamage);
        }

        [When(@"is healed with (.*)")]
        public void WhenIsHealedWith(int healedValue)
        {
            Character otherCharacter = new Character();
            Character.Heal(_character, healedValue);
        }


        [Then(@"the health starting at (.*)")]
        public void ThenTheHealthStartingAt(int health)
        {
            Assert.AreEqual(health, _character.Health);
        }

        [Then(@"the level starting at (.*)")]
        public void ThenTheLevelStartingAt(int level)
        {
            Assert.AreEqual(level, _character.Level);
        }

        [Then(@"starting alive")]
        public void ThenStartingAlive()
        {
            Assert.IsTrue(_character.IsAlive);
        }

        [Then(@"the health is (.*)")]
        public void ThenTheHealthIs(int health)
        {
            Assert.AreEqual(health, _character.Health);
        }

        [Then(@"is dead")]
        public void ThenIsDead()
        {
            Assert.IsFalse(_character.IsAlive);
        }
    }
}
