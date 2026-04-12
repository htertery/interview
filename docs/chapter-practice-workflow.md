# Chapter-Based Practice Workflow

This repository uses a chapter system instead of rigid weekly-only progression.

## Core Model

- A chapter is a focused learning unit with entry criteria and exit criteria.
- Each chapter ends with a guided practice interview.
- Guided practice is interactive: questions, answers, scoring, and targeted drill assignment.

## Session Flow

1. Recap current state (last session, averages, weak topics, active chapter).
2. Confirm available time.
3. Pick chapter scope:
- Compact: 1-2 questions and one drill
- Full: 3-4 questions and two drills
- Deep: 5+ questions and one mini mock
4. Run interview-style questions interactively.
5. Score each answer (0-5), tag gaps, and assign follow-up drill.
6. Log outcomes in:
- `templates/chapter_sessions.csv`
- `templates/session_log.csv` (for track-level score)
- `templates/mastery_matrix.csv` (status updates)
7. Decide chapter status:
- planned -> active -> review -> completed

## Gap Tags

Use consistent tags to track growth areas:

- framing
- tradeoffs
- complexity
- edge-cases
- communication
- reliability
- eval-metrics
- safety
- cost-latency

## Mastery Evaluation

After each chapter session, evaluate mastery:

1. Calculate rolling average of all answer scores in this chapter (from `templates/chapter_sessions.csv`).
2. Mastery threshold: rolling average >= 3.5 out of 5, and at least 3 scored answers.
3. Exit criteria check: confirm exit criteria from `templates/chapters.csv` is met (e.g., 3 medium problems solved with score >= 75).
4. Decision:
   - **Mastered**: Both mastery threshold >= 3.5 AND exit criteria met → chapter status = completed
   - **Needs Redo**: Mastery threshold < 3.5 OR exit criteria not met → recommend redo chapter session or targeted drill
   - **Partial**: Mastery threshold >= 3.0 but < 3.5 → recommend one more chapter session before deciding

## Exit Rule

Mark chapter completed ONLY when:

1. Mastery threshold rolling average >= 3.5 (no answer < 3, most 4-5)
2. Exit criteria from `templates/chapters.csv` is explicitly met
3. Last 3 answers in chapter show consistent strength (no regression)

## Coaching Rule

After every chapter practice, provide:

1. Current chapter performance (rolling avg, answer count)
2. Mastery status (not yet / partial / ready to complete)
3. Top 2 gaps if score < 3.5
4. One clear next action:
   - If mastered → move to next chapter
   - If partial → one more session with focus on lowest-scoring question
   - If needs work → specific drill targeting top gap tag
