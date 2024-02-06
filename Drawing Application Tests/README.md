# Readme for Drawing Application Tests

The range of functionality being covered by these tests is fairly limited since the underlying classes are, at the moment, fairly simple.

# Canvas
- Since the canvas is a container that can hold zero to many shapes its tests are centred on ensuring that it correctly holds the shapes that have been added.

# Widget
- As this is a wrapper for a shape and its coordinates on the canvas the tests centre on initialising a widget and ensuring that its state is correct.
- Since a shape object is supplied to the widget it's possible that the calling code could supply a null reference.
- This scenario leads to a ArgumentNullException being thrown and so this scenario is tested.

# Shapes
- As shapes principally maintain their dimension values their tests revolve around making sure that the values can be initialised and updated correctly.
- In addition shapes are responsible for providing a description of their internal state and this is tested using the overridden ToString method.

