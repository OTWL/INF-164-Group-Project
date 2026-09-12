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

        // Global var to access the current user object everywhere
        public static User CurrentUser;


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
                MessageBox.Show("An error occurred\nPlease try again\n" + ex);
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

    }
}

