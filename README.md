# ACNH Tutorial Skip
Decompiled eventflow edits for Animal Crossing: New Horizons opening sequence

# About this Mod

This mod makes it possible to bypass most of the introductory sequence of the game.
Ideally, when finished, this will become the perfect tool for island builders who frequently remake their islands! 
Simply start a new game and enjoy.  
  
**WARNING**: Back up your save data using homebrew like JKSV or Checkpoint before using this mod!
It's largely untested, so there may be unintended side effects. Please let me know if anything weird happens!  

Wanna try it out? [Download here!](https://github.com/ShrineFox/ACNH-Tutorial-Skip/releases)

# Features
- No Timmy & Tommy Dialog in the airport! Just enter your player name, island name, birthday, and choose an island layout and player appearance.
- No intro video that usually plays before the plane lands.
- No dialog when landing. Simply talk to Tom Nook to receive your tent.
- No collecting items for the bonfire, and no crafting tutorial. Just talk to the two islanders and help them place their tents.
- Simply talk to Tom Nook after placing everyone's tent, and he'll give you the camping cot. Go to sleep and regular gameplay will begin. That easy!
Overall, it takes less than 3 minutes to get going with a fresh new town.  
  
This mod also (optionally) enables these progression-related features:
- Full 40 Item Inventory
- All Nook Phone Apps
- All Terraforming Abilities
- Happy Home Designer DLC Mode
- All DLC customization abilities
- Gyroids buried on your island
These flags are enabled once you are done placing all the tents.

# Known Issues
- Sometimes the two islanders that embark with you have no dialog when you talk to them. This is intentional to speed up onboarding.
- You still need to purchase the Tool Ring & Better DIY tool recipes manually once available in the shops.  
  
The RSTB file provided with this mod is for increased stability by only removing entries of files that it edits.
If you're using other mods that require the 0-byte RSTB file, delete the System folder of this mod first before installing!
Or, use my [RSTB Patcher GUI](https://gamebanana.com/mods/421696) to create your own customized RSTB file from your romfs folder!

# FUTURE PLANS
If possible, I will try to streamline the entire Nook questline leading up to inviting K.K. Slider to your island, since even with
this mod it still takes 20+ hours to complete. This would include skips for:
- Getting the tool recipes from Tom Nook
- Donating bugs/fish to Nook for Blathers
- Donating enough stuff to Blathers to open the museum
- Building the Nook's Cranny store
- Placing the first 3 new villager house plots and furnishing them
- Building the Resident Services building
- Expanding the player house/storage
- Building the Able Sisters shop
- Expanding the Nook's Cranny store
- Unlocking Tool Ring and Reactions
- Unlocking furniture and crafting recipes
- Maybe providing ways to remotely access ABD/storage/resident services via a Nook Phone app
- 
# Building the Mod
1. Clone the repository [asteriation/acnh-eventflow-compiler](https://github.com/asteriation/acnh-eventflow-compiler) to your GitHub folder.
2. Install the requirements using ``python3 -m pip install -r requirements.txt``.
3. Also clone this repository to your GitHub folder.
4. Compile edits for in-game usage with ``compile.bat`` (change paths in file as necessary).
5. If compilation succeeds, new files will appear in the ``Compiled`` folder.

# Credits
Using pre-decompiled EVFL with message annotations from [acnh.isomorphicbox.com/evfl](https://acnh.isomorphicbox.com/evfl).
