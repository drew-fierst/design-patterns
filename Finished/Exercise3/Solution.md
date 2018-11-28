Exercise 3 Solution
===================

**NOTE: this is only one possible solution. Many valid solutions may exist. It is often helpful to discuss their respective merits.**

The composite pattern can be used to organize all of the classes into a hierarchy: Inspections containing Buildings which contain Floors which contain the leaves of Control Panels, Pull Switches, Smoke Detectors and Sprinklers.

In addition, since the leaves contain no state and there are many of them needed, the Flyweight pattern can be used to manage the sharing of multiple instances of them.

