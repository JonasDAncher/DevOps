namespace MiniTwitCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        //Returns a new connection to the database
        public void connect_db(){}

        //Creates the database tables
        public void init_db(){}

        //Queries the database and returns a list of dictionaries
        public void query_db(){}

        //Convenience method to look up the id for a username
        public void get_user_id(){}

        //Format a timestamp for display
        public void format_datetime(){}

        //Return the gravatar image for the given email address
        public void gravatar_url(){}


        /* 
        
        Before and After requests 
        
        */

        /*
        Shows a users timeline or if no user is logged in it will
        redirect to the public timeline.  This timeline shows the user's
        messages as well as all the messages of followed users.
        */
        public void timeline(){}

        //Displays the latest messages of all users.
        public void public_timeline(){}

        //Display's a users tweets
        public void user_timeline(){}

        //Adds the current user as follower of the given user
        public void follow_user(){}

        //Removes the current user as follower of the given user
        public void unfollow_user(){}

        //Registers a new message for the user
        public void add_message(){}

        //Logs the user in
        public void login(){}
        
        //Registers the user
        public void register(){}
        
        //Logs the user out
        public void logout(){}
    }
}