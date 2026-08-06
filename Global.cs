using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace GroupProject
{

    public static class Global
    {

        //Wth does this even do?
        //Maybe this should return an index of where it is?
        //Or just return the content of that file

        //Use static so that we do not create a new object. Belongs t Global
        public static bool TryGetUser(string Username, out string Output)
        {
            //Returns true if found; false if not

            StreamReader inputFile = null;
            //Open file
            try
            {
                inputFile = new StreamReader("Users.txt");


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
                //Maybe we can create a file if none exists
                MessageBox.Show("Could not find a user's File");
                Output = "";
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured\nPlease try again");
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

        //Gloab vat to acces user object everywhere
        public static User CurrentUser;

        public class User
        {
            private string mUsername;
            //Constructor
            public User(string Username)
            {
                mUsername = Username;
            }

            public string GetUsername()
            {
                return mUsername;
            }



        }


    }


}
