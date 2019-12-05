How the Questing system works:

Attaching to the NPC
-The quest gives is given the QuestGiver.cs found under scripts-Character-NPCScripts
-An emptyobject is placed in the envroment and given the name Quests
-this object is attached to the Quest NPC, along with hooking up the UI system, 
      and inside the UI system, the button to the scripts found on the NPC themselves. 
-pick out how many quests will be run by this character
-add the name of the cs file into the element blanks is if your script is named Slayer.cs you will enter Slayer

Creation of the Quests
-pick out which type of quest you need, killing, collecting, or create a new one following the template in there.
-copying the scripts in examples, copy them into your own scripts and modify details as needed.  
	itemID/enemyID... is the tag name on the object
