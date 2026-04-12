# IC5+ Interview Training System

This repository is your long-term practice environment for senior software interviews (IC5+), covering:

- Coding interviews
- System design interviews
- AI-focused interview trends

Coding interview implementation language is standardized to C#.

The program is balanced equally across all three tracks and optimized for 5 hours/week over 16 weeks.

## Structure

- `docs/implementation-plan.md`: operating model, cadence, and milestone gates
- `docs/16-week-calendar.md`: week-by-week schedule
- `docs/coding-csharp-standards.md`: C# coding interview conventions and checklist
- `docs/chapter-practice-workflow.md`: chapter-first coaching lifecycle
- `templates/session_log.csv`: every session outcome and score
- `templates/mastery_matrix.csv`: topic-level mastery status by track
- `templates/trend_watchlist.csv`: external trend signals and adaptation decisions
- `templates/chapters.csv`: chapter goals, entry/exit criteria, and chapter status
- `templates/chapter_sessions.csv`: per-question chapter practice outcomes
- `templates/checklist.md`: reusable checklist for every session
- `prompts/`: starter prompt banks for coding, system design, and AI interviews
- `.github/prompts/run-chapter-session.prompt.md`: reusable guided chapter practice prompt

## Quick Start

1. Open chat and ask: "run a chapter session for 120 minutes".
2. I will recap progress, select the right chapter, ask interview-style questions one by one, then score (0-5) and tag gaps.
3. Log outcomes in:
- `templates/chapter_sessions.csv`
- `templates/session_log.csv`
- `templates/mastery_matrix.csv`
4. After each chapter session, I evaluate mastery:
   - **Mastered**: rolling average score >= 3.5 out of 5 AND exit criteria met → move to next chapter
   - **Needs work**: rolling average < 3.5 → redo chapter session or do targeted drills
   - **Partial progress**: rolling average 3.0-3.5 → one more session before final decision
5. Continue until chapter completion is recommended.
6. Add market/interview signals to `templates/trend_watchlist.csv` monthly.

For coding sessions, record `language=csharp` in the session log.

See `docs/agent-workflow.md` and `docs/chapter-practice-workflow.md` for the full agent-first lifecycle.

## Scoring Model (Equal Weight)

- Coding score: 0-100
- System design score: 0-100
- AI interview score: 0-100
- Composite weekly score:

$$
\text{Composite} = \frac{\text{Coding} + \text{SystemDesign} + \text{AI}}{3}
$$

## Milestones

- Week 4: baseline established across all tracks
- Week 8: reduce critical errors by at least 30% per track
- Week 12: stable pass-level across all tracks
- Week 16: final readiness decision and next-cycle focus
