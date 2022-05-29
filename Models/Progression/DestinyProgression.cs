namespace bulkybook.Models;

public class DestinyProgression
{
    public UInt32 progressionHash {get;set;}
    public Int32 dailyProgress {get;set;}
    public Int32 dailyLimit {get;set;}
    public Int32 weeklyProgress {get;set;}
    public Int32 weeklyLimit {get;set;}
    public Int32 currentProgress {get;set;}
    public Int32 level {get;set;}
    public Int32 levelCap {get;set;}
    public Int32 stepIndex {get;set;}
    public Int32 progressToNextLevel {get;set;}
    public Int32 nextLevelAt {get;set;}
    public Int32 currentResetCount {get;set;}
    public List<DestinyProgressionResetEntry> seasonResets {get;set;}
    public List<Int32> rewardItemStates {get;set;}
}