static class GradeDataBase {
    static public IGrade? GetGrade(string? grade){
        if (grade == null) {
            return null;
        }
        switch (grade.ToLower()) {
            case "freshman":
                return new Freshman();
            case "softmore":
                return new Sofmore();
            case "junior":
                return new Juinor();
            case "senior":
                return new Senior();
            default:
                return null;
        }
    }
}