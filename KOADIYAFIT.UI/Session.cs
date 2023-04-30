using KOADIYAFIT.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KOADIYAFIT.UI
{
    public static class Session
    {
        #region User Data
        public static User CurrentUser { get; set; }

        public static UserMeal UserMealsInformation { get; set; }

        public static Food FoodInformation { get; set; }
        #endregion

        #region Application Forms
        public static MainForm MainForm { get; } = new MainForm();
        public static RegisterForm RegisterForm { get; } = new RegisterForm();
        public static MenuChoiceForm MenuChoiceForm { get; } = new MenuChoiceForm();
        public static AdminForm AdminForm { get; } = new AdminForm();
        public static FoodSelectForm FoodSelectForm { get; set; } = new FoodSelectForm();
        public static PersonalNotesForm PersonalNotesForm { get; set; } = new PersonalNotesForm();
        public static RaporForm RaporForm { get; set; } = new RaporForm();
        #endregion
    }
}
