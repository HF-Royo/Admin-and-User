namespace UserNamespace;

public class User
{

    private string user_id;
    
    protected string user_password;

        public void user(string id, string pass){

            this.user_id = id;
            this.user_password = pass;
        }

        public void updatePassword(string newPassword){

            this.user_password = newPassword;

        }
}

public class Administrator : User{

    private string admin_name;

        public void administrator(string name, string id, string pass){

        this.admin_name = name;
        this.user_password = pass;

        }
        public void updatePassword(string newPassword){

            this.user_password = newPassword;
        
        }

        public void updateAdminName(string name){

            this.admin_name = name;
        }
}
