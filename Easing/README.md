# How to use
This is a simple class library, so it will build to a single `.dll` file with the **Easing** namespace.

### Things to know
##### The functions
There are 3 main functions for each ease type, there is **In**, **Out**, **In-Out**. These functions follow the `f(x) = y` format:

![Main function format](/readme-images/normal-function.png)

There are also 3 secondary functions, **In Inverse**, **Out Inverse**, **In-Out Inverse**. These functions follow the `f(y) = x` format (you *can* use them for easing, but they're mainly there for utility, for example if you're easing the velocity of something, but only know it's velocity, you would use the inverse function of an ease to find its current `X` coordinate on an ease, and then use `X + Time.deltaTime` to find the next velocity).

![Main function format](/readme-images/inverse-function.png)

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

float inValue = ease.In(0.5f); // returns 0.125f
float outValue = ease.Out(0.5f); // returns 0.794f

float inInverseValue = ease.InInverse(0.125f); // returns 0.5f
float outInverseValue = ease.OutInverse(0.794f); // returns 0.5f
```

##### Ease Scale property
In the `Ease` class there is a `Vector Scale { get; set; }` property.

This property can be used to scale the function's input and output values, by default (in the default constructor) the scale will be `new Vector(1, 1)`. The default scale is `(1, 1)` because you don't have to scale the function *ever* if you don't want to, because when you're easing from one value to another, you can always just use output values of the ease as multipliers on all the values from the start to finish value.

Scaling may make your code easier to understand though, it will depend on the situation. In the [Easing Demo project](/Easing.Demo) I scaled the graph so that `Scale.X` mapped time, and `Scale.Y` mapped position, this seems fitting and much easier to grasp instead of calculating the percentage of time that has gone by compared to the total duration, and doing something similar to position.

##### Extra Notes
- An `Ease` object's `Scale` that contains a negative `X` or a negative `Y` value has not been tested, and the class library has not been develop with that functionality in mind. It *might* work, but be careful if you're attempting this without testing it first.
