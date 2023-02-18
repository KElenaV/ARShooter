
public class PlayerObserverEventHandler : DefaultObserverEventHandler
{
    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        Player player = GetComponentInChildren<Player>();
        if (player != null)
            player.enabled = true;
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        Player player = GetComponentInChildren<Player>();
        if (player != null)
            player.enabled = false;
    }
}
