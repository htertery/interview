# Implementation Plan

## Constraints

- Duration: 16 weeks
- Time budget: 5 hours/week
- Priority: coding, system design, and AI interviews with equal emphasis
- Tracking mode: manual-first with lightweight local automation
- Coding interview language: C# only

## Weekly Cadence (5h)

- Session A (90 min): coding interview simulation
- Session B (90 min): system design interview simulation
- Session C (90 min): AI interview simulation
- Session D (30 min): review, scoring, and adaptation decision

Total: 300 minutes (5 hours)

## Core Loop

1. Select one prompt per track.
2. Run timed session using checklist.
3. Log score and key misses in `templates/session_log.csv`.
4. Update topic status in `templates/mastery_matrix.csv`.
5. Weekly retrospective: pick top 2 weaknesses and assign next-week drills.

## Mastery States

- Not Started: no scored reps yet
- Practicing: at least 1 scored rep
- Solid: rolling average >= threshold over last 3 reps
- Mastered: 5 reps with no critical miss in that topic

## Thresholds

- Coding Solid threshold: 75+
- System Design Solid threshold: 75+
- AI Solid threshold: 75+

## Adaptation Rules

- Monthly trend review: capture at least 5 external signals
- Promotion trigger: if a topic appears in at least 3 credible signals, add it to next 2-week cycle
- Replacement rule: remove or de-prioritize lowest-impact topic to keep total hours fixed

## Weekly Review Questions

1. Which recurring error appeared at least twice this week?
2. Which track has lowest score trend over 2 weeks?
3. Which single drill will have highest score impact next week?
4. Do new AI trend signals require topic rotation?
