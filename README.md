# 🎧 INF 164 Group Project — Spotify on a Budget 

> Building the world's most *limited* music streaming platform, one merge conflict at a time.

![.NET](https://img.shields.io/badge/.NET-Framework-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=csharp)
![Vibes](https://img.shields.io/badge/vibes-immaculate-ff69b4?style=for-the-badge)
![Merge Conflicts Survived](https://img.shields.io/badge/merge_conflicts_survived-0-brightgreen?style=for-the-badge)

---

## 🎵 What is this?

A group project for **IN 164** where 8 people attempt to build a (very) scoped-down
Spotify clone using **C# WinForms**. No streaming servers, no record deals, no lawsuits
— just 4 forms, some text files pretending to be a database, and an embedded Windows
Media Player control doing its best.

---
## 🛣️ New to Git?
Click the link to read all about what you should know about 
[Git](https://github.com/OTWL/INF-164-Group-Project/blob/main/HOW_TO_GIT.md) or use the docs that were sent on WhatsApp

---

## 🧩 The Forms

| Form | What it does |
|---|---|
| 🔐 **Login** | Gatekeeps the app. Your password is stored in a `.txt` file. |
| 📝 **Create Account** | New user? Type a username, hope nobody else has it. |
| 🏠 **Home** | Welcome message, your playlists, upload songs, some stats to feel smart about. |
| 🎶 **Playlist** | Where the actual "Spotify" happens — play, sort, add, delete songs. |
| ❔ More to come? | Should we think of more forms, add them here|
---

## 🛠️ Tech Stack

- **Language:** C#
- **UI:** WinForms (.NET Framework)
- **"Database":** Text files (yes, really — `StreamReader`/`StreamWriter` and prayer)
- **Playback:** Windows Media Player control
- **Version Control:** Git + GitHub, branch-protected `main`, PRs required

---

## 🌳 Branching

Everyone works on their own feature branch. Nobody pushes to `main` directly —
`main` has trust issues after everything we've been through.

```
feature/login
feature/create-account
feature/home
feature/playlist
feature/...
```

---

## ⚠️ Non-Negotiables (per the brief — lose marks if missing)

- [x] Void and typed methods
- [x] SaveFileDialog / OpenFileDialog
- [x] StreamReader / StreamWriter
- [x] try/catch
- [x] if statements
- [x] Multiple Forms
- [x] for/while loops
- [x] Text file storage

---
## 🚀 Creativity — Sky's the Limit
 
The brief is the floor, not the ceiling. Our version of Spotify (on a budget) doesn't mean
it has to be a boring clone. Once the core requirements are ticked off, there's nothing
stopping anyone from going off:
 
- Custom themes / dark mode toggle 🌙
- Mini "now playing" animations or a fake visualizer 🎛️
- Easter eggs in the stats page (roast the user's music taste, why not)
- A weird custom sort order nobody asked for
- Making the UI look like it actually costs money
- Random Personal Greetings on the home page
If it doesn't break the non-negotiables and doesn't step on someone else's branch —
build it. Worst case, it doesn't make the final cut. Best case it's the thing that
makes this project actually fun to show off.
 
---


## 🙏 Group Survival Rules

1. Commit often. Push often. A commit that never gets pushed helps no one.
2. Renaming or deleting something someone else wrote? Give them a heads-up first.
3. Merge conflict ≠ emergency. Nothing is lost.
4. If in doubt, ask before you `git push --force`. Actually, just never do that.
5. **Know your own code.** We *will* be asked to explain what you wrote, don't just copy-paste something you don't understand.

---

<p align="center"><i>Built with C#, text files, and the collective patience of 8 people in one repo.</i></p>
