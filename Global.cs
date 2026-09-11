using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace GroupProject
{

    public static class Global
    {

        //List containg all the user's
        public static List<User> allUsers = new List<User>();

        //Use static so that we do not create a new object. Belongs to Global
        //Updated to desirilaze the serialized file

        //Returns an user object
        public static bool TryGetUserInfo(string Username, string FileName, out User Output)
        {
            //Returns true if found; false if not

            //If the file does not exist create it and then close it as it opens it on create leading to problems
            if (!File.Exists(FileName + ".ser"))
            {
                File.Create(FileName + ".ser").Close();
            }
            //Check if the file is empty to avoid errors
            if (new FileInfo(FileName + ".ser").Length == 0)
            {
                Output = null;
                return false;
            }

            FileStream inFile = null;

            try
            {
                //Create a file stream to read from serilized file
                inFile = new FileStream(FileName + ".ser", FileMode.Open, FileAccess.Read);

                //Create a bin formatter
                BinaryFormatter bFormatter = new BinaryFormatter();

                //Clean all users to ensure a fresh list is being worked with
                allUsers.Clear();

                //Create a temp list of all the User objects saved in the Deserialized file
                allUsers = (List<User>)bFormatter.Deserialize(inFile);

                foreach (User myUser in allUsers)
                {
                    //Look for the user we want
                    if (myUser.Username == Username)
                    {
                        Output = myUser;
                        //Found user break
                        return true;
                    }
                }

                inFile.Close();

                //Return null instead of dummy data to avoid possiable errors of empty users being returned
                Output = null;
                return false;

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("An error occurred" + ex, "File Could not be found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Output = new User("", "", "");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred\nPlease try again" + ex);
                Output = new User("", "", "");
                return false;
            }
            finally
            {
                //If file opened or exist close it otherwise we try to clos an closed file
                if (inFile != null)
                {
                    inFile.Close();
                }
            }
        }

        //Add header to allow it to be saved as binary
        [Serializable]
        public class Song
        {
            private string mTitle;
            private string mArtist;
            private string mAlbum;
            private string mGenre;
            private string mFilePath;

            public string Title
            {
                get { return mTitle; }
                set { mTitle = value; }
            }


            public string Artist
            {
                get { return mArtist; }
                set { mArtist = value; }
            }

            public string Album
            {
                get { return mAlbum; }
                set { mAlbum = value; }
            }

            public string Genre
            {
                get { return mGenre; }
                set { mGenre = value; }
            }

            public string FilePath
            {
                get { return mFilePath; }
                set { mFilePath = value; }
            }

            //Constructor
            public Song(string title, string artist, string album, string genere, string filePath)
            {
                mTitle = title;
                mArtist = artist;
                mAlbum = album;
                mGenre = genere;
                //Always assign FilePath as the current user to keep track of ownership
                mFilePath = filePath;

            }
        };


        // Global var to access the current user object everywhere
        public static User CurrentUser;
        [Serializable]
        public class Playlist
        {
            //One playlist name
            private string mTitle;
            private string mDateOfCreation;
            private string mCoverArtPath;
            private bool mFavourite;
            private string mUsername;

            //Playlist song list
            private List<Song> mSongs = new List<Song>();
            public string Username
            {
                get { return mUsername; }
                set { mUsername = value; }

            }

            //Constructor
            public Playlist(string title, string CoverArtPath, string UserName, string DateOfCreation = "", bool isFavourite = false)
            {
                mTitle = title;
                mCoverArtPath = CoverArtPath;
                mFavourite = isFavourite;

                mUsername = UserName;

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

            public void Remove(Song song)
            {
                mSongs.Remove(song);
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

            public void AddSong(Song song)
            {
                mSongs.Add(song);
            }

            public List<Song> GetSongs()
            {
                return mSongs;
            }

        }

        //Make the user class be able to be Serializable need to do this for it to be able to save it to file in create account
        [Serializable]
        public class User
        {
            private string mUsername;
            private string mProfilePath;

            private string mPassword;

            //New get set for password
            public string Password
            {
                get { return mPassword; }
                set { mPassword = value; }
            }

            //Create List that stores all the playlists
            private List<Playlist> mPlaylists = new List<Playlist>();

            //Create a user playlist
            public List<Playlist> mUserPlaylist = new List<Playlist>();

            //List of the users songs
            public List<Song> mSongs = new List<Song>();

            public void populateUserSongs()
            {
                //Clear Users songs
                mSongs.Clear();

                //Populate list with all of the users songs


                // Loop throught all the playlist of the user
                foreach (Playlist playlist in mUserPlaylist)
                {
                    //Loop through all the playlist songs
                    foreach (Song song in playlist.GetSongs())
                    {
                        //Add song to list which belongs to this user
                        mSongs.Add(song);
                    }
                }
            }

            public string GetCoverPathByIndex(int index)
            {
                //Could rework
                return mPlaylists[index].getCoverPath();
            }

            //Constructor
            public User(string Username, string FilePath, string Password)
            {
                mUsername = Username;
                mProfilePath = FilePath;
                mPassword = Password;
            }
            public string Username
            {
                get { return mUsername; }
                set { mUsername = value; }

            }
            public string ProfilePath
            {
                get { return mProfilePath; }
                set { mProfilePath = value; }
            }

            // Save Playlists Names in a LIST, we then fetch the names of the song selected

            //Return Playlists
            public List<Playlist> GetPlaylists()
            {
                string playlistPath = "Playlists.ser";

                //Return all playlist names date of creation 
                mPlaylists.Clear();

                //Returns true if found; false if not

                //If the file does not exist create it and then close it as it opens it on create leading to problems
                if (!File.Exists(playlistPath))
                {
                    File.Create(playlistPath).Close();
                    return new List<Playlist>();
                }
                //Check if the file is empty to avoid errors
                if (new FileInfo(playlistPath).Length == 0)
                {
                    //Return empty playlist
                    return new List<Playlist>();
                }

                FileStream inFile = null;

                try
                {
                    //Create a file stream to read from serilized file
                    inFile = new FileStream(playlistPath, FileMode.Open, FileAccess.Read);
                    //Create a bin formatter
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    mPlaylists.Clear();
                    //  Create a temp list of all the User objects saved in the Deserialized file
                    mPlaylists = (List<Playlist>)bFormatter.Deserialize(inFile);

                    //WE NEED TO RETURN THE USER PLAYLISTs

                    //Clear playlist to avoid acidental stale data
                    mUserPlaylist.Clear();

                    foreach (Playlist newplaylist in mPlaylists)
                    {
                        if (newplaylist.Username == CurrentUser.Username)
                        {
                            mUserPlaylist.Add(newplaylist);
                        }

                    }

                    inFile.Close();

                    //Return all the playlist 
                    return mPlaylists;

                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show("An error occurred" + ex, "File Could not be found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Return empty playlist
                    return new List<Playlist>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred\nPlease try again" + ex);
                    //Return empty playlist
                    return new List<Playlist>();
                }
                finally
                {
                    if (inFile != null)
                    {
                        inFile.Close();
                    }
                }
            }

            public bool SavePlaylistToDisk()
            {
                //Save the entire playlist
                //Saves songs aswell
                FileStream outFile = null;
                try
                {
                    outFile = new FileStream("Playlists.ser", FileMode.Create, FileAccess.Write);
                    BinaryFormatter bFormatter = new BinaryFormatter();
                    //Save all of the playlists objects
                    bFormatter.Serialize(outFile, mPlaylists);
                    return true;
                }
                catch
                {
                    MessageBox.Show("Failed to save playlist");
                    return false;
                }
                finally
                {
                    //Check if file is open
                    // Can cause an error if it is closed and we try to close it
                    if (outFile != null)
                    {
                        outFile.Close();
                    }
                }

            }


            public void SaveNewPlaylist(Playlist newPlaylist)
            {
                mPlaylists.Add(newPlaylist);
                mUserPlaylist.Add(newPlaylist);
                //Save to disk
                SavePlaylistToDisk();
            }
            public void DeletePlaylist(Playlist playlist)
            {
                //remove it from the playlist list
                mPlaylists.Remove(playlist);

                //remove it from the logged-in user's list
                mUserPlaylist.Remove(playlist);

                //Save the updated playlists
                SavePlaylistToDisk();

            }


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
                    //Make sure playlist is owned by current user
                    if (p.GetTitle() == id && p.Username == CurrentUser.Username)
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

