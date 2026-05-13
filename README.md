# InterfaceExercise

Extra exercise practicing C# interfaces.


## Task 1 - Basic interface
- `Program1` and `Program2` both implement `IStart` with a `Start()` method
- `Program2` additionally implements `IReset` with a `Reset()` method
- In `Main`, variables are declared as `IStart` — the caller only knows the contract, not the concrete type

### Reflection:
- The interface makes it easy to replace the underlying class implementation - just fulfill the contract.

## Task 2 - Explicit interface implementation
- `IFirst` and `ISecond` both declare `Run()`, but with different return types (`void` vs `int`)
- `ExplicitRunner` implements both using explicit interface implementation (`void IFirst.Run()`, `int ISecond.Run()`)
- Each version is only accessible through a variable typed as the specific interface

## Structure

```
extra-exercise-interface/
├── src/        # source code
├── docs/       # plans, notes, usage
└── material/   # received requirements, assets, feedback
```

## Running

```bash
dotnet run --project src/
```
