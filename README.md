# BandagedBD Installer

This is the source for the Windows installer of [BandagedBD](https://github.com/rauenzi/BetterDiscordApp), a mod for Discord. I decided to put this in a separate repo  mainly because it didn't feel quite right to have it in with the actual application itself as the application is JavaScript injection onto an Electron.js platform, and this is an actual executable that only sets ups files for it.

## Preview

![ScreenShot](https://i.zackrauen.com/2.png)

## System Structure

The system starts through the `FormMain` object which then adds the necessary control to the form. The controls to be added implement the interface `IPanel` and are represented in the accomanying enumeration `PanelTypes`. These two in tandem determine how the navigation through the installer occurs.

### PanelTypes

An enumeration representing all the available panels to have in the installer.

### IPanel

The interface `IPanel` requires the following functions:

1. `void OnShow` - Called when the control is added to the form
2. `void SetWindow(FormMain)` - Called when the main form prepares the panels, allows panels to keep a reference to the window/form

The interface also requires the following gettable properties:

1. `string Title` - The title of the panel to be shown in the form
2. `UserControl Control` - Returns an implied cast of self (useful for passing to other function in the main form)
3. `PanelTypes PreviousPanel` - Representation of the panel to go to when going "back"
4. `PanelTypes NextPanel` - Representation of the panel to go to when going "forward"

### FormMain

Creates and keeps a reference to all the `IPanel`s and even handles the navigation through the application. Also holds the enumeration of `PanelTypes`. Includes a function to return a reference to a specific panel so panels may reference each other (mainly used for panels to refer to the configuration panel).

### Discord

An enumeration representing the 3 release channels of Discord: Stable, Canary and PTB.

### Utilities

Utilities contains several functions used multple times throughout the application including things like killing and launching processes as well as searching for and resolving paths. Contains the `Discord` enumeration.

## Custom Components

The installer makes use of a few custom components either for modularity as in the `DiscordLocator` control or for the custom "flat" design as in WinForms not all controls have a decent flat style.

### DiscordLocator

This is a custom group of controls consisting of: 3 checkboxes that represent location enable, 3 textboxes showing the currently entered/found path, and 3 buttons that allow the user to browse for the path.

### Button

This is a simple wrap around the normal `Button` object to add some helpful functions.

### FlatCheckBox

The native checkbox leaves a lot to be desired in terms of extensibility and customization. To create custom styling this component paints it's own checkbox using the current graphics and imposing the string "✔" overtop.

### FlatProgressBar

Similar to the checkbox the native progressbar has little to no customization options. This paints a flat checkbox using the an offscreen image as adapted from this [StackOverflow answer](https://stackoverflow.com/a/7490884).

### Silent Setup

-install -i   Install BBD  
-uninstall -u   Uninstall BBD  
   Optional switches for uninstall  
      -deleteuserdata   deletes all user settings of betterdiscord  
      -repair -r   Repair BBD  
   Optional switches for repair, for the following issues  
      -repairupdateloop   Discord update loop  
      -repairnotlaunching   BandagedBD not launching with Discord  
      -repairloadingindefinitely   BandagedBD loading indefinitely  
      -repairjavascripterror   Fatal JavaScript error on launch  
  
all require using one or more of the following  
   -stable [path], -canary [path], -ptb [path]  
  
-norestart   By default discord will be restarted, this disables restarting of processes  
