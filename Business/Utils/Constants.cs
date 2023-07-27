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
        public static string USERIMAGEPATH = "imgs/user/";

        public static string CreateSuccesMessage = "Datos registrados correctamente.";
        public static string UpdateSuccesMessage = "Datos actualizados correctamente.";
        public static string DeleteSuccesMessage = "Registro elimminado.";
        public static string ActiveSuccesMessage = "Registro activado.";
        public static string InactiveSuccesMessage = "Registro inactivado.";


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
        public static string CONTROLLER_VACCINESTOCK = "VaccineStock";
        public static string CONTROLLER_VACCINESHEEP = "VaccineSheep";
        public static string CONTROLLER_SALESHEEP = "SaleSheep";
        public static string CONTROLLER_SHEEPHISTORICWEIGHT = "SheepHistoricWeight";

        #endregion

        #region DefaultActions
        public static string ACTION_CREATE = "Create";
        public static string ACTION_READ = "Read";
        public static string ACTION_UPDATE = "Update";
        public static string ACTION_DELETE = "Delete";
        public static string ACTION_READWITHFILTERS = "GetWithFilters";
        public static string ACTION_GETSHEEPWITHFINALWEIGHT = "GetSheepWithFinalWeight";
        #endregion

        #region AditionalActions
        public static string ACTION_TOGGLEACTIVE = "ToggleActive";
        public static string ACTION_GETBYID = "GetById";
        public static string ACTION_DELETEALL = "DeleteAll";

        public static string ACTION_UPDATEPROFILE = "UpdateProfile";
        #endregion

        #region Roles
        public static string ROLE_SUPERADMIN = "SuperAdmin";
        public static string ROLE_ADMIN = "Admin";
        public static string ROLE_USER = "User";
        public static string ROLE_INVITED = "Invited";
        public static string ROLE_CUSTOM = "Custom";
        #endregion

        public static string[] Controllers = new string[] { CONTROLLER_ACTION, CONTROLLER_CONTROLLER, CONTROLLER_PERMISSION, CONTROLLER_USER, CONTROLLER_PERMISSIONROLE, CONTROLLER_ROLE, CONTROLLER_ROLEUSER, CONTROLLER_SHEEP, CONTROLLER_VACCINE, CONTROLLER_VACCINESTOCK, CONTROLLER_VACCINESHEEP, CONTROLLER_SALESHEEP, CONTROLLER_SHEEPHISTORICWEIGHT };
        public static string[] Actions = new string[] { ACTION_CREATE, ACTION_READ, ACTION_UPDATE, ACTION_DELETE, ACTION_TOGGLEACTIVE, ACTION_GETBYID, ACTION_DELETEALL, ACTION_READWITHFILTERS, ACTION_GETSHEEPWITHFINALWEIGHT };
        public static string[] Roles = new string[] { ROLE_SUPERADMIN, ROLE_ADMIN, ROLE_USER, ROLE_INVITED, ROLE_CUSTOM };

        public static string USER_SUPERADMIN_NAME = "sa";
        public static string USER_SUPERADMIN_EMAIL = "sa@gmail.com";
        public static string USER_SUPERADMIN_PASSWORD = "sa";
        public static string USER_SUPERADMIN_PHONE = "9919596720";

        string USER_ADMIN_NAME = "admin";
        string USER_ADMIN_EMAIL = "admin@gmail.com";
        string USER_ADMIN_PASSWORD = "admin";
        string USER_ADMIN_PHONE = "9919596720";

        string USER_USER_NAME = "Alvaro Kú";
        string USER_USER_EMAIL = "alvaroku123@gmail.com";
        string USER_USER_PASSWORD = "12345";
        string USER_USER_PHONE = "9919596720";
    }
}
