# 🎧 INF 164 Group Project 

> Building a scaled-down version of Spotify

![.NET](https://img.shields.io/badge/.NET-Framework-512BD4?style=for-the-badge&logo=dotnet)
![C#](https://img.shields.io/badge/C%23-WinForms-239120?style=for-the-badge&logo=csharp)
![Vibes](https://img.shields.io/badge/vibes-immaculate-ff69b4?style=for-the-badge)

---

## 🎵 What is this?

This project is a group effort for **INF 164** where 8 individuals collaborated to build a highly scoped-down version of Spotify using **C# WinForms**. The goal was to meet specific academic requirements while exploring basic application development concepts.

---

## 📋 Table of Contents

- [About the Project](#-what-is-this)
- [Key Features](#key-features)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [Installation](#-installation)
- [Usage](#-usage)
- [How to Use](#-how-to-use)
- [License](#-license)
- [Footer](#footer)

---

## ✨ Key Features

- **User Authentication:** Secure login and account creation.
- **Music Playback:** Play, pause, and manage audio files using an embedded Windows Media Player.
- **Playlist Management:** Create, add, delete, and sort songs within playlists.
- **Song Upload:** Ability to upload audio files to the application.
- **Text File "Database":** User data and song information stored in plain text files using `StreamReader` and `StreamWriter`.
- **Form Navigation:** Multiple forms for distinct functionalities (Login, Create Account, Home, Playlist).
- **Core C# Constructs:** Implementation of void and typed methods, `try-catch` blocks, conditional statements (`if`), loops (`for`, `while`), and file I/O operations.

---

## 🛠️ Tech Stack

- **Language:** C#
- **UI Framework:** WinForms (.NET Framework)
- **"Database" Storage:** Text files (`StreamReader`/`StreamWriter`)
- **Audio Playback:** Windows Media Player control
- **Version Control:** Git + GitHub

---

## 📂 Project Structure

The project follows a typical .NET WinForms application structure. Key directories and files include:

- `INF-164-Group-Project/`
  - `Properties/`
    - `AssemblyInfo.cs`
    - `Resources.Designer.cs` & `.resx`
    - `Settings.Designer.cs` & `.settings`
  - `App.config`
  - `Form1.Designer.cs`
  - `frmHome.cs` & `.Designer.cs` & `.resx`
  - `frmLogin.cs` & `.Designer.cs` & `.resx`
  - `frmPlaylist.cs` & `.Designer.cs` & `.resx`
  - `frmRegisterAccount.cs` & `.Designer.cs` & `.resx`
  - `FrmSongInfo.cs` & `.resx`
  - `Global.cs`
  - `GroupProject.csproj`
  - `GroupProject.slnx`
  - `HOW_TO_GIT.md`
  - `Playlist.cs`
  - `Program.cs`
  - `Song.cs`
  - `User.cs`

---

## 📥 Installation

To set up and run this project locally, follow these steps:

1.  **Clone the Repository:**
    ```bash
    git clone https://github.com/OTWL/INF-164-Group-Project.git
    cd INF-164-Group-Project
    ```

2.  **Prerequisites:**
    - **.NET Framework:** Ensure you have a compatible version of the .NET Framework installed (version details can be inferred from `GroupProject.csproj`).
    - **Visual Studio:** It is recommended to use Visual Studio for developing and running WinForms applications.

3.  **Build the Project:**
    - Open the solution file (`GroupProject.slnx`) in Visual Studio.
    - Build the project (Build > Build Solution).

4.  **Run the Application:**
    - After a successful build, you can run the application from Visual Studio (Debug > Start Debugging) or by executing the compiled executable from the output directory.

---

## ▶️ Usage

This application functions as a basic music player and library manager. Users can:

1.  **Create an Account:** Register a new user profile.
2.  **Log In:** Authenticate using existing credentials.
3.  **Manage Playlists:** Create and organise playlists with songs.
4.  **Upload Songs:** Add local audio files to the application's library.
5.  **Play Music:** Select songs from playlists to play them.

---

## 🚀 How to Use

1.  **Launch the Application:** Upon launching, you will be presented with the **Login** form.
2.  **Authentication:**
    *   If you are a new user, click on the **Create Account** button to register.
    *   Enter your username and password in the respective fields and click **Login**.
3.  **Home Page:** After successful login, you will see the **Home** page, which displays a welcome message, your existing playlists, and options to upload songs.
4.  **Playlist Interaction:**
    *   Navigate to the **Playlist** form to view, manage, and play songs within a selected playlist.
    *   You can add new songs to a playlist, remove existing ones, and sort them.
    *   The **Windows Media Player** control embedded within this form will handle audio playback.
5.  **Song Upload:** On the **Home** page, use the upload functionality to add new music files to your library. The application uses `SaveFileDialog` to let you choose local files.

---

## 🌳 Branching Strategy

The project utilises a feature branching strategy for collaborative development:

- **Feature Branches:** Each developer works on their own dedicated feature branch (e.g., `feature/login`, `feature/create-account`).
- **Protected `main` Branch:** Direct commits to the `main` branch are disallowed to maintain stability.
- **Pull Requests (PRs):** All changes are merged into `main` via pull requests, requiring review and approval.

---

## 📄 License

This project does not specify a license. Please refer to the GitHub repository for any licensing information.

---

## 🔗 Important Links

- **Repository:** [INF-164-Group-Project](https://github.com/OTWL/INF-164-Group-Project)
- **Git Guide:** [HOW_TO_GIT.md](https://github.com/OTWL/INF-164-Group-Project/blob/main/HOW_TO_GIT.md)

---

<p align="center"><i>Built with C#, text files, and the collective patience of 8 people in one repo.</i></p>

---

## Footer

<div align="center">
  <p><b>INF-164-Group-Project</b></p>
  <p><a href="https://github.com/OTWL/INF-164-Group-Project">View Repository</a></p>
  <p>Built by the INF 164 Group</p>
  <p>
    <a href="https://github.com/OTWL/INF-164-Group-Project/stargazers"><img alt="Stars" src="https://img.shields.io/github/stars/OTWL/INF-164-Group-Project?style=social"></a>
    <a href="https://github.com/OTWL/INF-164-Group-Project/forks"><img alt="Forks" src="https://img.shields.io/github/forks/OTWL/INF-164-Group-Project?style=social"></a>
    <a href="https://github.com/OTWL/INF-164-Group-Project/issues"><img alt="Issues" src="https://img.shields.io/github/issues/OTWL/INF-164-Group-Project?style=social"></a>
  </p>
</div>


---
**<p align="center">Generated by [ReadmeCodeGen](https://www.readmecodegen.com/)</p>**
