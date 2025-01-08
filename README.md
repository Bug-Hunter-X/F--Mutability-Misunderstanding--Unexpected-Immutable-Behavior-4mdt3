# F# Mutability Misunderstanding: Unexpected Immutable Behavior

This example demonstrates a common pitfall in F#: while you can declare variables as mutable using `let mutable`, the results of expressions involving them are *not* automatically updated when the mutable variable changes. This often leads to unexpected behavior. The core issue is that the expression `x + y` is evaluated at the time of assignment to `z`, not continuously updated.

**bug.fs** shows the incorrect behavior, and **bugSolution.fs** demonstrates a correct approach using a function to compute the sum dynamically.