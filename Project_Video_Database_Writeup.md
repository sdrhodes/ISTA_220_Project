Steven Rhodes

April 16, 2018

## Project video writeup

### Introduction and talking about myself

Hello,

I'm Steven Rhodes. I'm a member of the 42d Medical Support Squadron, located at Maxwell AFB. I discovered the MSSA program here at Ft Benning after reading a base bulletin that came across my desk.

At the time, last November, I was still determining the best use of my time during the last months of my enlistment. My shop was overmanned, and there wouldn't be much work for me to do. Having already been accepted in a computer science program in August 2018, I decided I could treat the MSSA program as a coding boot camp to give me an advantage at school. Upon discovering the opportunities and hearing of positions graduates were receiving, I decided to keep my options open.

Below I'll describe the database I've implemented for my inventory management program that is similar to many designs in modern video games.

### Discussing the Database

I'm implementing five tables in my database.

-The first table is the master list of items. It contains the item name, and item ID, which will be the primary table

-Items are divided between two types, equipable and potion-type.

-Both of these types refer to a StatTable, which contains stat values for each item. These stat weights determine an items effectiveness.

-Finally, weapon types are broken down into various weapon classes which describe how the item would be used. Maces would be for smashing, spears would be for piercing, etc.