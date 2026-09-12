using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
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

}

