using System.IO.Pipelines;

class UniversityRegistry
{
    List<UniversityMember> _members;

    public UniversityRegistry() { _members = new List<UniversityMember>(); }

    public void AddMember(UniversityMember m) { _members.Add(m);}

    public void ExecuteAllDuties()
    {
        foreach (UniversityMember m in _members)
            m.PerformDuties();
    }

    public string GetMemberStatistics()
    {
        string result = "";
        foreach (UniversityMember m in _members)
            result += m.ToString();
        return result;
    }
}
