using System;

namespace CityKataDesign {
    public interface Visitable {
    void Accept(IVisitor visitor);
}

public interface IVisitor {
    void Visit(Visitable visitable);
    void Visit(ArmyArea area);
    void Visit(PoliticalArea area);
    void Visit(EducationalArea area);
    string Report();
}

public class ReportingVisitor : IVisitor {
    private string report;
    public void Visit(Visitable visitable) {
        throw new System.Exception("Not implemented");
    }

    public void Visit(ArmyArea area) {
        this.report += $"Nous sommes {area.Size} {area.Name}, ";
    }

    public void Visit(PoliticalArea area) {
        this.report += $"{area.PartyName} de {area.Gouvernor} ont gagné et ";
    }

    public void Visit(EducationalArea area) {
        this.report += $"{area.Director} est directeur de l'{area.Name}.";
    }

    public string Report() {
        return this.report;
    }
}
}