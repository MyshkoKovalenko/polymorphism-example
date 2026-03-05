class UniversityMember
{
    private int _dailyActions;
    private string Name
    {
        get;
        set
        {
            string name = value.Trim();
            if (name == "" || value == null)
                field = "Unnamed";
            else
                field = name;
        }
    }
    private string MemberId { get; set; }
    protected List<string> ActionLog;

    public UniversityMember(string name)
    {
        _dailyActions = 0;
        Name = name;
        MemberId = Globals.rd.GetHexString(6);
        ActionLog = new List<string>();
    }

    public virtual void PerformDuties()
    {
        if (_dailyActions++ >= 5)
            throw new Exception("Too much work for today.");
    }

    public override string ToString()
    {
        string result = $"{MemberId}: {Name}. Duties performed today:{_dailyActions}\nHistory:\n";
        foreach (string a in ActionLog)
            result += $"- {a}\n";
        return result;
    }
}

class Professor : UniversityMember
{
    public Professor(string name) : base(name) {}
    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
    }
    public void ConductResearch(string topic)
    {
        ActionLog.Add($"Conducted research about {topic}.");
    }
}

class UndergraduateStudent : UniversityMember
{
    public UndergraduateStudent(string name) : base(name) {}

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lab work completed.");
    }
}

class GraduateStudent : UndergraduateStudent
{
    public GraduateStudent(string name) : base(name) {}

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Thesis research update.");
    }
}
