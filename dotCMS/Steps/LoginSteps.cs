using dotCMS.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotCMS.Steps
{
    public class LoginSteps
    {
        LoginActions loginActions = new LoginActions();
        CMS001Actions cms001Actions = new CMS001Actions();

        public void LoginStep()
        {
            loginActions.Login();
        }
    }
}
