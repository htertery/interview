---
mode: ask
model: GPT-5.3-Codex
description: "Run a chapter-based interview coaching session with recap, Q&A, scoring, and logging guidance"
---

Run a chapter-based interview practice session.

Inputs:
- available minutes: ${input:minutes}
- preferred track (optional): ${input:track}

Steps:
1. Read current progress from:
- templates/session_log.csv
- templates/mastery_matrix.csv
- templates/trend_watchlist.csv
- templates/chapters.csv
- templates/chapter_sessions.csv
2. Provide a short recap.
3. Select active chapter (or recommend one).
4. Ask interview-style questions one by one.
5. After each user answer:
- score 0-5
- identify one gap tag
- suggest one follow-up drill
6. At session end:
- summarize strengths and top 2 gaps
- provide exact row(s) to append in chapter_sessions.csv and session_log.csv
- recommend next chapter action (continue, review, or complete)

Keep responses concise and practical.
