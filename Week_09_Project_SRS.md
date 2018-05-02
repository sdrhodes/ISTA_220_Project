Steven Rhodes

April 20, 2018

## Project SRS

### Overview

1. The program will contain a single GUI that acts as the user interface. This interface will contain one view
2. The user interface will have three primary components
	* Inventory grid
	* Character panel with equip slots
	* Statistics (stats) pane
3. The inventory grid and character panel equip slots will contain items represented by icons
4. The items have stat values
5. Icons will be interactive. They can be repositioned between the inventory grid and character panel, signifying equipping or unequipping.
	* The character panel multiple positions signify an item is equipped, or worn by the character.
	* The inventory grid position signify an item is stored and not worn by the character
6. The stats pane will contain four values: strength, intellect, agility, stamina
7. The stat pane values will be the sum of the item's stats that are worn by the character (equipped)

###Functional Requirements

1. The items in the program will be represented by values held in a database.
2. Items are broken down into types - equip items, and potion items.
3. These items held in the database point to stat values that are reflected in the program. The stats are intellect, strength, stamina, and agility
4. The program must be able to interface with the database to provide the user a view of the stats of the items equipped by their character, and held in the inventory grid
5. The items are the component of the GUI that are interactive. Drag and drop functionality allows for the moving of items to the inventory grid, or equipping of items by moving them to the character panel
6. Equipping or removal of items from the character pane changes the total stat values of equipped items displayed in the character stat pane