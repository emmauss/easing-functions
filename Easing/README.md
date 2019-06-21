## How to use
This is a simple class library, so it will build to a single .dll file with the **Easing** namespace.

#### Things to know
###### The functions
There are 3 main functions for each ease type, there is **In**, **Out**, **In-Out**. These functions follow 
the `f(x) = y` format.

There are also 3 secondary functions **In Inverse**, **Out Inverse**, **In-Out Inverse**. These functions follow the 
`f(y) = x` format (you *can* use them for easing, but they're mainly there for utility, for example if you're easing the 
velocity of something, but only know it's velocity, you would use the inverse function of an ease to find its `X` coordinate).

All of the main functions follow this method signature.
```C#
public abstract Point EaseFunction(float x); // Finds Y using X, returns new Point(X, Y).
```

All of the secondary functions follow this method signature.
```C#
public abstract Point EaseFunctionInverse(float y); // Finds X using Y, returns new Point(X, Y).
```

###### Point struct
There is a `Point` struct that is used to map the function. It is a simple struct with `X` and `Y` coordinates.
Its purpose is in the name, it maps a point on a 2D plane using an `X` and `Y` axis.

###### Ease Origin and Destination property
In the `Ease` class there is a `Point Origin { get; set; }` and a `Point Destination { get; set; }` property. 
Using the default constructor for an `Ease` object will give you `Origin = new Point(0, 0)` and 
`Destination = new Point(1, 1)`.

Using the default constructor on the Cubic ease `Ease ease = new Cubic();`, and lets say we map the Cubic Out
function over time, we'll get a graph that looks like this:

![Cubic Out](/ReadmeImages/images/cubic-out-graph.png)

We can shift and scale this graph by changing the origin and destination though, we can do that manually using 
the properties in the `Ease` class or we can use the overloaded constructor like this `Ease ease = new Cubic(origin, destination);`
where `origin` and `destination` are of type `Point`. Lets say the origin is (2, 1) and the destination is (4, 3), 
with the Cubic Out, that will map a graph that looks like this:

![Cubic Out](/ReadmeImages/images/cubic-out-graph-scaled.png)



















Creating a Quartic ease object:
```C#
Ease ease;
ease = new Quartic();
```
That `ease` object will now 


```C#
Ease ease;
Point origin = new Point(3, 4);
Point destination = new Point(5, 5);

ease = new Quartic(origin, destination);
```