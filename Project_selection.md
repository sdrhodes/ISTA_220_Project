Steven Rhodes

February 28, 2018

### Project selection

For my project, I will be creating an inventory system for a video game. This will be similar in function to inventory systems used in role-playing games, or action/adventure games. This is a menu, or a screen, with an interface that is designed for the player to arrange, compare, add, and drop items from their inventory. Typically, the inventory is a carried cache or backpack, a storage repository. In many games, gameplay would be paused while the player navigates to the inventory menu or screen. Many times, the inventory system is a subsystem of submenu of other systems.

### The User Interface (UI)
The user interface will be the primary object with which users interact. The representation of the inventory space will be a grid space, representing a backpack. The grid will contain icons, which are graphical representations of items held in the inventory. Another grid will represent a storage chest, which will represent items not stored on the user's character. Items can be dragged and dropped between the two storage locations, indicating an object was moved. A control will be created for allowing dropping, or deletion of an item. Another control would allow equipping of wearable objects, for example a shirt, or a sword that could be held in hand. Certain items will be stackable. An example would be a stack of cards would represent one block in the grid, but could contain 60 cards.

The user interface would contain a representation of the player's character, where items that are held in the inventory could be equipped. Surrounding the representation of the character would be blocks that correspond to areas of the body where equipment could be worn, such as the head block, for a helmet, or a foot block, for boots. If a wearable or equippable object is dragged over the character representation, or dragged over the block representing a body part, the item will be equipped. The UI should be able to automatically equip a helmet to head, gloves to hands, pants to legs, shoes to feet, etc.

A final element of the UI, will be the character statistics panel. This panel will reflect statistics that are related to items worn by the character. For example, the pants or shirt worn by the character might yield a degree of protection. This stat, protection, would be the sum of all equipped articles on the character that provide protection. I'm currently thinking of using Armor, Strength, Agility, and Intelligence. For the sake of this project, the stats are arbitrary, but I wish to include them to display features included in many games, and learn some of the logic behind those features.

### Graphical assets

Objects in the inventory system will be represented graphically. Items held in the inventory, will be represented by icons on the grid. These icons will either be pixel art, or scraped from existing free assets available online. The overall style of the UI will be dependent on how much time I'm able to dedicate to asset creation, and the difficulty of creating assets. A friend has offered assistance in creating the graphical elements.

Most of these items will be created in Unity. There are many existing tutorials that explain how to create these sorts of systems, and further tutorials are available on YouTube. Unity offers existing assets and the flexibility to customize them as needed.

### Database of objects

Objects in the inventory will reference data in a database. The database will contain statistics such as armor, strength, intelligence, and weight of the object. This data will be referenced by the corresponding graphical object with which the users interacts. Statistics in the UI will pull their information from a summed virtual table called "equipped." The details of how the program interfaces with the database are unknown to me at this time. Further research will be required.

### Conclusion

This project will be a challenge, but fun. It involves something I'm very interested in, which is game systems development. Although this will be a small component of what are typically larger more robust menu systems, the inventory system in most games is a critical component which which players frequently interact. These areas represent the "earned" items in the game. The player's virtual property, so it is critical that this system functions well and is intuitive.

Primary challenges will be learning how to create and interface with different assets, for example, the logic, art assets, and database. This will require a substantial amount of learning on my part, but I'm looking forward to it.

Thankfully many assets are readily available, and hundreds of tutorials exist for their creation.