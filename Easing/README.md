# How to use
This is a simple class library, so it will build to a single `.dll` file with the **Easing** namespace.

### Things to know
##### The functions
There are 3 main functions for each ease type, there is **In**, **Out**, **In-Out**. These functions follow 
the `f(x) = y` format.

There are also 3 secondary functions **In Inverse**, **Out Inverse**, **In-Out Inverse**. These functions follow the 
`f(y) = x` format (you *can* use them for easing, but they're mainly there for utility, for example if you're easing the 
velocity of something, but only know it's velocity, you would use the inverse function of an ease to find its `X` coordinate 
then use `X + Time.deltaTime` to find the next velocity).

###### Ease functions signatures
```C#
// Finds Y using X, returns new Point(X, Y).
public abstract Point In(float x);
public abstract Point Out(float x);
public abstract Point InOut(float x);

// Finds X using Y, returns new Point(X, Y).
public abstract Point InInverse(float y);
public abstract Point OutInverse(float y);
public abstract Point InOutInverse(float y);
```

###### Demonstration of using ease functions
```C#
Ease ease = new Cubic();

Point inPoint = ease.In(0.5f); // returns Point (X = 0.5f, Y = 0.125f)
Point outPoint = ease.Out(0.5f); // returns Point (X = 0.5f, Y = 0.794f)

Point inInversePoint = ease.InInverse(0.125f); // returns Point (X = 0.5f, Y = 0.125f)
Point outInversePoint = ease.OutInverse(0.794f); // returns Point (X = 0.5f, Y = 0.794f)
```

##### Point struct
There is a `Point` struct that is used to map each ease function. It is a simple struct with `X` and `Y` coordinates.
Its purpose is in the name, it maps a point on a 2D plane using an `X` and `Y` axis.

##### Ease Origin and Destination property
In the `Ease` class there is a `Point Origin { get; set; }` and a `Point Destination { get; set; }` property. 

Using the default constructor for an `Ease` object will give you `Origin = new Point(0, 0)` and 
`Destination = new Point(1, 1)`.

Lets use the default constructor on the Cubic ease `Ease ease = new Cubic();`, and lets say we map the Cubic Out
function over time, we'll get a graph that looks like this:

![Cubic Out](/ReadmeImages/images/cubic-out-graph.png)

We can shift and scale this graph by changing the origin and destination though, we can do that manually using 
the properties in the `Ease` class or we can use the overloaded constructor like this `Ease ease = new Cubic(origin, destination);`
where `origin` and `destination` are of type `Point`. Lets say the origin is (2, 1) and the destination is (4, 3), 
with the Cubic Out, that will map a graph that looks like this:

![Cubic Out](/ReadmeImages/images/cubic-out-graph-scaled.png)

##### Constraints
If you ever input an X or Y value into an ease function that is below the range of the origin, the function will return 
the `Origin` point. And if you ever input an `X` or `Y` value into an ease function that is above the range of the destination, 
the function will return the `Destination` point.

If for what ever reason your input resulted in an `X` or `Y` value that is `NaN` (not a number), the point returned will be the 
`Destination` point. The reason I decided the destination point should be returned is due to the fact that we're trying to get a 
number from one value to another value, if there is a `NaN` float breaking our chance of easing the change in value, it should at 
the very least get the value to it's destination, eased or not.