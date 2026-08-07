# 🧭 How to Use Git — Step by Step

A brief walkthrough for anyone on the team who is new to Git. Everything
here is done inside **Visual Studio** — no terminal needed.

---

## 1. Clone the repo (one-time setup)

1. Open Visual Studio
2. Click **Clone a Repository**
3. Paste the repo URL: `https://github.com/OTWL/INF-164-Group-Project.git`
4. Select a path for the repo (folder) to be stored

### Clone Repo
![Clone repository screenshot](https://github.com/user-attachments/assets/c81d0cd2-bef2-4849-8aa6-66ffca463e1a)

### Repo / Folder Settings
<img width="1933" height="1073" alt="ScreenShot2" src="https://github.com/user-attachments/assets/983b54f8-2dab-4498-a479-8015a3baa219" />

4. Sign into your GitHub account if prompted

---

## 2. Open the project

The project would have opened now. If nothing appears, click on Form1.cs
<img width="1920" height="1020" alt="ScreenShot3" src="https://github.com/user-attachments/assets/8c91d13a-45ac-458f-970e-14057fa0d823" />

## 3. Access Git Changes

Next to the Solution Explorer, a label with GIt Changes is visible. Click on it to access Git Changes
<img width="1920" height="1020" alt="ScreenShot4" src="https://github.com/user-attachments/assets/17a17c1d-2bc8-491c-82eb-416881cee28c" />

---

## 4. Switch to your feature branch

There are 2 ways to do this!

1. Bottom-right corner of Visual Studio shows the current branch name
2. Click it → select your branch (e.g. `feature/login`) from the list
3. If it doesn't exist yet, click **New Branch** and create it off `main`

<img width="1920" height="1058" alt="image" src="https://github.com/user-attachments/assets/42ffeb28-4b4a-446b-8dcb-562be81e788e" />
 ### OR

 1. Go to Git Changes Window
 2. Press main (or current branch name)
 3. Select new branch

<img width="1988" height="1020" alt="ScreenShot5" src="https://github.com/user-attachments/assets/3a0ecb50-23f0-4c97-834c-f432dc35747f" />



---

## 4. Make your changes

Write your code as normal. Git only starts tracking once you save and it shows up
under **Changes**.

---

## 5. Commit your changes

1. Open **Git Changes** panel (View → Git Changes, or it auto-opens after edits)
2. Type a short message describing what you did
3. Click **Commit All** (1)

<img width="1920" height="1020" alt="ScreenShot6" src="https://github.com/user-attachments/assets/e417367c-2175-43c7-b90d-302b3bc68e82" />

---

## 6. Push your changes

Click the **↑ (up arrow)** in the Git Changes panel, or hit **Sync** (2) to pull first
then push. This sends your commits to GitHub.

<!-- 📸 Screenshot: Push/Sync buttons -->
<img width="1920" height="1020" alt="ScreenShot6" src="https://github.com/user-attachments/assets/15013d22-c0c0-4ede-a5d6-1b851cf08b65" />


---

## 7. Open a Pull Request (when your feature is done)

1. After pushing, VS or GitHub will show a **"Create Pull Request"** link/banner4   
2. Set Base: `main` ← Compare: your branch
3. Add a short description
4. Click **Create Pull Request**

<!-- 📸 Screenshot: Create Pull Request page on GitHub -->
![Pull request screenshot](screenshots/06-pull-request.png)

---

## 8. Get it reviewed and merged

A teammate reviews and approves the PR on GitHub, then either of you clicks
**Merge pull request**. This is the *only* way code gets into `main`.

<!-- 📸 Screenshot: Merge pull request button -->
![Merge screenshot](screenshots/07-merge.png)

---

## 🔁 Quick summary loop

```
Clone (once) → Switch to your branch → Edit code → Commit → Push
→ Open PR → Get reviewed → Merge into main
```

## ⚠️ Remember

- Never work directly on `main`
- Commit often, push often
- If you're unsure what a merge conflict means, ask before resolving it blindly
