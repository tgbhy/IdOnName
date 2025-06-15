using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerEvents = Exiled.Events.Handlers.Player;
using MEC;

namespace IdOnName
{
    public class EventsHandler
    {
        internal IdOnName Instance { get; }

        public EventsHandler(IdOnName Instance)
        {
            this.Instance = Instance;
        }

        internal void UpdatePlayerName(Player player)
        {
            string playerName = player.DisplayNickname;
            int PlayerId = player.Id;
            string format = Instance.Config.Format;
            player.DisplayNickname = format.Replace("{PlayerId}", PlayerId.ToString()).Replace("{PlayerName}", playerName);
        }

        public void Register()
        {
            PlayerEvents.Verified += OnPlayerVerified;
            PlayerEvents.ChangingRole += OnPlayerChangingRole;
        }

        public void Unregister()
        {
            PlayerEvents.Verified -= OnPlayerVerified;
            PlayerEvents.ChangingRole -= OnPlayerChangingRole;
        }

        internal void OnPlayerVerified(VerifiedEventArgs args)
        {
            UpdatePlayerName(args.Player);
        }

        internal void OnPlayerChangingRole(ChangingRoleEventArgs args)
        {
            if (Instance.Config.FormatOnRoleChange)
            {
                Timing.CallDelayed(2, () =>
                {
                    UpdatePlayerName(args.Player);
                });
            }
        }
    }
}
