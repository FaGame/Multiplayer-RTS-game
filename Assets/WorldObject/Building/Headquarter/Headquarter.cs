﻿public class Headquarter : Building
{
    protected override void Awake()
    {
        base.Awake();
        objectName = "Headquarter";
        maxHitPoints = 100;
        cost = 250;
        sellValue = 125;
    }

    protected override void Start()
    {
        base.Start();
        actions = new string[] { "Worker" };
    }

    public override void PerformAction(string actionToPerform)
    {
        base.PerformAction(actionToPerform);
        CreateUnit(actionToPerform);
    }

    protected override bool ShouldMakeDecision()
    {
        return false;
    }
	
	protected override void PlayerCreateUnit(int worldObjectId)
	{
		player.CmdAddUnit(worldObjectId, buildQueue.Dequeue(), spawnPoint, rallyPoint, transform.rotation, -1);
	}
}
