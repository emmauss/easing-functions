# How to use
This is a simple class library, so it will build to a single `.dll` file with the **Easing** namespace.

### Things to know
##### The functions
There are 3 main functions for each ease type, there is **In**, **Out**, **In-Out**. These functions follow 
the `f(x) = y` format.

There are also 3 secondary functions, **In Inverse**, **Out Inverse**, **In-Out Inverse**. These functions follow the 
`f(y) = x` format (you *can* use them for easing, but they're mainly there for utility, for example if you're easing the 
velocity of something, but only know it's velocity, you would use the inverse function of an ease to find its current `X` coordinate 
on an ease, and then use `X + Time.deltaTime` to find the next velocity).

###### Ease functions signatures
```C#
// Finds y using input x.
public abstract float In(float x);
public abstract float Out(float x);
public abstract float InOut(float x);

// Finds x using input y.
public abstract float InInverse(float y);
public abstract float OutInverse(float y);
public abstract float InOutInverse(float y);
```

###### Demonstration of using ease functions
```C#
Ease ease = new Cubic();

float inPoint = ease.In(0.5f); // returns 0.125f
float outPoint = ease.Out(0.5f); // returns 0.794f

float inInversePoint = ease.InInverse(0.125f); // returns 0.5f
float outInversePoint = ease.OutInverse(0.794f); // returns 0.5f
```

##### Point struct
There is a `Point` struct that is used to map each ease function. It is a simple struct with `X` and `Y` coordinates.
Its purpose is in the name, it maps a point on a 2D plane using an `X` and `Y` axis. The struct has a few more things 
that it can do, but generally it is intentially made small so that it can be easily replaced if you have a different piont system.

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
with the Cubic Out function, that will map a graph that looks like this:

![Cubic Out](/ReadmeImages/images/cubic-out-graph-scaled.png)

##### Extra Notes
The `Destination` of an ease object must **_always_** be greater than the `Origin` (`X` **and** `Y` value is greater). I may add functionality 
so that you can have an `Origin` and `Destination` that have no constraints on where they can be placed, but for now it is not like that.
