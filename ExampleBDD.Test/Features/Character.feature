Feature: Character

Scenario: Creation of a character
    Given A new character
    Then the health starting at 1000
    And the level starting at 1
    And starting alive