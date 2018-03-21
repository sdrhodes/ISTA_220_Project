Steven Rhodes

February 23, 2018

Project ideas for Cohort Four


## An inventory system for a role playing game

Many modern games contain inventory screens that show in-game items owned by your character. These screens usually consist of bag space - a repository for items held - and equipped items, or items worn by the character. Most inventory systems will display the name, stats, and a short description of selected items. Items that can be worn, but are not equipped, can be held in bag space. Equipping these items usually has an effect on the character. Stats of the item, for example, armor, are now applicable to the character's stats since the item is worn. Some items have a use function, if it is consumable, or can be used by the character.

The inventory system would contain a GUI with available character inventory space (bag space), laid out in a grid style, with icons arranged in the grid representing items held in inventory. Items could be repositioned on the grid. Items would reference a database of statistics.

### Nice to haves:

- Floating tool-tip that displays the stats of items when hovering over them with a cursor (bonus if it compares stats of currently equipped items)
- Custom art assets
- Character panel with an image of the character
- A merchant that can sell you items. A shop interface with a set amount of currency given to you when you start the program.

### Pros:

- I believe the logic required  to create this program would be simple, compared to the other ideas I'm proposing
- If it is feasible to implement the merchant function, I believe this could potentially be the most fleshed out of all my ideas
- Some assets might be readily available in Unity

### Cons:
- I lack the ability to create custom art assets, and this might consume a large amount of time
- Floating tool-tips might be difficult to code
- The program would be incomplete: inventory systems are usually small parts of menu systems


## A simple strategy game

Many modern designer strategy board games are ported to digital apps because the game systems behind them are logical, mathematical, and relatively convenient to represent in code. Examples of these would be Stone Age, Puerto Rico, Catan, etc.

Would contain a GUI with a minimum of player marker, score indicator, scoring system, way to accumulate points, some logic that allows for the computer to be an opponent, a database containing stats for units or markers. Personally, I'd enjoy making a sci-fi or space themed game. Example could be playing versus an infection that's slowly taking over a ship. You're the ships captain and must contain the infection for a certain amount of time or be overrun.

A database would contain element or "piece" power, statistics, etc.

It could be a competitive board game that requires input from multiple players.

### Pros:

- Out of all the ideas, I believe this one has the highest likelihood of being a completed project, instead of a component
- Would be fun to create
- Possibly could use Unity for art assets

### Cons:
- Logic being the game systems could be very difficult to code
- Unsure how to make a competitive game if input is only on one machine
- Coding a computer opponent or "AI" might be vastly difficult


## A dice-based randomly generated D&D style dungeon crawl

Would contain a tile set with a "board" representing the current dungeon. Randomly generated dungeons would be a possibility, though the logic might be difficult if I had to code it from scratch. Existing assets might be available on Unity for procedural/random generation. Enemy stats would be drawn from a database. Randomly dropped loot with different rarity depending on the toughness of monster that dropped it, also referenced from a database. A character creation module. Three basic weapon types. Small handful of skills, IE "move x tiles this turn," "heal x damage"." A dice rolling component/randomizer to determine skill rolls.

Examples include Dungeons and Dragons: Castle Ravenloft board game, Dungeons and Dragons: Wrath of Ashardalon board game

### Pros:
- I believe this would require the least complex logic on the back end
- Could be a fun, simple single player game that is fun
- Would be a solid contribution to my portfolio

### Cons:
-This could require many art assets

## A fishing game

Would consist of a fishing GUI with a bobber that you would click on, and a reeling interface with a moving slider that you have to "keep up with," similar to implementations in other games such as Rune Factory, Stardew Valley, etc. Database of fish with names and traits. Logic that controls the likelihood of a catch, and determines what bites you get - adds some randomization while ensuring that bites happen within a maximum amount of time. Some fish will be more rare than others.

### Pros:
- This would be another simple program
- Could be fun to play
- Art assets might be fun to design

### Cons:
- Overly simple
- Not a great portfolio addition
