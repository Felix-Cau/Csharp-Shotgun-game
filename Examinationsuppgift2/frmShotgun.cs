using Examinationsuppgift2.EntityClasses;

namespace Examinationsuppgift2
{
    public partial class frmShotgun : Form
    {
        Player player = new();
        Npc npc = new();
        public frmShotgun()
        {
            InitializeComponent();
            lblDisplayUserWins.Text = player.AmountOfWins.ToString();
            lblDisplayUserLosses.Text = player.AmountOfLosses.ToString();
            lblDisplayAmmoCount.Text = player.AmmoCount.ToString();
            lblDisplayNpcAmmoCount.Text = npc.AmmoCount.ToString();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            player.ActionState = ActionOptionsEnum.Load;
            npc = npc.SetActionState(player, npc);
            (player, npc) = EventResolver.CalculateResolution(player, npc);
            frmEventresolution frmEventresolution = new frmEventresolution(player);
            frmEventresolution.Show();
            lblDisplayUserWins.Text = player.AmountOfWins.ToString();
            lblDisplayUserLosses.Text = player.AmountOfLosses.ToString();
            lblDisplayAmmoCount.Text = player.AmmoCount.ToString();
            lblDisplayNpcAmmoCount.Text = npc.AmmoCount.ToString();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            player.ActionState = ActionOptionsEnum.Block;
            npc = npc.SetActionState(player, npc);
            (player, npc) = EventResolver.CalculateResolution(player, npc);
            frmEventresolution frmEventresolution = new frmEventresolution(player);
            frmEventresolution.Show();
            lblDisplayUserWins.Text = player.AmountOfWins.ToString();
            lblDisplayUserLosses.Text = player.AmountOfLosses.ToString();
            lblDisplayAmmoCount.Text = player.AmmoCount.ToString();
            lblDisplayNpcAmmoCount.Text = npc.AmmoCount.ToString();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            player.ActionState = ActionOptionsEnum.Shoot;
            npc = npc.SetActionState(player, npc);
            (player, npc) = EventResolver.CalculateResolution(player, npc);
            frmEventresolution frmEventresolution = new frmEventresolution(player);
            frmEventresolution.Show();
            lblDisplayUserWins.Text = player.AmountOfWins.ToString();
            lblDisplayUserLosses.Text = player.AmountOfLosses.ToString();
            lblDisplayAmmoCount.Text = player.AmmoCount.ToString();
            lblDisplayNpcAmmoCount.Text = npc.AmmoCount.ToString();
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            player.ActionState = ActionOptionsEnum.Shotgun;
            npc = npc.SetActionState(player, npc);
            (player, npc) = EventResolver.CalculateResolution(player, npc);
            frmEventresolution frmEventresolution = new frmEventresolution(player);
            frmEventresolution.Show();
            lblDisplayUserWins.Text = player.AmountOfWins.ToString();
            lblDisplayUserLosses.Text = player.AmountOfLosses.ToString();
            lblDisplayAmmoCount.Text = player.AmmoCount.ToString();
            lblDisplayNpcAmmoCount.Text = npc.AmmoCount.ToString();
        }
    }
}
