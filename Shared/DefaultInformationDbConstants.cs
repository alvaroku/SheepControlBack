namespace Shared
{
    public class DefaultInformationDbConstants
    {
        #region Controllers
        public const string CONTROLLER_ACTION = "Action";
        public const string CONTROLLER_CONTROLLER = "Controller";
        public const string CONTROLLER_PERMISSION = "Permission";
        public const string CONTROLLER_USER = "User";
        public const string CONTROLLER_ROLE = "Role";
        public const string CONTROLLER_PERMISSIONROLE = "PermissionRole";
        public const string CONTROLLER_ROLEUSER = "RoleUser";
        public const string CONTROLLER_SHEEP = "Sheep";
        public const string CONTROLLER_VACCINE = "Vaccine";
        public const string CONTROLLER_VACCINESTOCK = "VaccineStock";
        public const string CONTROLLER_VACCINESHEEP = "VaccineSheep";
        public const string CONTROLLER_SALESHEEP = "SaleSheep";
        public const string CONTROLLER_SHEEPHISTORICWEIGHT = "SheepHistoricWeight";
        #endregion

        #region DefaultActions
        public const string ACTION_CREATE = "Create";
        public const string ACTION_READ = "Read";
        public const string ACTION_UPDATE = "Update";
        public const string ACTION_DELETE = "Delete";
        public const string ACTION_READWITHFILTERS = "GetWithFilters";
        #endregion

        #region AditionalActions
        public const string ACTION_TOGGLEACTIVE = "ToggleActive";
        public const string ACTION_GETBYID = "GetById";
        public const string ACTION_DELETEALL = "DeleteAll";
        public const string ACTION_GETSHEEPWITHFINALWEIGHT = "GetSheepWithFinalWeight";//solo para sheep
        public const string ACTION_UPDATEPROFILE = "UpdateProfile";
        #endregion

        #region Roles
        public const string ROLE_SUPERADMIN = "SuperAdmin";
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_USER = "User";
        public const string ROLE_INVITED = "Invited";
        public const string ROLE_CUSTOM = "Custom";
        #endregion

        public static string[] _Controllers = new string[] { CONTROLLER_ACTION, CONTROLLER_CONTROLLER, CONTROLLER_PERMISSION, CONTROLLER_USER, CONTROLLER_PERMISSIONROLE, CONTROLLER_ROLE, CONTROLLER_ROLEUSER, CONTROLLER_SHEEP, CONTROLLER_VACCINE, CONTROLLER_VACCINESTOCK, CONTROLLER_VACCINESHEEP, CONTROLLER_SALESHEEP, CONTROLLER_SHEEPHISTORICWEIGHT };
        public static string[] _Actions = new string[] { ACTION_CREATE, ACTION_READ, ACTION_UPDATE, ACTION_DELETE, ACTION_TOGGLEACTIVE, ACTION_GETBYID, ACTION_DELETEALL, ACTION_READWITHFILTERS, ACTION_GETSHEEPWITHFINALWEIGHT, ACTION_UPDATEPROFILE };
        public static string[] _Roles = new string[] { ROLE_SUPERADMIN, ROLE_ADMIN, ROLE_USER, ROLE_INVITED, ROLE_CUSTOM };


        #region usuarios 
        public const string USER_SUPERADMIN_NAME = "sa";
        public const string USER_SUPERADMIN_EMAIL = "sa@gmail.com";
        public const string USER_SUPERADMIN_PHONE = "9919596720";

        public const string USER_ADMIN_NAME = "admin";
        public const string USER_ADMIN_EMAIL = "admin@gmail.com";
        public const string USER_ADMIN_PHONE = "9919596720";

        public const string USER_USER_NAME = "Alvaro";
        public const string USER_USER_LASTNAME = "Kú";
        public const string USER_USER_EMAIL = "alvaroku123@gmail.com";
        public const string USER_USER_PHONE = "9919596720";

        public const string USER_INVITED_NAME = "Invitado";
        public const string USER_INVITED_EMAIL = "invitado@gmail.com";
        public const string USER_INVITED_PHONE = "9919596720";
        #endregion
    }
}
