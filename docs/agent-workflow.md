# Agent-First Workflow

This repository now uses an agent-first operating model.

## Why

Practice may be irregular (skipped weekdays, heavier weekends), so static weekly plans are less useful than state-aware guidance.

## Session Lifecycle

1. Open repository and ask for recap + next practice.
2. Agent reads:
- `templates/session_log.csv`
- `templates/mastery_matrix.csv`
- `templates/trend_watchlist.csv`
3. Agent returns:
- quick recap of previous progress
- recommended next session based on gaps and balance
4. You complete practice.
5. Agent helps you log session updates.
6. Agent recalculates what to do next.

## Recommendation Policy

- Keep equal long-run emphasis across:
- coding
- system design
- AI interview preparation
- Prioritize under-practiced or weak topics first.
- Use available time windows:
- Compact: <= 90 minutes
- Full: 91-150 minutes
- Deep: >= 151 minutes

## Coding Language Policy

- All coding interview practice is C# only.
- Session log must keep coding rows with `language=csharp`.

## Optional CLI Fallback

If needed, these commands still work:

```powershell
python tracker/progress_tracker.py resume 120
python tracker/progress_tracker.py next-session 180
python tracker/progress_tracker.py update-mastery
```

The CLI is optional. Agent guidance is the default workflow.
