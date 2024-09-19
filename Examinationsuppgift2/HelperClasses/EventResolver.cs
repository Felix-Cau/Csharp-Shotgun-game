using Examinationsuppgift2.EntityClasses;

namespace Examinationsuppgift2.HelperClasses
{
    public static class EventResolver
    {
        public static (Player, Npc) CalculateResolution(Player player, Npc npc)
        {
            Player _localPlayer = player;
            Npc _localNpc = npc;
            ActionOptionsEnum playerAction = _localPlayer.ActionState;
            ActionOptionsEnum npcAction = npc.ActionState;

            switch (playerAction)
            {
                case ActionOptionsEnum.Load:
                    if (npcAction == ActionOptionsEnum.Load)
                    {
                        _localPlayer.AmmoCount++;
                        _localPlayer.EventMessage = StaticMessages.TieMessage;
                        _localNpc.AmmoCount++;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Block)
                    {
                        _localPlayer.AmmoCount++;
                        _localPlayer.EventMessage = StaticMessages.TieMessage;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Shoot)
                    {
                        _localPlayer.AmountOfLosses++;
                        _localPlayer.EventMessage = StaticMessages.LoseMessage;
                        _localPlayer.AmmoCount = 0;
                        _localNpc.AmmoCount = 0;
                        return (_localPlayer, _localNpc);
                    }
                    else
                    {
                        _localPlayer.AmountOfLosses++;
                        _localPlayer.EventMessage = StaticMessages.LoseMessage;
                        _localPlayer.AmmoCount = 0;
                        _localNpc.AmmoCount = 0;
                        return (_localPlayer, _localNpc);
                    }
                case ActionOptionsEnum.Block:
                    if (npcAction == ActionOptionsEnum.Load)
                    {
                        _localPlayer.EventMessage = StaticMessages.TieMessage;
                        _localNpc.AmmoCount++;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Block)
                    {
                        _localPlayer.EventMessage = StaticMessages.TieMessage;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Shoot)
                    {
                        _localPlayer.EventMessage = StaticMessages.TieMessage;
                        _localNpc.AmmoCount--;
                        return (_localPlayer, _localNpc);
                    }
                    else
                    {
                        _localPlayer.AmountOfLosses++;
                        _localPlayer.EventMessage = StaticMessages.LoseMessage;
                        _localPlayer.AmmoCount = 0;
                        _localNpc.AmmoCount = 0;
                        return (_localPlayer, _localNpc);
                    }
                case ActionOptionsEnum.Shoot:
                    if (npcAction == ActionOptionsEnum.Load)
                    {
                        _localPlayer.AmountOfWins++;
                        _localPlayer.AmmoCount = 0;
                        _localPlayer.EventMessage = StaticMessages.WinMessage;
                        _localNpc.AmmoCount = 0;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Block)
                    {
                        _localPlayer.AmmoCount--;
                        _localPlayer.EventMessage = StaticMessages.TieMessage;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Shoot)
                    {
                        _localPlayer.AmmoCount--;
                        _localPlayer.EventMessage = StaticMessages.TieMessage;
                        _localNpc.AmmoCount--;
                        return (_localPlayer, _localNpc);
                    }
                    else
                    {
                        _localPlayer.AmountOfLosses++;
                        _localPlayer.EventMessage = StaticMessages.LoseMessage;
                        _localPlayer.AmmoCount = 0;
                        _localNpc.AmmoCount = 0;
                        return (_localPlayer, _localNpc);
                    }
                case ActionOptionsEnum.Shotgun:
                    if (npcAction == ActionOptionsEnum.Load)
                    {
                        _localPlayer.AmountOfWins++;
                        _localPlayer.AmmoCount = 0;
                        _localNpc.AmmoCount = 0;
                        _localPlayer.EventMessage = StaticMessages.WinMessage;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Block)
                    {
                        _localPlayer.AmountOfWins++;
                        _localPlayer.AmmoCount = 0;
                        _localNpc.AmmoCount = 0;
                        _localPlayer.EventMessage = StaticMessages.WinMessage;
                        return (_localPlayer, _localNpc);
                    }
                    else if (npcAction == ActionOptionsEnum.Shoot)
                    {
                        _localPlayer.AmountOfWins++;
                        _localPlayer.AmmoCount = 0;
                        _localNpc.AmmoCount = 0;
                        _localPlayer.EventMessage = StaticMessages.WinMessage;
                        return (_localPlayer, _localNpc);
                    }
                    else
                    {
                        _localPlayer.AmmoCount -= 3;
                        _localPlayer.EventMessage = StaticMessages.TieMessage;
                        _localNpc.AmmoCount -= 3;
                        return (_localPlayer, _localNpc);
                    }
                default:
                    return (_localPlayer, _localNpc);
            }
        }
    }
}