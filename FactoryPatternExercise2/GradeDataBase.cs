static class GradeDataBase {
    static public IGrade? GetGrade(string? grade){
        if (grade == null) {
            return null;
        }
        switch (grade.ToLower()) {
            case "freshman":
            case "9":
                return new Freshman();
            case "softmore":
            case "10":
                return new Sofmore();
            case "junior":
            case "11":
                return new Juinor();
            case "senior":
            case "12":
                return new Senior();
            default:
                return null;
        }
    }
}