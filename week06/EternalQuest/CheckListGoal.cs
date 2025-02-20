public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Goal '{_shortName}' completed! You earned {_points} points.");

            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You completed '{_shortName}' and earned a bonus of {_bonus} points!");
            }
        }
        else
        {
            Console.WriteLine($"'{_shortName}' has already been completed.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[ {(IsComplete() ? "X" : " ")} ] {_shortName} - {_description} ({_points} points each time, Bonus: {_bonus} points after {_target} times) - Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }

    public int GetBonus()
    {
        return _bonus;
    }
}