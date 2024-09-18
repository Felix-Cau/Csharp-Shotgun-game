using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examinationsuppgift2.HelperClasses
{
    public class ActionEnum
    {
        public enum UserAction { Load, Block, Shoot, Shotgun }

        private static Random random = new Random();

        public static UserAction GetRandomActionChoise()
        {
            UserAction[] actionOptions = (UserAction[])Enum.GetValues(typeof(UserAction));
            return actionOptions[random.Next(actionOptions.Length)];
        }
        public static T GetRandomActionChoise<T>(params T[] actionOptions) where T : Enum
        {
            return actionOptions[random.Next(actionOptions.Length)];
        }
    }
}
