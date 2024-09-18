namespace Examinationsuppgift2.EntityClasses
{
    public class Player : EntityClass
    {
        public int AmountOfWins { get; set; } = 0;
        public int AmountOfLosses { get; set; } = 0;

        public void SetActionState(ActionOptionsEnum action)
        {
            ActionState = action;
        }
    }
}
