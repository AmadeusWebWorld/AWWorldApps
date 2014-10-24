Download the Cselian.IvyUpdater.exe and add a reference to it in your project
	You can change the name before adding the reference

Usage (In Code)
================
On startup, add the following code:
	if (UpdateManager.MustCheckForUpdates())
		UpdateManager.CheckForUpdates();
In your splash screen / anywhere else, to show the build / version
	var uv = UpdateManager.GetVersion();
Add a menu for Checking For updates manually
	UpdateManager.CheckForUpdates();
And a menu for Configuring the Settings
	UpdateManager.ShowSettings();

Configuration and Updates

Releasing
==========
In the App
-----------
Cselian.IvyUpdater.exe - added automatically with reference to exe
[ProductName].jpg - a 150 x 150px image shown on the left in the update window.
UpdateVersion.xml with these values:
	Version - this is the build number
	Date - the date of the release
UpdateSettings.xml with these values:
	Set by the Application (not configurable by user)
		Url - The url folder where the xml and zip files will be found. Must end with a /
		ProgramName - The name of your application
		Support - the support url / email (in case of any errors)
	Set by the User (via config)
		Frequency - One of AppStart|
	The dates are all nullable and will be set by the program.
	RemindAfter - should not be set it means its known that an update is available but is not wanted yet.

On the Web
-----------
UpdateVersion-[ProductName].xml
	The version / date of the last release (this should match the zip file's UpdateVersion.xml)
[ProductName]-latest.zip
	Since this is expected to be a portable app whatever you want to include can be here.
	Try to avoid overwriting the UpdateSettings.xml
	Always include the UpdateVersion.xml with the same version as the UpdateVersion-ProductName.xml. Else the same update will continuously be downloaded
