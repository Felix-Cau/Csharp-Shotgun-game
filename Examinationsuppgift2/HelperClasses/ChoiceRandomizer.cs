namespace Examinationsuppgift2.HelperClasses
{
    public class ChoiceRandomizer
    {
        private static Random random = new Random();

        public static ActionOptionsEnum GetRandomActionChoise()
        {
            ActionOptionsEnum[] actionOptions = (ActionOptionsEnum[])Enum.GetValues(typeof(ActionOptionsEnum));
            return actionOptions[random.Next(actionOptions.Length)];
        }
        public static T GetRandomActionChoise<T>(params T[] actionOptions) where T : Enum
        {
            return actionOptions[random.Next(actionOptions.Length)];
        }
    }
}
