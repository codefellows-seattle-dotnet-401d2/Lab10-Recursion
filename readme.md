#### Towers of Hanoi
Author: Jeff Martinez
Version: 1.0.0

#### Overview
This application takes in a number and outputs every move it would take to complete the Towers of Hanoi problem.  

#### Getting Started
- To build this application you need to create a method that contains the formula 2*MethodName(n-1)+1. This method needs to call itself recursively to run correctly.
- In order to output to the console with the calculated moves you need to create a method that will take in the (n) as well as the pillars that (n) needs to transfer to and from



#### Example
```
Towers of Hanoi
Move n 1 from tower 1 to tower 3
Move n 2 from tower 1 to tower 2
Move n 1 from tower 3 to tower 2
Move n 3 from tower 1 to tower 3
Move n 1 from tower 2 to tower 1
Move n 2 from tower 2 to tower 3
Move n 1 from tower 1 to tower 3
Move n 4 from tower 1 to tower 2
Move n 1 from tower 3 to tower 2
Move n 2 from tower 3 to tower 1
Move n 1 from tower 2 to tower 1
Move n 3 from tower 3 to tower 2
Move n 1 from tower 1 to tower 3
Move n 2 from tower 1 to tower 2
Move n 1 from tower 3 to tower 2
Total Number of Moves: 15

```

#### Architecture
This application is created using ASP.NET Core 2.0 Console applicaitons. 
Language: C# 
Type of Applicaiton: Console Application 

