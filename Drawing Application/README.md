# Readme for Drawing Application

# Canvas
This is the drawing surface for the application. This means that it is acting as a container of shapes so it has knowledge of the position and type of a shape.

### Decision: 
- The canvas should handle adding (and removing) shapes since it has to control how shapes are ultimately rendered.
- Hence there is an "add" method for each type of shape which ensures that creation of new shapes is controlled to ensure that they are valid objects.
- No "remove" methods have been created as the requirements do not ask for this functionality.

### Decision
- Since the canvas is controlling the list of shapes that it contains it makes sense that users cannot directly access this list (which is an implementation detail).
- However the console application needs to be able to print out details of the shapes that have been added. 
- For this purpose an enumerable version of the list is available so that users can iterate through the list of shapes. 
- This enumeration could have been restricted to supply only the string description but it seems reasonable that the client needs to be able to access the properties of a shape.

### Decision: 
- Initially I planned to override the ToString method of the canvas so that it returned a "display" of all shapes that had been added.
- However as the design evolved it became clear that the Canvas would just be acting as a mediator for the shapes which could be inflexible.
- This was how the override looked in the Canvas class before I changed the implementation:

```
public override string ToString()
{
	var builder = new StringBuilder();
	foreach (var widget in widgets)
	{
		builder.AppendLine(widget.ToString());
	}
	return builder.ToString();
}
```

# Widget
In the drawing application the objects added to the drawing surface need to contain both a position and a shape. 
So it makes sense to encapsulate these properties in a single class that handles the related values.

### Decision:
- Because the widget initialises with a shape object there is the chance for calling code to pass a null reference.
- So while this isn't mentioned in the requirements the class throws an ArgumentNullException when this takes place to ensure integrity of the widget object.

### Decision: 
- Since a widget object contains both the coordinates of a shape and the shape itself it makes sense that it handles the output of a shape description.
- I decided to override the ToString method to achieve this since this is a valid reason to override a base class method.

# All shape classes
These all inherit from a shared interface (despite IShape having no method definitions) to ensure that the Widget class can handle any new shape classes.

### Decision
- Each shape constrains widths/heights/dimensions to be positive by checking any supplied values and setting any negative values to the default value of zero.
- This has been achieved by adding an extension method to the 'int' class since that allows all shape classes to use a single implementation.
- Perhaps the classes could throw an exception in this scenario but I'm not sure that this is necessary (and it's not in the requirements).
- In reality any UI control used to define these shapes would prevent users from selecting negative dimensions so that this scenario couldn't occur.
- Still it's important for classes to ensure their own internal integrity which is why they don't allow negative dimension values.

### Decision
- For now the IShape interface contains no member definitions because the derived shape classes don't share any (apart from ToString which inherits from Object)
- In the future it seems likely that shared methods or properties will be added, such as around colour and area, but these aren't in the supplied specification.

### Decision
- The ToString method is also overridden in these classes since they are aware of their own internal state and so are best placed to generate a description of this state.

