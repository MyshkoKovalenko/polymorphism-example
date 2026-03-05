UniversityRegistry UR = new UniversityRegistry();

Professor p1 = new Professor("Artem Korotenko");
UndergraduateStudent ugs1 = new UndergraduateStudent("John Pork");
GraduateStudent gs1 = new GraduateStudent("Tim Cheese");

p1.ConductResearch("Some Cool Stuff");

UR.AddMember(p1);
UR.AddMember(ugs1);
UR.AddMember(gs1);

UR.ExecuteAllDuties();

Console.WriteLine(UR.GetMemberStatistics());
