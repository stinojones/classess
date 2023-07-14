
public class ChecklistGoal : Goal
{
    private int completionThreshold;
    private int completionCount;
    private int bonusValue;

    public ChecklistGoal(string name, int value, int threshold, int bonusValue) : base(name, value)
    {
        SetCompletionThreshold(threshold);
        SetCompletionCount(0);
        SetBonusValue(bonusValue);
    }

    public int GetCompletionThreshold()
    {
        return completionThreshold;
    }

    public void SetCompletionThreshold(int threshold)
    {
        completionThreshold = threshold;
    }

    public int GetCompletionCount()
    {
        return completionCount;
    }

    public void SetCompletionCount(int count)
    {
        completionCount = count;
    }

    public int GetBonusValue()
    {
        return bonusValue;
    }

    public void SetBonusValue(int value)
    {
        bonusValue = value;
    }

    public override void MarkComplete()
    {
        SetCompletionCount(GetCompletionCount() + 1);

        if (GetCompletionCount() >= GetCompletionThreshold())
        {
            SetIsComplete(true);
            SetValue(GetValue() + GetBonusValue());
        }
    }
}
