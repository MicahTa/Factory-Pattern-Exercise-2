class Sofmore : IGrade {
    public List<string> requiredClasses => new List<string> {"Science2", "English2", "Math2" };
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