using Exiled.API.Features;

namespace IdOnName
{
    public class IdOnName : Plugin<Config>
    {
        private EventsHandler? _eventsHandler;

        public override void OnEnabled()
        {
            _eventsHandler = new EventsHandler(this);
            _eventsHandler.Register();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            if (_eventsHandler != null) _eventsHandler.Unregister();
            base.OnDisabled();
        }
    }
}
