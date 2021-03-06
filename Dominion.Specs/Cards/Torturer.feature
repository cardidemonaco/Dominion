﻿Feature: Torturer

Scenario: Player plays Torturer and opponents must decide whether to discard cards or gain a curse
	Given A new game with 3 players	
	And Player1 has a Torturer in hand instead of a Copper
	When Player1 plays a Torturer
	Then Player1 should have 7 cards in hand
	And Player2 must choose whether to discard cards (Yes or No)
	And Player3 must choose whether to discard cards (Yes or No)

Scenario: Player plays Torturer and opponent decides to discard cards
	Given A new game with 2 players	
	And Player1 has a Torturer in hand instead of a Copper
	When Player1 plays a Torturer	
	And Player2 chooses to discard cards (Yes)
	Then Player2 must select 2 cards to discard

Scenario: Player plays Torturer and opponent decides to gain a curse
	Given A new game with 2 players	
	And Player1 has a Torturer in hand instead of a Copper
	When Player1 plays a Torturer	
	And Player2 chooses to gain a curse (No)
	Then Player2 should have 6 cards in hand
	And All actions should be resolved

Scenario: Player decides to discard to torturer with only 1 card in hand
	Given A new game with 2 players	
	And Player1 has a Torturer in hand instead of a Copper
	And Player2 has a hand of Copper
	When Player1 plays a Torturer	
	And Player2 chooses to discard cards (Yes)
	Then Player2 should have 0 cards in hand
	And All actions should be resolved
