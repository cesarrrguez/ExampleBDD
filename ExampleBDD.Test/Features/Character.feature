Feature: Character

Scenario: Creation of a character
	Given A new character
	Then the health starting at 1000
	And the level starting at 1
	And starting alive

Scenario: Characters can Deal Damage to Characters
	Given A character with 800 of health
	When is attacked with 100 of damage
	Then the health is 700

Scenario: Health can not be less than 0
	Given A character with 800 of health
	When is attacked with 900 of damage
	Then the health is 0
	And is dead

Scenario: Dead characters cannot be healed
	Given A character with 0 of health
	When is healed with 100
	Then the health is 0

Scenario: Healing cannot raise health above 1000
	Given A character with 900 of health
	When is healed with 150
	Then the health is 1000