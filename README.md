# Group #3

## Module 3 Assignment: Guidelines 

The app will open child dialogs that are either ellipses or rectangles. 
One dimension (height or width) of each will be determined by a ratio that is set by the user. 
The child windows can have different colors and can be moved by the mouse.

Avoid long methods. Each method that you create should be short, to promote encapsulation. 
If you have a method that is longer than 25 lines, then it probably needs to be divided into smaller methods.

Use properties to encapsulate implementation details.

Use meaningful names for all variables. Any variable that ends with a number will lose points.

Do not create a new data structure, event, property if one that already exists will solve the problem.

## Module 3 Assignment: Tasks to be Completed

### Control Library
##### Add a project for a control library to the solution. Only add one control library: it will contain two controls and two forms. If Visual Studio does not have a template for a control library, you may use the Class Library for .NET Framework template. Delete the class file that is created and add a user control to create a control library.

- Add a user control that contains your group's name and the names of all the members.
- Use a new font, size and color for the names.
- Choose a background color for the control. This color should always be displayed when the control is added to a parent control.
- Dock the names so that they cover the entire user control. You will have to disable the auto-size property for the label.
- Add a user control that contains the course name and semester of the course.
- Use a separate label for each.
- Use the same font and color as was used for the group name.
- Make the font size of the course smaller than the font size of the group name.
- Make the font size of the semester smaller than the font size of the course.
- This control should use the background color and background image of the parent control that it is added to.
- Dock these so that one is above the other and they cover the entire control, no matter how the control is resized.
- Center each label in its control.
- Add a Windows Form that will be used as a base form.
- Allow the form to be moved by clicking and dragging with the mouse in the client area.
- Add a context menu to the form.
- Add an item named Preferences with a subitem named Colors. When clicked, the user can change the background color of the form by choosing a color from a ColorDialog.
- Add an item named File with a subitem named Close. This should close the form.
- Add a form that will be used as a base for dialogs.
- Dock the name control at the bottom of the dialog.
- Dock the course/semester control at the top of the dialog.
- Dock a panel in the middle that fills all the remaining space. The panel should show the background color and image of its parent.
- Interfaces
- Use interfaces to encapsulate implementation details. Design code so that the implementation details of data could be changed in the future without having to rewrite all the code that accesses that data.

### Preferences Dialog
##### Create a modeless dialog in the main application that will be used to gather information from the user.
- Extend it from the base dialog in the control library.

- Set the default, background image of the form to an image that is only added to this dialog's resources, not to the project resources. Choose a small image.
- The user interface should allow the user to enter the width of an elliptic child, height of a rectangular child and the ratio of the width to the height for elliptic and rectangular children. Add OK, Cancel and Apply buttons. Set the default buttons for the dialog.
- Perform thorough validation. Allow focus change. Choose reasonable validation ranges.
- Allow the form to be resized. No matter what the size is, none of the controls should ever disappear.
- Add the labels and text boxes to a new panel that is just large enough to contain them. The panel should be centered horizontally in the form. It should remain centered when the form is resized. The panel should have a different color from the rest of the dialog.

### Elliptic Child
##### Add a form in the main application that extends the moveable base form.
- Create a constructor that has a float parameter and an integer.
- Remove the frame from the form.
- Define the shape of the form as an ellipse. The integer parameter is the width. The height should be the width multiplied by the float parameter.

### Rectangular Child
#####  Add a form in the main application that extends the moveable base form.
- Create a constructor that has a float parameter and an integer.
- Remove the frame from the form.
- Define the shape of the form as a rectangle. The first parameter is the height. The width should be the height multiplied by the float parameter.

### Main Form
- Modify the main form for the project.
- Create a context menu with the following options for the preferences dialog.

##### Open Preferences Modally 
- Open the preferences dialog as a modal dialog. Be sure that its resources are released when you are done with it.
- Before the dialog is shown, the main form should update the properties for the for the form.
- If the user selects OK and closes the dialog, then the main form should retrieve the ellipse width, rectangle height, ellipse ratio and rectangle ratio values from the dialog. Disable the Apply buton when opened modally.

##### Open Preferences Modelessly - open the preferences dialog as a modeless dialog. Be sure that its resources are released when you are done with it.
- Before the dialog is shown, the main form should update the properties for the for the form.
- If the user selects OK or Apply, then the main form should retrieve the ellipse width, rectangle height, ellipse ratio and rectangle ratio values from the dialog. On OK, close the dialog. Do not close the dialog on Apply.
- If the user selects Cancel, ESC, Alt-F4, X button, revert to the orignal values when the dialog was opened.
- The dialog should never show behind the main form. Do not make it a top level form.

##### Add a menu to the form.
Add a top level menu named File.
- Add an item for opening an elliptic child. Send the value of the elliptic ratio and elliptic width values from the preferences to the constructor.
- Add an item for opening a rectangular child. Send the value of the height value and rectangle ratio value from the preferences to the constructor.
- Add an item for closing all rectangular children. Only enable the item when the form has at least one open rectangular child.
- Add an item for closing all eliptic children. Only enable the item when the form has at least one open ellipitic child.
- Add an item for closing the application.
- Add an item to the main menu, named Preferences, whose drop down is the context menu created above. Do not duplicate the items in the context menu, make the drop down of the new item the same as the context menu. Refer to the additional lecture notes on the class page for Inherited Menus

##### When the form closes, ask the user if they really want to close the application. Only close the application if the user confirms.