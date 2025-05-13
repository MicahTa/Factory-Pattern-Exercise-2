class Senior : IGrade {
    public List<string> requiredClasses => new List<string> { "Senior Sem", "Civics", "English4", "Math4" };
    public List<string> ReturnAvailableClasses(List<string>? classesTaken) {
        List<string> availableClasses = new List<string> { "Art", "Band", "IDK" };
        if (classesTaken == null) {
            return availableClasses;
        }
        foreach (string classes in classesTaken) {
            if (availableClasses.Contains(classes)) {
                availableClasses.Remove(classes);
            }
        }
        return availableClasses;
    }
}