namespace Examinationsuppgift2.EntityClasses
{
    public class UserClass : EntityClass
    {
        public int AmountOfWins { get; set; } = 0;
        public int AmountOfLosses { get; set; } = 0;

        public void SetActionState(UserAction action)
        {
            ActionState = action;
        }
    }
}
