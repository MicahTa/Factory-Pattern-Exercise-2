using System.Dynamic;

interface IGrade {
    public List<string> requiredClasses {get;}
    public List<string> ReturnAvailableClasses(List<string> classesTaken);
}