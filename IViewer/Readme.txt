Player View
============
This contains the Windows Media Player
There is a small display of the duration of the current file being played.

Lyrics
-------
When lyrics are available, they are shown overlaid, in sync with the song.
For this, an lrc file of the same name must be in the folder of the song being played for this to work.

If you right click on the text being shown, you get a context menu with the following
* Increase / Decrease Font Size
* Change the Font Color
* Show Editor

Navigation View
================
* Root - Explorer of Computer
* Playlists - Node showing playlists available - double click to open
* Favorites - Saved from History
* Known Folders - Folders configured in Options that show up here

Context Menu:
 + Refresh folder
 + Flatten - shows all files in folder and all subfolders
 + Open it in windows

File Pane
==========
Shows files of the current folder / a search.
Search Bar
-----------
* Choose whether searching in File Name / Full Path / Folder (N/P/F)
	A label shows near the dropdown with a letter indicating what is selected.
* Enter text to search in Library
	Right click to get the History Context menu.
	Manage History to Add/reorder/manage favorites or remove items from history
* Enter text to search in Current Folder / Flat Folder

Double click a file to play it using the Windows Media Control.
Check / uncheck a file to add / remove it from the current playlist

Context Menu:
 + Open Containing Folder - opens the folder in windows explorer
 + Goto Folder - Navigates to the folder in the navication pane.
 + Check / Uncheck all
 + Windows Menu - Opens the system context menu for the file - not implemented yet

Playlist Pane
==============
Select and press Delete key to remove
Drag drop and Ctrl + Up / Down to change order - not implemented yet
Show invalid entries automatically - presently shows default file icon - can be more prominent

Context Menu:
+ Goto Folder - Navigates to the folder - not implemented yet

Status Bar
===========
There are 2 panes.
The first gives context on what is being shown in the Filelist (current folder file countr, how many search results / nature of search)
The second gives the name of the current file, and on the tooltip, where its playing from

Menu
=====
File
-----
* New / Save / Save As - Controls Playlists (stored in subfolder of exe of the same name).
* Open - Open will simply advise you to double click a node to open / ask if you want to refresh.
* Exit - Closes the Application

View
-----
* Toolbar - Toggles the Toolbar below the menu
* Status Bar - Toggles the Status Bar at the bottom
* Folders - Toggles the navigation view on the left
* Horizontal - Toggles between horizontal view where the navigation, file and playlist appear to the left of the player instead of below

* Return Selection - Brings the selection in the file / playlist back to the current playing file.
* Playlist - Cycles between showing file list, file and playlist, only playlist.
* Stick to Playlist - When checked, continue playing files from the playlist when both are open (plays from file list by default)
* Playlist Vertical - Toggles whether the playlist is to the right of the file list or below.

Media
------
Pertains to the player; the Windows Media .
* Restart Play - Play current file from the beginning.
* Stop Play - Problem with the player's usage causes it to Play next file on Stopping unless this toggle button is checked first.
* Volumn Up / Down / Mute - Controls the volumn
* Pan Left / Right - Moves the current position in the player back or forward 30 seconds (with Alt + Left / Right). Use Shift + Alt for 5 second steps and just Shift for 1 second steps.

Tools
------
* Save Media Library - Scans all favorite folders and creates a list of files in TimeLibrary.ini
* Reload Media Library - In case of manual changes to Library as in a cleanup
* Invalid File Links - Which files in the library are not valid anymore
* Options - lets you configure Known Folders, Favorites and edit History
