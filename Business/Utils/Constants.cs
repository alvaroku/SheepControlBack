using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utils
{
    public class Constants
    {
        public static string SHEEPIMAGEPATH = "imgs/sheep/";
        public static string VACCINEIMAGEPATH = "imgs/vaccine/";

        #region Controllers
        public static string CONTROLLER_ACTION = "Action";
        public static string CONTROLLER_CONTROLLER = "Controller";
        public static string CONTROLLER_PERMISSION = "Permission";
        public static string CONTROLLER_USER = "User";
        public static string CONTROLLER_ROLE = "Role";
        public static string CONTROLLER_PERMISSIONROLE = "PermissionRole";
        public static string CONTROLLER_ROLEUSER = "RoleUser";
        public static string CONTROLLER_SHEEP = "Sheep";
        public static string CONTROLLER_VACCINE = "Vaccine";
        public static string CONTROLLER_VACCINESHEEP = "VaccineSheep";
        #endregion

        #region DefaultActions
        public static string ACTION_CREATE = "Create";
        public static string ACTION_READ = "Read";
        public static string ACTION_UPDATE = "Update";
        public static string ACTION_DELETE = "Delete";
        #endregion

        #region AditionalActions
        public static string ACTION_TOGGLEACTIVE = "ToggleActive";
        public static string ACTION_GETBYID = "GetById";
        public static string ACTION_DELETEALL = "DeleteAll";
        #endregion

        #region Roles
        public static string ROLE_SUPERADMIN = "SuperAdmin";
        public static string ROLE_ADMIN = "Admin";
        public static string ROLE_USER = "User";
        public static string ROLE_INVITED = "Invited";
        public static string ROLE_CUSTOM = "Custom";
        #endregion

        public static string[] Controllers = new string[] { CONTROLLER_ACTION, CONTROLLER_CONTROLLER, CONTROLLER_PERMISSION, CONTROLLER_USER, CONTROLLER_PERMISSIONROLE,CONTROLLER_ROLE,CONTROLLER_ROLEUSER, CONTROLLER_SHEEP, CONTROLLER_VACCINE, CONTROLLER_VACCINESHEEP };
        public static string[] Actions = new string[] {ACTION_CREATE, ACTION_READ, ACTION_UPDATE, ACTION_DELETE,ACTION_TOGGLEACTIVE,ACTION_GETBYID,ACTION_DELETEALL};
        public static string[] Roles = new string[] {ROLE_SUPERADMIN, ROLE_ADMIN, ROLE_USER, ROLE_INVITED,ROLE_CUSTOM};

        public static string USER_SUPERADMIN_NAME = "sa";
        public static string USER_SUPERADMIN_EMAIL = "sa@gmail.com";
        public static string USER_SUPERADMIN_PASSWORD = "sa";
        public static string USER_SUPERADMIN_PHONE = "9919596720";
    }
}
