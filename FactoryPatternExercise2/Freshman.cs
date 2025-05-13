class Freshman : IGrade {
    public List<string> requiredClasses => new List<string> {"Science1", "English1", "Math1" };
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