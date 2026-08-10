using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GroupProject
{

    public static class Global
    {

        //Wth does this even do?
        //Maybe this should return an index of where it is?
        //Or just return the content of that file

        //Use static so that we do not create a new object. Belongs t Global
        public static bool TryGetUserInfo(string Username, string FileName, out string Output)
        {
            //Returns true if found; false if not

            //If the file does not exist create it and then close it as it opens it on create leading to problems
            if (!File.Exists(FileName))
            {
                File.Create(FileName).Close();
            }

            StreamReader inputFile = null;
            //Open file
            try
            {
                inputFile = new StreamReader(FileName);


                /*
                    Get file line by line
                    File will look like this:
                    Username|Password
                */

                string inputLine = inputFile.ReadLine();

                //While not EOF
                while (inputLine != null)
                {
                    //Get pos of | in string
                    int index = inputLine.IndexOf('|');

                    //Copy to that pos
                    string searchUsername = inputLine.Substring(0, index);

                    //User found
                    if (searchUsername == Username)
                    {
                        //Return everything except the username +1 cuz of the |
                        Output = inputLine.Substring(index + 1);
                        return true;
                    }
                    else
                    {
                        //Read Next Line
                        inputLine = inputFile.ReadLine();
                    }

                }

                //If no username found
                Output = "";
                return false;


            }
            catch (FileNotFoundException)
            {
                Output = "";
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred\nPlease try again");
                Output = "";
                return false;
            }
            finally
            {
                //If null then there was no file open
                if (inputFile != null)
                {
                    inputFile.Close();
                }
            }
        }

        public static bool TrySaveCoverImage(string songTitle, string coverPath)
        {
            const int USERNAME = 0;
            const int PLAYLIST = 1;
            const int DOC = 2;
            const int COVERPATH = 3;
            const string FILEPATH = "Playlists.txt";

            try
            {
                if (!File.Exists(FILEPATH))
                {
                    File.Create(FILEPATH).Close();
                    MessageBox.Show("Could not find playlist");
                    return false;
                }

                string[] lines = File.ReadAllLines(FILEPATH);
                int TargetLine = -1;


                //Loop through the lines
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split('|');
                    if (parts[USERNAME] == CurrentUser.GetUsername() && parts[PLAYLIST] == songTitle)
                    {
                        TargetLine = i;
                        break;
                    }
                }
                if (TargetLine == -1)
                {
                    MessageBox.Show("Playlist could not be found");
                    return false;
                }

                //Read all lines

                //Split target string
                string[] targetString = lines[TargetLine].Split('|');
                //Rewrite path
                targetString[COVERPATH] = coverPath;
                //Join string of dissesabled one
                lines[TargetLine] = string.Join("|", targetString);
                //Rewrite entire file
                File.WriteAllLines(FILEPATH, lines);

                return true;
            }
            catch
            {
                MessageBox.Show("An error occured, please try again later");
                return false;
            }
        }

        // Global var to access the current user object everywhere
        public static User CurrentUser;

        public class Playlist
        {
            //One playlist name
            private string mTitle;
            private string mDateOfCreation;
            private string mCoverArtPath;


            //Constructor
            public Playlist(string title, string CoverArtPath, string DateOfCreation = "")
            {
                mTitle = title;
                mCoverArtPath = CoverArtPath;

                if (DateOfCreation == "")
                {
                    mDateOfCreation = DateTime.Now.ToString("yyyy/MM/dd");
                }
                else
                {
                    mDateOfCreation = DateOfCreation;
                }
                //USE THIS DATE FORMAT OR Problems will occur
            }

            public string GetTitle()
            {
                return mTitle;
            }

            public string GetDateOfCreation()
            {
                return mDateOfCreation;
            }

            public string getCoverPath()
            {
                return mCoverArtPath;
            }

            public void SetCoverpath(string CoverPath)
            {
                mCoverArtPath = CoverPath;
            }
        }

        public class User
        {
            private string mUsername;
            private string mProfilePath;

            //Create List that stores all the playlists
            private List<Playlist> mPlaylists = new List<Playlist>();

            public Playlist GetPlaylistByIndex(int index)
            {
                return mPlaylists[index];
            }

            public string GetCoverPathByIndex(int index)
            {
                return mPlaylists[index].getCoverPath();
            }

            //Constructor
            public User(string Username, string FilePath)
            {
                mUsername = Username;
                mProfilePath = FilePath;
            }

            public string GetUsername()
            {
                return mUsername;
            }

            public string GetProfileFilePath()
            {
                return mProfilePath;
            }
            // Playlists will be stored in text file
            // Songs will be stored in a songs folder
            // Save Playlists Names in a LIST cuz we then fetch the names of the song selected

            //Return Playlists
            public List<Playlist> GetPlaylists()
            {
                string playlistPath = "Playlists.txt";

                //Return all playlist names date of creation 
                mPlaylists.Clear();

                if (!File.Exists(playlistPath))
                {
                    File.Create(playlistPath).Close();
                }

                StreamReader inputFile = null;
                try
                {
                    inputFile = new StreamReader(playlistPath);

                    string line = inputFile.ReadLine();

                    int Username = 0;
                    int Title = 1;
                    int DateOfCreation = 2;
                    int Path = 3;
                    while (line != null)
                    {
                        //Username|Title|yyyy-MM-dddd|File Path

                        string[] parts = line.Split('|');
                        if (parts[Username] == CurrentUser.GetUsername())
                        {
                            Playlist p = new Playlist(parts[Title], parts[Path], parts[DateOfCreation]);
                            mPlaylists.Add(p);
                        }


                        //Go to next line
                        line = inputFile.ReadLine();


                    }

                    return mPlaylists;
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Could not find file");
                    //Can return as it's empty
                    return mPlaylists;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong, please try again later");
                    return mPlaylists;
                }
                finally
                {
                    if (inputFile != null)
                    {
                        inputFile.Close();
                    }
                }
            }

            public void AddPlaylists(string Playlist)
            {
                //Add the playlist to the link
                //  mPlaylists.Add(Playlist);
            }


            #region Future Code
            // *Return List of Song object
            /*
             * 
             * This is for the 2nd Deliverable
             * 
            public List<Song> getSongs(string Playlist)
            {
                //Return all the songs of said playlist
                //Get all the song titles of that playlist

                if (TryGetUserInfo(mUsername, "AllPlaylist.txt", out string SongString))
                {
                    //Get info
                    //Create list to store in
                    List<Song> songs = new List<Song>();

                    //Blue bean ice cream - Benson Joon|Idk - blah blah| ->
                    //We also need to store date of creation and 

                    string[] parts = SongString.Split('|');
                    //Blue bean ice cream - Beson Joon

                    int indexOfDash = -1;

                    foreach (string s in parts)
                    {

                        indexOfDash = s.IndexOf('-');

                        //-1 due to space infront of -
                        string title = s.Substring(0, indexOfDash - 1);

                        //This is then the Artist
                        // - Benson Joon
                        //But +1 so Benson Joon
                        artist = s.Substring(indexOfDash + 1);

                        //File path empty for now
                        Song SongObject = new Song(title, artist)

                        //Create a new object and add it to a list to return later
                        songs.Add(SongObject);
                    }
            */
            #endregion

            //Value is Null
            private string mSelectedPlaylistId;

            //setter to store selected id
            public void setSelectedPlaylistId(string id)
            {
                mSelectedPlaylistId = id;
            }


            //getter to get the selected id 
            public string GetSelectedPlaylistId()
            {
                return mSelectedPlaylistId;
            }

            //method to get playlist object by its id
            public Playlist GetPlaylistID(string id)
            {
                //making sure list is populated
                List<Playlist> list = GetPlaylists();

                //Loop through the list and return the playlist if it's titke matches the one given
                foreach (Playlist p in list)
                {
                    if (p.GetTitle() == id)
                    {
                        return p;
                    }
                }

                //Found nothing return null
                return null;
            }
        }



    }


}

