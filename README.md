# F# Mutable Variables and References Bug

This example demonstrates unexpected behavior that can arise when using mutable variables and references together in F#.

The issue stems from how changes to mutable variables affect expressions that involve references.

## Bug

The `bug.fs` file shows a program that initializes mutable variables `x`, `y`, and a mutable reference `z`. It then adds `x` and `y`, prints the result, and prints the value of `z`. After modifying `x` and `y`, it again adds `x` and `y`, and prints the result and the value of `z`.

The unexpected behavior is in the output - the value of z doesn't change, while the values of x and y do change as expected.

## Solution

The `bugSolution.fs` file provides a correct implementation that ensures correct handling of mutable variables and references, and provides a clear explanation for the behavior. 