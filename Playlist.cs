using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
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
}

