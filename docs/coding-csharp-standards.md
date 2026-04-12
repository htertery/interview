# Coding Interview C# Standards

This project uses C# as the default language for all coding interview practice.

## Runtime and Style

- Target modern C# syntax (C# 12 style where practical).
- Keep solutions framework-light and interview-friendly.
- Prefer readability first, micro-optimizations second.

## Expected Structure in Solutions

1. Brief problem framing and assumptions.
2. Chosen approach with complexity.
3. C# implementation.
4. Edge-case walkthrough.
5. Optional optimization note.

## Coding Checklist (C#)

- Use descriptive names (`left`, `right`, `windowStart`, `visited`).
- Keep methods focused and single-purpose.
- Avoid unnecessary allocations inside tight loops.
- Use `Dictionary<TKey, TValue>`, `HashSet<T>`, `List<T>`, and `PriorityQueue<TElement, TPriority>` appropriately.
- Prefer iterative solutions when recursion depth can be risky.
- Validate boundary cases (`null`, empty input, single-element, duplicates, overflow concerns).

## Communication in Interview

- State time and space complexity before coding final version.
- Narrate major decisions in concise checkpoints.
- Call out tradeoffs explicitly when choosing between two valid approaches.
