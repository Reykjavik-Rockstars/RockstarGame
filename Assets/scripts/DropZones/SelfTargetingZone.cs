﻿public class SelfTargetingZone : TargetingZone
{
    protected override void Awake()
    {
        GameInfo.singleton.selfTargetZone = this;
    }
    protected override void Start()
    {
    }
}